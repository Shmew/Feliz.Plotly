namespace Fable.Plotly.Generator

open FSharp.Data
open FSharp.Data.JsonExtensions
open Domain

module ParserUtils =
    open Fake.IO
    open Fake.IO.FileSystemOperators

    /// The Plotly.js schema
    let schema : JsonValue =
        File.readAsString (__SOURCE_DIRECTORY__ @@ "../../paket-files/generator/plotly/plotly.js/dist/plot-schema.json")
        |> JsonValue.Parse

    /// Returns `true` if the `JsonValue` is a component
    let private isComp (jsonValue: JsonValue) : bool =
        jsonValue
        |> JsonValue.tryGetProp "role"
        |> Option.map (JsonValue.asString >> ((=) "object"))
        |> function
        | Some b -> b
        | None -> false

    /// Gets the description from the specified `JsonValue` when it is a component
    let private getCompDoc (jVal: JsonValue) : string list =
        jVal.TryGetProperty("meta")
        |> Option.bind (JsonValue.tryGetProp "description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the description from the specified `JsonValue` when it is a prop
    let private getPropDoc (jVal: JsonValue) : string list =
        jVal.TryGetProperty("description")
        |> Option.map JsonValue.asString
        |> Option.toList

    /// Gets the documentation of a specified `JsonValue`
    let getDocs (jVal: JsonValue) : string list =
        if isComp jVal then getCompDoc jVal
        else getPropDoc jVal
        |> List.map (fun s -> s.Trim().Trim('"'))
        |> List.filter (fun s -> s <> "")

    let trimBypass (s: string) : string =
        // if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7)
        // else s
        s.Replace("_BYPASS", "")

    let trimBypassWith (s: string) trueFun falseFun =
        if s.EndsWith("_BYPASS") then s.Substring(0, s.Length - 7) |> trueFun
        else falseFun s

    let skips : string list =
        schema?defs?metaKeys.AsArray()
        |> Array.toList
        |> List.map (JsonValue.asString >> trimJson)

    let traceChildrenWithJson =
        schema?traces.Properties

    let traceChildren : string list =
        traceChildrenWithJson
        |> Array.map fst
        |> List.ofArray

    let transformsChildren : string list =
        schema?transforms.Properties
        |> Array.map fst
        |> List.ofArray

    let hasEnums (jVal: JsonValue) : bool =
        jVal.TryGetProperty("valType")
        |> Option.map (JsonExtensions.AsString >> ((=) "enumerated"))
        |> Option.defaultValue false

    /// Gets anchor static mapping attributes
    let layoutAnchorMappings (compName: string) (propName: string) : {| Array: bool; Value: string |} =
        [ "polar"; "geo"; "mapbox"; "ternary" ]
        |> List.tryFind compName.Contains
        |> function
        | _ when propName = "xaxes" || propName = "yaxes" -> {| Value = propName; Array = true |}
        | _ when propName.StartsWith "x" || propName.StartsWith "y" -> {| Value = propName.Substring(0,1); Array = false |}
        | _ when List.contains propName [ "coloraxis"; "scene" ] -> {| Value = propName; Array = false |}
        | _ when compName = "Choropleth" && propName = "geo" -> {| Value = propName; Array = false |}
        | Some aName -> {| Value = aName; Array = false |}
        | _ -> failwith "Invalid anchor mapping call."

module ApiParser =
    open ParserUtils

    let manualDeprecated =
        [ ("layout", [ "radialaxis"; "angularaxis" ]) ]

    let isManualDeprecated componentName (name: string) =
        match List.filter (fst >> fun n -> n = componentName) manualDeprecated with
        | fList when fList.Length > 0 ->
            fList
            |> List.exists (snd >> List.exists (fun n -> n = name))
        | _ -> false

    /// Parses a `JsonValue` with given information and returns a `Prop`
    let parseProp componentTree propName (jVal: JsonValue) =
        let jumpArray = [ "annotations"; "dimensions"; "styles"; "buttons"; "aggregations"; "transforms" ]
        let typeAdders = [ "Traces"; "Transforms" ]
        let typeAdderChildren = traceChildren @ transformsChildren

        let isSkip =
            [ "meta"; "categories"; "animatable"; "type"; "layoutAttributes"; "requiredOpts"; "otherOpts"; "valType"; "transform" ]
            |> List.contains propName

        let isExpanded =
            let isExpandedLayout =
                [ "xaxis"; "yaxis"; "geo"; "ternary"; "polar"; "mapbox"; "coloraxis"; "scene" ]
                |> List.contains propName

            match (componentTree
                   |> List.rev
                   |> List.head), propName with
            | "Layout", _ when isExpandedLayout -> true
            | _ -> false

        let propMethodName =
            propName
            |> trimJson
            |> spaceCaseTokebabCase
            |> kebabCaseToCamelCase
            |> snakeCaseToCamelCase
            |> replaceAddSymbol
            |> appendApostropheToReservedKeywords

        let componentParent = componentTree |> List.rev |> List.head

        let mNameUpper = propMethodName |> String.upperFirst

        let axisInt axisIdentity isArray =
            if isArray then
                [ ValType.intSeqStrCustom "anchorIds"
                    (sprintf "anchorIds |> Seq.map (fun anchorId -> (sprintf \"%s%s\" %s) |> ResizeArray)"
                        axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")")
                  ValType.intStrCustom "anchorId"
                    (sprintf "(sprintf \"%s%s\" %s |> Array.singleton |> ResizeArray)"
                        axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")") ]
            else
                ValType.intStrCustom "anchorId"
                    (sprintf "(sprintf \"%s%s\" %s)"
                        axisIdentity "%s" "(if anchorId > 1 then (anchorId |> string) else \"\")")
                |> List.singleton

        let propType =
            let isPropAxis =
                [ "xaxis"; "yaxis"; "subplot"; "geo"; "coloraxis"; "scene" ]
                |> List.contains propName

            match componentParent, propName with
            | "Line", "color"
            | "Line", "width" -> { PrimSpecOverrides.empty with ArrayOk = true, true }
            | "Style", "value" ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          schema?traces
                          |> JsonExtensions.Properties
                          |> Array.map
                              (fst
                               >> String.upperFirst
                               >> ValType.compStrExplicit)
                          |> List.ofArray }
            | _, "theta" -> { PrimSpecOverrides.empty with IsCalcType = true, false }
            | _ when componentParent <> "Layout" && isPropAxis ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          layoutAnchorMappings componentParent propName
                          |> fun res -> axisInt res.Value res.Array }
            | _ when isExpanded ->
                { PrimSpecOverrides.empty with
                      Explicit =
                          let pNameUpper = propName |> String.upperFirst
                          [ pNameUpper |> ValType.compStrExplicitExpanded ] }
            | _ -> PrimSpecOverrides.empty
            |> fun overs -> ValType.getType propName overs jVal

        let propOverloads =
            if isSkip then
                []
            else
                let explicitOverloadStrings =
                    ValType.getExplicitOverloadStrings propType
                    |> fun expOverStrs ->
                        if isExpanded then
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) ->
                                let bodyCode =
                                    sprintf "Interop.mk%sAttr %s %s" componentParent
                                        (sprintf "(sprintf \"%s%s\" id)" propMethodName "%i") valueCode
                                RegularPropOverload.createCustom paramsCode bodyCode)
                        else
                            expOverStrs
                            |> List.map (fun (paramsCode, valueCode) ->
                                RegularPropOverload.create paramsCode valueCode)

                ValType.getOverloadStrings componentParent mNameUpper propType
                |> List.map (fun (paramsCode, valueCode) ->
                    if List.contains propMethodName typeAdderChildren
                       && List.contains (componentTree |> List.head) typeAdders then
                        (paramsCode,
                         sprintf "(createObj !!(properties @ [ unbox (Interop.mk%sAttr \"type\" \"%s\") ]))"
                             (propMethodName |> String.upperFirst) propMethodName) ||> RegularPropOverload.create
                    elif List.contains propMethodName jumpArray then
                        (paramsCode, "(properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)")
                        ||> RegularPropOverload.create
                    else RegularPropOverload.create paramsCode valueCode)
                |> List.append explicitOverloadStrings

        let enumOverloads =
            let isAnchorOrOverlay =
                (componentParent = "Xaxis" || componentParent = "Yaxis")
                    && (propName = "overlaying" || propName = "anchor" || propName = "scaleanchor")

            let isXAxisRef = [ "xref"; "axref" ] |> List.contains propName
            let isYAxisRef = [ "yref"; "ayref" ] |> List.contains propName

            match propType with
            | ValType.Enumerated
            | ValType.EnumeratedArray ->
                jVal?values.AsArray()
                |> Array.map JsonValue.asString
                |> List.ofArray
            | ValType.EnumeratedWithCustom ->
                jVal?values.AsArray()
                |> Array.collect (fun j ->
                    match j |> JsonValue.asString with
                    | s when String.containsRegex s && isAnchorOrOverlay -> [| "x"; "y" |]
                    | s when String.containsRegex s && isXAxisRef -> [| "x" |]
                    | s when String.containsRegex s && isYAxisRef -> [| "y" |]
                    | s when String.containsRegex s -> [||]
                    | s -> s |> Array.singleton)
                |> Array.append [| "custom" |]
                |> List.ofArray
            | ValType.FlagList ->
                let flagCombinations =
                    jVal?flags.AsArray()
                    |> List.ofArray
                    |> List.map (JsonValue.asString >> trimJson)

                let extras =
                    match jVal.TryGetProperty("extras") with
                    | Some extras ->
                        extras.AsArray()
                        |> List.ofArray
                        |> List.map (JsonValue.asString)
                    | None -> []

                extras @ flagCombinations
            | _ -> []
            |> List.sort
            |> List.collect (fun v ->
                let methodName =
                    v
                    |> emptStringToNone
                    |> trimJson
                    |> fixMethodNameOperators propMethodName
                    |> replaceAddSymbol
                    |> dashStringToDash
                    |> spaceCaseTokebabCase
                    |> kebabCaseToCamelCase
                    |> snakeCaseToCamelCase
                    |> prefixUnderscoreOrNegativeToNumbers
                    |> appendApostropheToReservedKeywords

                match propType with
                | ValType.EnumeratedWithCustom when (isAnchorOrOverlay || isXAxisRef || isYAxisRef ) && (v = "x" || v = "y") ->
                    axisInt v false
                    |> List.unzip
                    ||> List.map2 (fun paramsCode valueCode ->
                        EnumPropOverload.create methodName valueCode
                        |> EnumPropOverload.setParamsCode paramsCode)
                | ValType.EnumeratedWithCustom when v = "custom" && componentParent = "Line" && propName = "dash" ->
                    let valueCode, paramsCode =
                        [ ValType.intSeqStr; ValType.floatSeqStr ] |> List.unzip

                    paramsCode
                    |> List.map2
                        (fun pCode vCode ->
                        EnumPropOverload.create methodName vCode
                        |> EnumPropOverload.setParamsCode pCode) valueCode

                | ValType.EnumeratedWithCustom when v = "custom" ->
                    EnumPropOverload.createStr methodName
                    |> List.singleton
                | _ ->
                    match v with
                    | "true"
                    | "false" -> sprintf "%s" (trimJson v)
                    | _ -> sprintf "\"%s\"" (trimJson v)
                    |> EnumPropOverload.create methodName
                    |> List.singleton)
            |> List.distinct

        let addRegularOverloads prop = (prop, propOverloads) ||> Seq.fold (flip Prop.addRegularOverload)

        let addEnumOverloads prop = (prop, enumOverloads) ||> Seq.fold (flip Prop.addEnumOverload)

        Prop.create propType propName propMethodName
        |> Prop.setDocs (getDocs jVal)
        |> Prop.addParentComponentTree
            (if propType |> ValType.isPrimative then componentTree
             else (componentTree @ [ propName ]))
        |> addRegularOverloads
        |> addEnumOverloads

    /// Parses a `JsonValue` with given information and returns a `Component`
    let parseComponent (parentTree: string list) (componentName: string) (jVal: JsonValue) =
        let jumpComp = [ "attributes"; "items"; "traces" ]
        let jumpCompIf = [ ("Layout", "layoutAttributes") ]
        let parentTree = parentTree |> List.map trimBypass

        let rec performJumps (name: string) (j: JsonValue) =
            if List.contains name jumpComp then j.Properties |> Array.collect (fun (name, j) ->
                performJumps name j)
            else (name, j) |> Array.singleton

        let filterAttributes (props: (string * JsonValue) []) =
            let isJumpCompIf name =
                List.contains name (jumpCompIf |> List.map snd)
                && List.contains parentTree.Head (jumpCompIf |> List.map fst)

            props
            |> Array.collect
                (Array.singleton
                 >> (fun prop ->
                 match prop |> Array.head with
                 | attribs when attribs
                                |> fst
                                |> isJumpCompIf ->
                     attribs
                     |> snd
                     |> fun j -> j.Properties
                 | (name, j) when List.contains name jumpComp -> performJumps name j
                 | _ -> prop)
                 >> (fun prop ->
                     prop
                     |> Array.filter (fun p ->
                         skips
                         |> List.filter (fun skip ->
                             List.contains skip (jumpCompIf |> List.map snd) |> not)
                         |> Array.ofList
                         |> Array.contains (fst p)
                         |> not)))

        let props =
            jVal.Properties
            |> filterAttributes
            |> Array.choose (fun (pName, pJ) ->
                if pJ.TryGetProperty("description")
                   |> Option.map (fun j -> j.AsString().Contains("deprecated!"))
                   |> Option.defaultValue false || pName = "_deprecated"
                   || isManualDeprecated componentName pName
                then None
                else parseProp parentTree pName pJ |> Some)
            |> Array.distinctBy (fun p -> p.MethodName)

        let addProps comp = (comp, props) ||> Array.fold (flip Component.addProp)

        Component.create componentName
        |> Component.setDocs (getDocs jVal)
        |> Component.addParentComponentTree parentTree
        |> addProps

    /// Parses the root schema for enumerated values with the given component
    /// name and enum name returning a JsonValue of the collected values.
    let getAllEnumAttributes (property: string) (enumName: string) =
        let rec getEnumValues attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) ->
                name = enumName && j |> hasEnums && parent = property)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                others
                |> Array.collect (fun (pName, j) -> getEnumValues [||] pName j)
                |> Array.append addedAttribList

        getEnumValues [||] property schema
        |> (Array.collect (snd >> JsonExtensions.Properties)
            >> Array.collect (fun (name, jVal) ->
                if name = "values" then jVal.AsArray()
                else [||]))
        |> Array.distinct
        |> JsonValue.Array

    /// Parses given JsonValue for components with the given name returning
    /// a JsonValue of a collected set of properties.
    let getAttributesOf (source: JsonValue) (property: string) =
        let rec getAttributes attribList parent (jVal: JsonValue) =
            jVal.Properties
            |> Array.partition (fun (name, j) ->
                name = property && j.TryGetProperty("valType").IsNone)
            ||> fun matches others ->
                let addedAttribList =
                    matches
                    |> Array.collect (fun (_, attrib) -> [| parent, attrib |])
                    |> Array.append attribList
                Array.append addedAttribList (Array.collect (fun (pName, j) ->
                    getAttributes [||] pName j) others)

        getAttributes [||] property source
        |> Array.collect (snd >> JsonExtensions.Properties)
        |> Array.distinct
        |> Array.map (fun (name, jVal) ->
            if jVal |> hasEnums then
                let fullEnums = getAllEnumAttributes property name
                jVal.Properties
                |> Array.map (fun (n, j) ->
                    if n = "values" then (n, fullEnums)
                    else (n, j))
                |> JsonValue.Record
                |> fun newJ -> (name, newJ)
            else
                (name, jVal))
        |> JsonValue.Record

    /// Parses the root schema for components with the given name returning
    /// a JsonValue of a collected set of properties.
    let getAllAttributes (property: string) = getAttributesOf schema property

    type ComponentCollector =
        { Parent: string
          Children: string list
          AttributeName: string }

    [<RequireQualifiedAccess>]
    module ComponentCollector =
        let fromParent name compCollector =
            compCollector.Parent = name

        let fromParentSeq name compCollectors =
            List.tryFind (fromParent name) compCollectors

        let fromChild name compCollector =
            List.contains name compCollector.Children

        let fromChildSeq name compCollectors =
            List.tryFind (fromChild name) compCollectors

        let fromParentAndChild name compCollectors =
            fromParentSeq name compCollectors,
            fromChildSeq name compCollectors

    let collectAttributesUnderComponent (name: string) (compCollectors: ComponentCollector list) (jsonValue: JsonValue) =
        match ComponentCollector.fromParentAndChild name compCollectors with
        | Some cc, _ ->
            jsonValue.Properties
            |> Array.append (getAllAttributes cc.AttributeName |> JsonExtensions.Properties)
            |> JsonValue.Record
        | _, Some cc ->
            traceChildrenWithJson
            |> Array.choose (fun (traceName, traceJson) ->
                if traceName.Contains(name) then
                    getAttributesOf traceJson cc.AttributeName
                    |> JsonExtensions.Properties
                    |> Some
                else None)
            |> Array.concat
            |> Array.distinct
            |> Array.append jsonValue.Properties
            |> JsonValue.Record
        | _ -> jsonValue

    /// Gets a list of all components within the schema with their collected properties
    let getAllComponents() =
        let fixComponentName =
            trimJson
            >> spaceCaseTokebabCase
            >> kebabCaseToCamelCase
            >> snakeCaseToCamelCase
            >> replaceAddSymbol
            >> appendApostropheToReservedKeywords

        let jumps = [ "attributes"; "items"; "layoutAttributes" ]

        let componentCollectors = [
            { Parent = "layout"
              Children = [ "ternary"; "geo"; "mapbox"; "polar" ]
              AttributeName = "layoutAttributes" }
        ]

        let rec allComponentNames (jVal: JsonValue) : string list =
            let props =
                match jumps |> List.choose (jVal.TryGetProperty) with
                | j when j.Length > 0 -> (j |> List.head).Properties
                | _ -> jVal.Properties
                |> List.ofArray
                |> List.filter (fun (name, j) ->
                    List.contains name skips |> not
                        && j.TryGetProperty("valType").IsNone)

            let newNames =
                props
                |> List.map fst
                |> List.distinct

            props
            |> List.collect (fun (name, j) ->
                if j.TryGetProperty("valType").IsNone then allComponentNames j
                else [ name ])
            |> List.append newNames
            |> List.distinct

        let result =
            let schemaSkips = [ "defs" ]
            let compSkips = [ "type"; "transform" ]

            schema.Properties
            |> Array.filter (fun (name, _) -> List.contains name schemaSkips |> not)
            |> JsonValue.Record
            |> allComponentNames
            |> List.filter (fun name -> List.contains name compSkips |> not)
            |> List.distinct

        result
        |> List.map
            (((fun n ->
             n |> fixComponentName,
             getAllAttributes n
             |> collectAttributesUnderComponent n componentCollectors))
             >> (fun (n, j) ->
                match List.filter (fun (name, _) -> name = n) manualDeprecated |> List.collect snd with
                | res when res.Length > 0 ->
                    n,
                    j.Properties |> Array.filter (fun (pName, _) -> List.contains pName res |> not)
                    |> JsonValue.Record
                | _ -> (n,j))
             >> (fun (n, j) -> parseComponent [ n |> String.upperFirst ] n j))

    let addSugaredOverloads (comps: Component list) =
        let sugars =
            [ "color",
              [ "rgb", "(r,g,b)", sprintf "Interop.mk%sAttr \"color\" (Feliz.color.rgb(r,g,b))", ""
                "rgba", "(r,g,b,a)", sprintf "Interop.mk%sAttr \"color\" (Feliz.color.rgba(r,g,b,a))", ""
                "hsl", "(h,s,l)", sprintf "Interop.mk%sAttr \"color\" (Feliz.color.hsl(h,s,l))", "" ]
              "target",
              [ "i", "", sprintf "Interop.mk%sAttr \"target\" \"i\"", ""
                "j", "", sprintf "Interop.mk%sAttr \"target\" \"j\"", ""
                "k", "", sprintf "Interop.mk%sAttr \"target\" \"k\"", ""
                "u", "", sprintf "Interop.mk%sAttr \"target\" \"u\"", ""
                "v", "", sprintf "Interop.mk%sAttr \"target\" \"v\"", ""
                "w", "", sprintf "Interop.mk%sAttr \"target\" \"w\"", ""
                "x", "", sprintf "Interop.mk%sAttr \"target\" \"x\"", ""
                "y", "", sprintf "Interop.mk%sAttr \"target\" \"y\"", ""
                "z", "", sprintf "Interop.mk%sAttr \"target\" \"z\"", "" ]
              "locale",
              [ "afNA", "", sprintf "Interop.mk%sAttr \"locale\" \"af-NA\"", "Afrikaans (Namibia)"
                "afZA", "", sprintf "Interop.mk%sAttr \"locale\" \"af-ZA\"", "Afrikaans (South Africa)"
                "af", "", sprintf "Interop.mk%sAttr \"locale\" \"af\"", "Afrikaans"
                "akGH", "", sprintf "Interop.mk%sAttr \"locale\" \"ak-GH\"", "Akan (Ghana)"
                "ak", "", sprintf "Interop.mk%sAttr \"locale\" \"ak\"", "Akan"
                "sqAL", "", sprintf "Interop.mk%sAttr \"locale\" \"sq-AL\"", "Albanian (Albania)"
                "sq", "", sprintf "Interop.mk%sAttr \"locale\" \"sq\"", "Albanian"
                "amET", "", sprintf "Interop.mk%sAttr \"locale\" \"am-ET\"", "Amharic (Ethiopia)"
                "am", "", sprintf "Interop.mk%sAttr \"locale\" \"am\"", "Amharic"
                "arDZ", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-DZ\"", "Arabic (Algeria)"
                "arBH", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-BH\"", "Arabic (Bahrain)"
                "arEG", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-EG\"", "Arabic (Egypt)"
                "arIQ", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-IQ\"", "Arabic (Iraq)"
                "arJO", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-JO\"", "Arabic (Jordan)"
                "arKW", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-KW\"", "Arabic (Kuwait)"
                "arLB", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-LB\"", "Arabic (Lebanon)"
                "arLY", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-LY\"", "Arabic (Libya)"
                "arMA", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-MA\"", "Arabic (Morocco)"
                "arOM", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-OM\"", "Arabic (Oman)"
                "arQA", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-QA\"", "Arabic (Qatar)"
                "arSA", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-SA\"", "Arabic (Saudi Arabia)"
                "arSD", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-SD\"", "Arabic (Sudan)"
                "arSY", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-SY\"", "Arabic (Syria)"
                "arTN", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-TN\"", "Arabic (Tunisia)"
                "arAE", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-AE\"", "Arabic (United Arab Emirates)"
                "arYE", "", sprintf "Interop.mk%sAttr \"locale\" \"ar-YE\"", "Arabic (Yemen)"
                "ar", "", sprintf "Interop.mk%sAttr \"locale\" \"ar\"", "Arabic"
                "hyAM", "", sprintf "Interop.mk%sAttr \"locale\" \"hy-AM\"", "Armenian (Armenia)"
                "hy", "", sprintf "Interop.mk%sAttr \"locale\" \"hy\"", "Armenian"
                "asIN", "", sprintf "Interop.mk%sAttr \"locale\" \"as-IN\"", "Assamese (India)"
                "as'", "", sprintf "Interop.mk%sAttr \"locale\" \"as\"", "Assamese"
                "asaTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"asa-TZ\"", "Asu (Tanzania)"
                "asa", "", sprintf "Interop.mk%sAttr \"locale\" \"asa\"", "Asu"
                "azCyrl", "", sprintf "Interop.mk%sAttr \"locale\" \"az-Cyrl\"", "Azerbaijani (Cyrillic)"
                "azCyrlAZ", "", sprintf "Interop.mk%sAttr \"locale\" \"az-Cyrl-AZ\"", "Azerbaijani (Cyrillic, Azerbaijan)"
                "azLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"az-Latn\"", "Azerbaijani (Latin)"
                "azLatnAZ", "", sprintf "Interop.mk%sAttr \"locale\" \"az-Latn-AZ\"", "Azerbaijani (Latin, Azerbaijan)"
                "az", "", sprintf "Interop.mk%sAttr \"locale\" \"az\"", "Azerbaijani"
                "bmML", "", sprintf "Interop.mk%sAttr \"locale\" \"bm-ML\"", "Bambara (Mali)"
                "bm", "", sprintf "Interop.mk%sAttr \"locale\" \"bm\"", "Bambara"
                "euES", "", sprintf "Interop.mk%sAttr \"locale\" \"eu-ES\"", "Basque (Spain)"
                "eu", "", sprintf "Interop.mk%sAttr \"locale\" \"eu\"", "Basque"
                "beBY", "", sprintf "Interop.mk%sAttr \"locale\" \"be-BY\"", "Belarusian (Belarus)"
                "be", "", sprintf "Interop.mk%sAttr \"locale\" \"be\"", "Belarusian"
                "bemZM", "", sprintf "Interop.mk%sAttr \"locale\" \"bem-ZM\"", "Bemba (Zambia)"
                "bem", "", sprintf "Interop.mk%sAttr \"locale\" \"bem\"", "Bemba"
                "bezTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"bez-TZ\"", "Bena (Tanzania)"
                "bez", "", sprintf "Interop.mk%sAttr \"locale\" \"bez\"", "Bena"
                "bnBD", "", sprintf "Interop.mk%sAttr \"locale\" \"bn-BD\"", "Bengali (Bangladesh)"
                "bnIN", "", sprintf "Interop.mk%sAttr \"locale\" \"bn-IN\"", "Bengali (India)"
                "bn", "", sprintf "Interop.mk%sAttr \"locale\" \"bn\"", "Bengali"
                "bsBA", "", sprintf "Interop.mk%sAttr \"locale\" \"bs-BA\"", "Bosnian (Bosnia and Herzegovina)"
                "bs", "", sprintf "Interop.mk%sAttr \"locale\" \"bs\"", "Bosnian"
                "bgBG", "", sprintf "Interop.mk%sAttr \"locale\" \"bg-BG\"", "Bulgarian (Bulgaria)"
                "bg", "", sprintf "Interop.mk%sAttr \"locale\" \"bg\"", "Bulgarian"
                "myMM", "", sprintf "Interop.mk%sAttr \"locale\" \"my-MM\"", "Burmese (Myanmar [Burma])"
                "my", "", sprintf "Interop.mk%sAttr \"locale\" \"my\"", "Burmese"
                "yueHantHK", "", sprintf "Interop.mk%sAttr \"locale\" \"yue-Hant-HK\"", "Cantonese (Traditional, Hong Kong SAR China)"
                "caES", "", sprintf "Interop.mk%sAttr \"locale\" \"ca-ES\"", "Catalan (Spain)"
                "ca", "", sprintf "Interop.mk%sAttr \"locale\" \"ca\"", "Catalan"
                "tzmLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"tzm-Latn\"", "Central Morocco Tamazight (Latin)"
                "tzmLatnMA", "", sprintf "Interop.mk%sAttr \"locale\" \"tzm-Latn-MA\"", "Central Morocco Tamazight (Latin, Morocco)"
                "tzm", "", sprintf "Interop.mk%sAttr \"locale\" \"tzm\"", "Central Morocco Tamazight"
                "chrUS", "", sprintf "Interop.mk%sAttr \"locale\" \"chr-US\"", "Cherokee (United States)"
                "chr", "", sprintf "Interop.mk%sAttr \"locale\" \"chr\"", "Cherokee"
                "cggUG", "", sprintf "Interop.mk%sAttr \"locale\" \"cgg-UG\"", "Chiga (Uganda)"
                "cgg", "", sprintf "Interop.mk%sAttr \"locale\" \"cgg\"", "Chiga"
                "zhHans", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hans\"", "Chinese (Simplified Han)"
                "zhHansCN", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hans-CN\"", "Chinese (Simplified Han, China)"
                "zhHansHK", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hans-HK\"", "Chinese (Simplified Han, Hong Kong SAR China)"
                "zhHansMO", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hans-MO\"", "Chinese (Simplified Han, Macau SAR China)"
                "zhHansSG", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hans-SG\"", "Chinese (Simplified Han, Singapore)"
                "zhHant", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hant\"", "Chinese (Traditional Han)"
                "zhHantHK", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hant-HK\"", "Chinese (Traditional Han, Hong Kong SAR China)"
                "zhHantMO", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hant-MO\"", "Chinese (Traditional Han, Macau SAR China)"
                "zhHantTW", "", sprintf "Interop.mk%sAttr \"locale\" \"zh-Hant-TW\"", "Chinese (Traditional Han, Taiwan)"
                "zh", "", sprintf "Interop.mk%sAttr \"locale\" \"zh\"", "Chinese"
                "kwGB", "", sprintf "Interop.mk%sAttr \"locale\" \"kw-GB\"", "Cornish (United Kingdom)"
                "kw", "", sprintf "Interop.mk%sAttr \"locale\" \"kw\"", "Cornish"
                "hrHR", "", sprintf "Interop.mk%sAttr \"locale\" \"hr-HR\"", "Croatian (Croatia)"
                "hr", "", sprintf "Interop.mk%sAttr \"locale\" \"hr\"", "Croatian"
                "csCZ", "", sprintf "Interop.mk%sAttr \"locale\" \"cs-CZ\"", "Czech (Czech Republic)"
                "cs", "", sprintf "Interop.mk%sAttr \"locale\" \"cs\"", "Czech"
                "daDK", "", sprintf "Interop.mk%sAttr \"locale\" \"da-DK\"", "Danish (Denmark)"
                "da", "", sprintf "Interop.mk%sAttr \"locale\" \"da\"", "Danish"
                "nlBE", "", sprintf "Interop.mk%sAttr \"locale\" \"nl-BE\"", "Dutch (Belgium)"
                "nlNL", "", sprintf "Interop.mk%sAttr \"locale\" \"nl-NL\"", "Dutch (Netherlands)"
                "nl", "", sprintf "Interop.mk%sAttr \"locale\" \"nl\"", "Dutch"
                "ebuKE", "", sprintf "Interop.mk%sAttr \"locale\" \"ebu-KE\"", "Embu (Kenya)"
                "ebu", "", sprintf "Interop.mk%sAttr \"locale\" \"ebu\"", "Embu"
                "enAS", "", sprintf "Interop.mk%sAttr \"locale\" \"en-AS\"", "English (American Samoa)"
                "enAU", "", sprintf "Interop.mk%sAttr \"locale\" \"en-AU\"", "English (Australia)"
                "enBE", "", sprintf "Interop.mk%sAttr \"locale\" \"en-BE\"", "English (Belgium)"
                "enBZ", "", sprintf "Interop.mk%sAttr \"locale\" \"en-BZ\"", "English (Belize)"
                "enBW", "", sprintf "Interop.mk%sAttr \"locale\" \"en-BW\"", "English (Botswana)"
                "enCA", "", sprintf "Interop.mk%sAttr \"locale\" \"en-CA\"", "English (Canada)"
                "enGU", "", sprintf "Interop.mk%sAttr \"locale\" \"en-GU\"", "English (Guam)"
                "enHK", "", sprintf "Interop.mk%sAttr \"locale\" \"en-HK\"", "English (Hong Kong SAR China)"
                "enIN", "", sprintf "Interop.mk%sAttr \"locale\" \"en-IN\"", "English (India)"
                "enIE", "", sprintf "Interop.mk%sAttr \"locale\" \"en-IE\"", "English (Ireland)"
                "enIL", "", sprintf "Interop.mk%sAttr \"locale\" \"en-IL\"", "English (Israel)"
                "enJM", "", sprintf "Interop.mk%sAttr \"locale\" \"en-JM\"", "English (Jamaica)"
                "enMT", "", sprintf "Interop.mk%sAttr \"locale\" \"en-MT\"", "English (Malta)"
                "enMH", "", sprintf "Interop.mk%sAttr \"locale\" \"en-MH\"", "English (Marshall Islands)"
                "enMU", "", sprintf "Interop.mk%sAttr \"locale\" \"en-MU\"", "English (Mauritius)"
                "enNA", "", sprintf "Interop.mk%sAttr \"locale\" \"en-NA\"", "English (Namibia)"
                "enNZ", "", sprintf "Interop.mk%sAttr \"locale\" \"en-NZ\"", "English (New Zealand)"
                "enMP", "", sprintf "Interop.mk%sAttr \"locale\" \"en-MP\"", "English (Northern Mariana Islands)"
                "enPK", "", sprintf "Interop.mk%sAttr \"locale\" \"en-PK\"", "English (Pakistan)"
                "enPH", "", sprintf "Interop.mk%sAttr \"locale\" \"en-PH\"", "English (Philippines)"
                "enSG", "", sprintf "Interop.mk%sAttr \"locale\" \"en-SG\"", "English (Singapore)"
                "enZA", "", sprintf "Interop.mk%sAttr \"locale\" \"en-ZA\"", "English (South Africa)"
                "enTT", "", sprintf "Interop.mk%sAttr \"locale\" \"en-TT\"", "English (Trinidad and Tobago)"
                "enUM", "", sprintf "Interop.mk%sAttr \"locale\" \"en-UM\"", "English (U.S. Minor Outlying Islands)"
                "enVI", "", sprintf "Interop.mk%sAttr \"locale\" \"en-VI\"", "English (U.S. Virgin Islands)"
                "enGB", "", sprintf "Interop.mk%sAttr \"locale\" \"en-GB\"", "English (United Kingdom)"
                "enUS", "", sprintf "Interop.mk%sAttr \"locale\" \"en-US\"", "English (United States)"
                "enZW", "", sprintf "Interop.mk%sAttr \"locale\" \"en-ZW\"", "English (Zimbabwe)"
                "en", "", sprintf "Interop.mk%sAttr \"locale\" \"en\"", "English"
                "eo", "", sprintf "Interop.mk%sAttr \"locale\" \"eo\"", "Esperanto"
                "etEE", "", sprintf "Interop.mk%sAttr \"locale\" \"et-EE\"", "Estonian (Estonia)"
                "et", "", sprintf "Interop.mk%sAttr \"locale\" \"et\"", "Estonian"
                "eeGH", "", sprintf "Interop.mk%sAttr \"locale\" \"ee-GH\"", "Ewe (Ghana)"
                "eeTG", "", sprintf "Interop.mk%sAttr \"locale\" \"ee-TG\"", "Ewe (Togo)"
                "ee", "", sprintf "Interop.mk%sAttr \"locale\" \"ee\"", "Ewe"
                "foFO", "", sprintf "Interop.mk%sAttr \"locale\" \"fo-FO\"", "Faroese (Faroe Islands)"
                "fo", "", sprintf "Interop.mk%sAttr \"locale\" \"fo\"", "Faroese"
                "filPH", "", sprintf "Interop.mk%sAttr \"locale\" \"fil-PH\"", "Filipino (Philippines)"
                "fil", "", sprintf "Interop.mk%sAttr \"locale\" \"fil\"", "Filipino"
                "fiFI", "", sprintf "Interop.mk%sAttr \"locale\" \"fi-FI\"", "Finnish (Finland)"
                "fi", "", sprintf "Interop.mk%sAttr \"locale\" \"fi\"", "Finnish"
                "frBE", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-BE\"", "French (Belgium)"
                "frBJ", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-BJ\"", "French (Benin)"
                "frBF", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-BF\"", "French (Burkina Faso)"
                "frBI", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-BI\"", "French (Burundi)"
                "frCM", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CM\"", "French (Cameroon)"
                "frCA", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CA\"", "French (Canada)"
                "frCF", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CF\"", "French (Central African Republic)"
                "frTD", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-TD\"", "French (Chad)"
                "frKM", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-KM\"", "French (Comoros)"
                "frCG", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CG\"", "French (Congo - Brazzaville)"
                "frCD", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CD\"", "French (Congo - Kinshasa)"
                "frCI", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CI\"", "French (C�te d�Ivoire)"
                "frDJ", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-DJ\"", "French (Djibouti)"
                "frGQ", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-GQ\"", "French (Equatorial Guinea)"
                "frFR", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-FR\"", "French (France)"
                "frGA", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-GA\"", "French (Gabon)"
                "frGP", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-GP\"", "French (Guadeloupe)"
                "frGN", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-GN\"", "French (Guinea)"
                "frLU", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-LU\"", "French (Luxembourg)"
                "frMG", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-MG\"", "French (Madagascar)"
                "frML", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-ML\"", "French (Mali)"
                "frMQ", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-MQ\"", "French (Martinique)"
                "frMC", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-MC\"", "French (Monaco)"
                "frNE", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-NE\"", "French (Niger)"
                "frRW", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-RW\"", "French (Rwanda)"
                "frRE", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-RE\"", "French (R�union)"
                "frBL", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-BL\"", "French (Saint Barth�lemy)"
                "frMF", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-MF\"", "French (Saint Martin)"
                "frSN", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-SN\"", "French (Senegal)"
                "frCH", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-CH\"", "French (Switzerland)"
                "frTG", "", sprintf "Interop.mk%sAttr \"locale\" \"fr-TG\"", "French (Togo)"
                "fr", "", sprintf "Interop.mk%sAttr \"locale\" \"fr\"", "French"
                "ffSN", "", sprintf "Interop.mk%sAttr \"locale\" \"ff-SN\"", "Fulah (Senegal)"
                "ff", "", sprintf "Interop.mk%sAttr \"locale\" \"ff\"", "Fulah"
                "glES", "", sprintf "Interop.mk%sAttr \"locale\" \"gl-ES\"", "Galician (Spain)"
                "gl", "", sprintf "Interop.mk%sAttr \"locale\" \"gl\"", "Galician"
                "lgUG", "", sprintf "Interop.mk%sAttr \"locale\" \"lg-UG\"", "Ganda (Uganda)"
                "lg", "", sprintf "Interop.mk%sAttr \"locale\" \"lg\"", "Ganda"
                "kaGE", "", sprintf "Interop.mk%sAttr \"locale\" \"ka-GE\"", "Georgian (Georgia)"
                "ka", "", sprintf "Interop.mk%sAttr \"locale\" \"ka\"", "Georgian"
                "deAT", "", sprintf "Interop.mk%sAttr \"locale\" \"de-AT\"", "German (Austria)"
                "deBE", "", sprintf "Interop.mk%sAttr \"locale\" \"de-BE\"", "German (Belgium)"
                "deDE", "", sprintf "Interop.mk%sAttr \"locale\" \"de-DE\"", "German (Germany)"
                "deLI", "", sprintf "Interop.mk%sAttr \"locale\" \"de-LI\"", "German (Liechtenstein)"
                "deLU", "", sprintf "Interop.mk%sAttr \"locale\" \"de-LU\"", "German (Luxembourg)"
                "deCH", "", sprintf "Interop.mk%sAttr \"locale\" \"de-CH\"", "German (Switzerland)"
                "de", "", sprintf "Interop.mk%sAttr \"locale\" \"de\"", "German"
                "elCY", "", sprintf "Interop.mk%sAttr \"locale\" \"el-CY\"", "Greek (Cyprus)"
                "elGR", "", sprintf "Interop.mk%sAttr \"locale\" \"el-GR\"", "Greek (Greece)"
                "el", "", sprintf "Interop.mk%sAttr \"locale\" \"el\"", "Greek"
                "guIN", "", sprintf "Interop.mk%sAttr \"locale\" \"gu-IN\"", "Gujarati (India)"
                "gu", "", sprintf "Interop.mk%sAttr \"locale\" \"gu\"", "Gujarati"
                "guzKE", "", sprintf "Interop.mk%sAttr \"locale\" \"guz-KE\"", "Gusii (Kenya)"
                "guz", "", sprintf "Interop.mk%sAttr \"locale\" \"guz\"", "Gusii"
                "haLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"ha-Latn\"", "Hausa (Latin)"
                "haLatnGH", "", sprintf "Interop.mk%sAttr \"locale\" \"ha-Latn-GH\"", "Hausa (Latin, Ghana)"
                "haLatnNE", "", sprintf "Interop.mk%sAttr \"locale\" \"ha-Latn-NE\"", "Hausa (Latin, Niger)"
                "haLatnNG", "", sprintf "Interop.mk%sAttr \"locale\" \"ha-Latn-NG\"", "Hausa (Latin, Nigeria)"
                "ha", "", sprintf "Interop.mk%sAttr \"locale\" \"ha\"", "Hausa"
                "hawUS", "", sprintf "Interop.mk%sAttr \"locale\" \"haw-US\"", "Hawaiian (United States)"
                "haw", "", sprintf "Interop.mk%sAttr \"locale\" \"haw\"", "Hawaiian"
                "heIL", "", sprintf "Interop.mk%sAttr \"locale\" \"he-IL\"", "Hebrew (Israel)"
                "he", "", sprintf "Interop.mk%sAttr \"locale\" \"he\"", "Hebrew"
                "hiIN", "", sprintf "Interop.mk%sAttr \"locale\" \"hi-IN\"", "Hindi (India)"
                "hi", "", sprintf "Interop.mk%sAttr \"locale\" \"hi\"", "Hindi"
                "huHU", "", sprintf "Interop.mk%sAttr \"locale\" \"hu-HU\"", "Hungarian (Hungary)"
                "hu", "", sprintf "Interop.mk%sAttr \"locale\" \"hu\"", "Hungarian"
                "isIS", "", sprintf "Interop.mk%sAttr \"locale\" \"is-IS\"", "Icelandic (Iceland)"
                "is", "", sprintf "Interop.mk%sAttr \"locale\" \"is\"", "Icelandic"
                "igNG", "", sprintf "Interop.mk%sAttr \"locale\" \"ig-NG\"", "Igbo (Nigeria)"
                "ig", "", sprintf "Interop.mk%sAttr \"locale\" \"ig\"", "Igbo"
                "idID", "", sprintf "Interop.mk%sAttr \"locale\" \"id-ID\"", "Indonesian (Indonesia)"
                "id", "", sprintf "Interop.mk%sAttr \"locale\" \"id\"", "Indonesian"
                "gaIE", "", sprintf "Interop.mk%sAttr \"locale\" \"ga-IE\"", "Irish (Ireland)"
                "ga", "", sprintf "Interop.mk%sAttr \"locale\" \"ga\"", "Irish"
                "itIT", "", sprintf "Interop.mk%sAttr \"locale\" \"it-IT\"", "Italian (Italy)"
                "itCH", "", sprintf "Interop.mk%sAttr \"locale\" \"it-CH\"", "Italian (Switzerland)"
                "it", "", sprintf "Interop.mk%sAttr \"locale\" \"it\"", "Italian"
                "jaJP", "", sprintf "Interop.mk%sAttr \"locale\" \"ja-JP\"", "Japanese (Japan)"
                "ja", "", sprintf "Interop.mk%sAttr \"locale\" \"ja\"", "Japanese"
                "keaCV", "", sprintf "Interop.mk%sAttr \"locale\" \"kea-CV\"", "Kabuverdianu (Cape Verde)"
                "kea", "", sprintf "Interop.mk%sAttr \"locale\" \"kea\"", "Kabuverdianu"
                "kabDZ", "", sprintf "Interop.mk%sAttr \"locale\" \"kab-DZ\"", "Kabyle (Algeria)"
                "kab", "", sprintf "Interop.mk%sAttr \"locale\" \"kab\"", "Kabyle"
                "klGL", "", sprintf "Interop.mk%sAttr \"locale\" \"kl-GL\"", "Kalaallisut (Greenland)"
                "kl", "", sprintf "Interop.mk%sAttr \"locale\" \"kl\"", "Kalaallisut"
                "klnKE", "", sprintf "Interop.mk%sAttr \"locale\" \"kln-KE\"", "Kalenjin (Kenya)"
                "kln", "", sprintf "Interop.mk%sAttr \"locale\" \"kln\"", "Kalenjin"
                "kamKE", "", sprintf "Interop.mk%sAttr \"locale\" \"kam-KE\"", "Kamba (Kenya)"
                "kam", "", sprintf "Interop.mk%sAttr \"locale\" \"kam\"", "Kamba"
                "knIN", "", sprintf "Interop.mk%sAttr \"locale\" \"kn-IN\"", "Kannada (India)"
                "kn", "", sprintf "Interop.mk%sAttr \"locale\" \"kn\"", "Kannada"
                "kkCyrl", "", sprintf "Interop.mk%sAttr \"locale\" \"kk-Cyrl\"", "Kazakh (Cyrillic)"
                "kkCyrlKZ", "", sprintf "Interop.mk%sAttr \"locale\" \"kk-Cyrl-KZ\"", "Kazakh (Cyrillic, Kazakhstan)"
                "kk", "", sprintf "Interop.mk%sAttr \"locale\" \"kk\"", "Kazakh"
                "kmKH", "", sprintf "Interop.mk%sAttr \"locale\" \"km-KH\"", "Khmer (Cambodia)"
                "km", "", sprintf "Interop.mk%sAttr \"locale\" \"km\"", "Khmer"
                "kiKE", "", sprintf "Interop.mk%sAttr \"locale\" \"ki-KE\"", "Kikuyu (Kenya)"
                "ki", "", sprintf "Interop.mk%sAttr \"locale\" \"ki\"", "Kikuyu"
                "rwRW", "", sprintf "Interop.mk%sAttr \"locale\" \"rw-RW\"", "Kinyarwanda (Rwanda)"
                "rw", "", sprintf "Interop.mk%sAttr \"locale\" \"rw\"", "Kinyarwanda"
                "kokIN", "", sprintf "Interop.mk%sAttr \"locale\" \"kok-IN\"", "Konkani (India)"
                "kok", "", sprintf "Interop.mk%sAttr \"locale\" \"kok\"", "Konkani"
                "koKR", "", sprintf "Interop.mk%sAttr \"locale\" \"ko-KR\"", "Korean (South Korea)"
                "ko", "", sprintf "Interop.mk%sAttr \"locale\" \"ko\"", "Korean"
                "khqML", "", sprintf "Interop.mk%sAttr \"locale\" \"khq-ML\"", "Koyra Chiini (Mali)"
                "khq", "", sprintf "Interop.mk%sAttr \"locale\" \"khq\"", "Koyra Chiini"
                "sesML", "", sprintf "Interop.mk%sAttr \"locale\" \"ses-ML\"", "Koyraboro Senni (Mali)"
                "ses", "", sprintf "Interop.mk%sAttr \"locale\" \"ses\"", "Koyraboro Senni"
                "lagTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"lag-TZ\"", "Langi (Tanzania)"
                "lag", "", sprintf "Interop.mk%sAttr \"locale\" \"lag\"", "Langi"
                "lvLV", "", sprintf "Interop.mk%sAttr \"locale\" \"lv-LV\"", "Latvian (Latvia)"
                "lv", "", sprintf "Interop.mk%sAttr \"locale\" \"lv\"", "Latvian"
                "ltLT", "", sprintf "Interop.mk%sAttr \"locale\" \"lt-LT\"", "Lithuanian (Lithuania)"
                "lt", "", sprintf "Interop.mk%sAttr \"locale\" \"lt\"", "Lithuanian"
                "luoKE", "", sprintf "Interop.mk%sAttr \"locale\" \"luo-KE\"", "Luo (Kenya)"
                "luo", "", sprintf "Interop.mk%sAttr \"locale\" \"luo\"", "Luo"
                "luyKE", "", sprintf "Interop.mk%sAttr \"locale\" \"luy-KE\"", "Luyia (Kenya)"
                "luy", "", sprintf "Interop.mk%sAttr \"locale\" \"luy\"", "Luyia"
                "mkMK", "", sprintf "Interop.mk%sAttr \"locale\" \"mk-MK\"", "Macedonian (Macedonia)"
                "mk", "", sprintf "Interop.mk%sAttr \"locale\" \"mk\"", "Macedonian"
                "jmcTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"jmc-TZ\"", "Machame (Tanzania)"
                "jmc", "", sprintf "Interop.mk%sAttr \"locale\" \"jmc\"", "Machame"
                "kdeTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"kde-TZ\"", "Makonde (Tanzania)"
                "kde", "", sprintf "Interop.mk%sAttr \"locale\" \"kde\"", "Makonde"
                "mgMG", "", sprintf "Interop.mk%sAttr \"locale\" \"mg-MG\"", "Malagasy (Madagascar)"
                "mg", "", sprintf "Interop.mk%sAttr \"locale\" \"mg\"", "Malagasy"
                "msBN", "", sprintf "Interop.mk%sAttr \"locale\" \"ms-BN\"", "Malay (Brunei)"
                "msMY", "", sprintf "Interop.mk%sAttr \"locale\" \"ms-MY\"", "Malay (Malaysia)"
                "ms", "", sprintf "Interop.mk%sAttr \"locale\" \"ms\"", "Malay"
                "mlIN", "", sprintf "Interop.mk%sAttr \"locale\" \"ml-IN\"", "Malayalam (India)"
                "ml", "", sprintf "Interop.mk%sAttr \"locale\" \"ml\"", "Malayalam"
                "mtMT", "", sprintf "Interop.mk%sAttr \"locale\" \"mt-MT\"", "Maltese (Malta)"
                "mt", "", sprintf "Interop.mk%sAttr \"locale\" \"mt\"", "Maltese"
                "gvGB", "", sprintf "Interop.mk%sAttr \"locale\" \"gv-GB\"", "Manx (United Kingdom)"
                "gv", "", sprintf "Interop.mk%sAttr \"locale\" \"gv\"", "Manx"
                "mrIN", "", sprintf "Interop.mk%sAttr \"locale\" \"mr-IN\"", "Marathi (India)"
                "mr", "", sprintf "Interop.mk%sAttr \"locale\" \"mr\"", "Marathi"
                "masKE", "", sprintf "Interop.mk%sAttr \"locale\" \"mas-KE\"", "Masai (Kenya)"
                "masTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"mas-TZ\"", "Masai (Tanzania)"
                "mas", "", sprintf "Interop.mk%sAttr \"locale\" \"mas\"", "Masai"
                "merKE", "", sprintf "Interop.mk%sAttr \"locale\" \"mer-KE\"", "Meru (Kenya)"
                "mer", "", sprintf "Interop.mk%sAttr \"locale\" \"mer\"", "Meru"
                "mfeMU", "", sprintf "Interop.mk%sAttr \"locale\" \"mfe-MU\"", "Morisyen (Mauritius)"
                "mfe", "", sprintf "Interop.mk%sAttr \"locale\" \"mfe\"", "Morisyen"
                "naqNA", "", sprintf "Interop.mk%sAttr \"locale\" \"naq-NA\"", "Nama (Namibia)"
                "naq", "", sprintf "Interop.mk%sAttr \"locale\" \"naq\"", "Nama"
                "neIN", "", sprintf "Interop.mk%sAttr \"locale\" \"ne-IN\"", "Nepali (India)"
                "neNP", "", sprintf "Interop.mk%sAttr \"locale\" \"ne-NP\"", "Nepali (Nepal)"
                "ne", "", sprintf "Interop.mk%sAttr \"locale\" \"ne\"", "Nepali"
                "ndZW", "", sprintf "Interop.mk%sAttr \"locale\" \"nd-ZW\"", "North Ndebele (Zimbabwe)"
                "nd", "", sprintf "Interop.mk%sAttr \"locale\" \"nd\"", "North Ndebele"
                "nbNO", "", sprintf "Interop.mk%sAttr \"locale\" \"nb-NO\"", "Norwegian Bokm�l (Norway)"
                "nb", "", sprintf "Interop.mk%sAttr \"locale\" \"nb\"", "Norwegian Bokm�l"
                "nnNO", "", sprintf "Interop.mk%sAttr \"locale\" \"nn-NO\"", "Norwegian Nynorsk (Norway)"
                "nn", "", sprintf "Interop.mk%sAttr \"locale\" \"nn\"", "Norwegian Nynorsk"
                "nynUG", "", sprintf "Interop.mk%sAttr \"locale\" \"nyn-UG\"", "Nyankole (Uganda)"
                "nyn", "", sprintf "Interop.mk%sAttr \"locale\" \"nyn\"", "Nyankole"
                "orIN", "", sprintf "Interop.mk%sAttr \"locale\" \"or-IN\"", "Oriya (India)"
                "or'", "", sprintf "Interop.mk%sAttr \"locale\" \"or\"", "Oriya"
                "omET", "", sprintf "Interop.mk%sAttr \"locale\" \"om-ET\"", "Oromo (Ethiopia)"
                "omKE", "", sprintf "Interop.mk%sAttr \"locale\" \"om-KE\"", "Oromo (Kenya)"
                "om", "", sprintf "Interop.mk%sAttr \"locale\" \"om\"", "Oromo"
                "psAF", "", sprintf "Interop.mk%sAttr \"locale\" \"ps-AF\"", "Pashto (Afghanistan)"
                "ps", "", sprintf "Interop.mk%sAttr \"locale\" \"ps\"", "Pashto"
                "faAF", "", sprintf "Interop.mk%sAttr \"locale\" \"fa-AF\"", "Persian (Afghanistan)"
                "faIR", "", sprintf "Interop.mk%sAttr \"locale\" \"fa-IR\"", "Persian (Iran)"
                "fa", "", sprintf "Interop.mk%sAttr \"locale\" \"fa\"", "Persian"
                "plPL", "", sprintf "Interop.mk%sAttr \"locale\" \"pl-PL\"", "Polish (Poland)"
                "pl", "", sprintf "Interop.mk%sAttr \"locale\" \"pl\"", "Polish"
                "ptBR", "", sprintf "Interop.mk%sAttr \"locale\" \"pt-BR\"", "Portuguese (Brazil)"
                "ptGW", "", sprintf "Interop.mk%sAttr \"locale\" \"pt-GW\"", "Portuguese (Guinea-Bissau)"
                "ptMZ", "", sprintf "Interop.mk%sAttr \"locale\" \"pt-MZ\"", "Portuguese (Mozambique)"
                "ptPT", "", sprintf "Interop.mk%sAttr \"locale\" \"pt-PT\"", "Portuguese (Portugal)"
                "pt", "", sprintf "Interop.mk%sAttr \"locale\" \"pt\"", "Portuguese"
                "paArab", "", sprintf "Interop.mk%sAttr \"locale\" \"pa-Arab\"", "Punjabi (Arabic)"
                "paArabPK", "", sprintf "Interop.mk%sAttr \"locale\" \"pa-Arab-PK\"", "Punjabi (Arabic, Pakistan)"
                "paGuru", "", sprintf "Interop.mk%sAttr \"locale\" \"pa-Guru\"", "Punjabi (Gurmukhi)"
                "paGuruIN", "", sprintf "Interop.mk%sAttr \"locale\" \"pa-Guru-IN\"", "Punjabi (Gurmukhi, India)"
                "pa", "", sprintf "Interop.mk%sAttr \"locale\" \"pa\"", "Punjabi"
                "roMD", "", sprintf "Interop.mk%sAttr \"locale\" \"ro-MD\"", "Romanian (Moldova)"
                "roRO", "", sprintf "Interop.mk%sAttr \"locale\" \"ro-RO\"", "Romanian (Romania)"
                "ro", "", sprintf "Interop.mk%sAttr \"locale\" \"ro\"", "Romanian"
                "rmCH", "", sprintf "Interop.mk%sAttr \"locale\" \"rm-CH\"", "Romansh (Switzerland)"
                "rm", "", sprintf "Interop.mk%sAttr \"locale\" \"rm\"", "Romansh"
                "rofTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"rof-TZ\"", "Rombo (Tanzania)"
                "rof", "", sprintf "Interop.mk%sAttr \"locale\" \"rof\"", "Rombo"
                "ruMD", "", sprintf "Interop.mk%sAttr \"locale\" \"ru-MD\"", "Russian (Moldova)"
                "ruRU", "", sprintf "Interop.mk%sAttr \"locale\" \"ru-RU\"", "Russian (Russia)"
                "ruUA", "", sprintf "Interop.mk%sAttr \"locale\" \"ru-UA\"", "Russian (Ukraine)"
                "ru", "", sprintf "Interop.mk%sAttr \"locale\" \"ru\"", "Russian"
                "rwkTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"rwk-TZ\"", "Rwa (Tanzania)"
                "rwk", "", sprintf "Interop.mk%sAttr \"locale\" \"rwk\"", "Rwa"
                "saqKE", "", sprintf "Interop.mk%sAttr \"locale\" \"saq-KE\"", "Samburu (Kenya)"
                "saq", "", sprintf "Interop.mk%sAttr \"locale\" \"saq\"", "Samburu"
                "sgCF", "", sprintf "Interop.mk%sAttr \"locale\" \"sg-CF\"", "Sango (Central African Republic)"
                "sg", "", sprintf "Interop.mk%sAttr \"locale\" \"sg\"", "Sango"
                "sehMZ", "", sprintf "Interop.mk%sAttr \"locale\" \"seh-MZ\"", "Sena (Mozambique)"
                "seh", "", sprintf "Interop.mk%sAttr \"locale\" \"seh\"", "Sena"
                "srCyrl", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Cyrl\"", "Serbian (Cyrillic)"
                "srCyrlBA", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Cyrl-BA\"", "Serbian (Cyrillic, Bosnia and Herzegovina)"
                "srCyrlME", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Cyrl-ME\"", "Serbian (Cyrillic, Montenegro)"
                "srCyrlRS", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Cyrl-RS\"", "Serbian (Cyrillic, Serbia)"
                "srLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Latn\"", "Serbian (Latin)"
                "srLatnBA", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Latn-BA\"", "Serbian (Latin, Bosnia and Herzegovina)"
                "srLatnME", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Latn-ME\"", "Serbian (Latin, Montenegro)"
                "srLatnRS", "", sprintf "Interop.mk%sAttr \"locale\" \"sr-Latn-RS\"", "Serbian (Latin, Serbia)"
                "sr", "", sprintf "Interop.mk%sAttr \"locale\" \"sr\"", "Serbian"
                "snZW", "", sprintf "Interop.mk%sAttr \"locale\" \"sn-ZW\"", "Shona (Zimbabwe)"
                "sn", "", sprintf "Interop.mk%sAttr \"locale\" \"sn\"", "Shona"
                "iiCN", "", sprintf "Interop.mk%sAttr \"locale\" \"ii-CN\"", "Sichuan Yi (China)"
                "ii", "", sprintf "Interop.mk%sAttr \"locale\" \"ii\"", "Sichuan Yi"
                "siLK", "", sprintf "Interop.mk%sAttr \"locale\" \"si-LK\"", "Sinhala (Sri Lanka)"
                "si", "", sprintf "Interop.mk%sAttr \"locale\" \"si\"", "Sinhala"
                "skSK", "", sprintf "Interop.mk%sAttr \"locale\" \"sk-SK\"", "Slovak (Slovakia)"
                "sk", "", sprintf "Interop.mk%sAttr \"locale\" \"sk\"", "Slovak"
                "slSI", "", sprintf "Interop.mk%sAttr \"locale\" \"sl-SI\"", "Slovenian (Slovenia)"
                "sl", "", sprintf "Interop.mk%sAttr \"locale\" \"sl\"", "Slovenian"
                "xogUG", "", sprintf "Interop.mk%sAttr \"locale\" \"xog-UG\"", "Soga (Uganda)"
                "xog", "", sprintf "Interop.mk%sAttr \"locale\" \"xog\"", "Soga"
                "soDJ", "", sprintf "Interop.mk%sAttr \"locale\" \"so-DJ\"", "Somali (Djibouti)"
                "soET", "", sprintf "Interop.mk%sAttr \"locale\" \"so-ET\"", "Somali (Ethiopia)"
                "soKE", "", sprintf "Interop.mk%sAttr \"locale\" \"so-KE\"", "Somali (Kenya)"
                "soSO", "", sprintf "Interop.mk%sAttr \"locale\" \"so-SO\"", "Somali (Somalia)"
                "so", "", sprintf "Interop.mk%sAttr \"locale\" \"so\"", "Somali"
                "esAR", "", sprintf "Interop.mk%sAttr \"locale\" \"es-AR\"", "Spanish (Argentina)"
                "esBO", "", sprintf "Interop.mk%sAttr \"locale\" \"es-BO\"", "Spanish (Bolivia)"
                "esCL", "", sprintf "Interop.mk%sAttr \"locale\" \"es-CL\"", "Spanish (Chile)"
                "esCO", "", sprintf "Interop.mk%sAttr \"locale\" \"es-CO\"", "Spanish (Colombia)"
                "esCR", "", sprintf "Interop.mk%sAttr \"locale\" \"es-CR\"", "Spanish (Costa Rica)"
                "esDO", "", sprintf "Interop.mk%sAttr \"locale\" \"es-DO\"", "Spanish (Dominican Republic)"
                "esEC", "", sprintf "Interop.mk%sAttr \"locale\" \"es-EC\"", "Spanish (Ecuador)"
                "esSV", "", sprintf "Interop.mk%sAttr \"locale\" \"es-SV\"", "Spanish (El Salvador)"
                "esGQ", "", sprintf "Interop.mk%sAttr \"locale\" \"es-GQ\"", "Spanish (Equatorial Guinea)"
                "esGT", "", sprintf "Interop.mk%sAttr \"locale\" \"es-GT\"", "Spanish (Guatemala)"
                "esHN", "", sprintf "Interop.mk%sAttr \"locale\" \"es-HN\"", "Spanish (Honduras)"
                "es419", "", sprintf "Interop.mk%sAttr \"locale\" \"es-419\"", "Spanish (Latin America)"
                "esMX", "", sprintf "Interop.mk%sAttr \"locale\" \"es-MX\"", "Spanish (Mexico)"
                "esNI", "", sprintf "Interop.mk%sAttr \"locale\" \"es-NI\"", "Spanish (Nicaragua)"
                "esPA", "", sprintf "Interop.mk%sAttr \"locale\" \"es-PA\"", "Spanish (Panama)"
                "esPY", "", sprintf "Interop.mk%sAttr \"locale\" \"es-PY\"", "Spanish (Paraguay)"
                "esPE", "", sprintf "Interop.mk%sAttr \"locale\" \"es-PE\"", "Spanish (Peru)"
                "esPR", "", sprintf "Interop.mk%sAttr \"locale\" \"es-PR\"", "Spanish (Puerto Rico)"
                "esES", "", sprintf "Interop.mk%sAttr \"locale\" \"es-ES\"", "Spanish (Spain)"
                "esUS", "", sprintf "Interop.mk%sAttr \"locale\" \"es-US\"", "Spanish (United States)"
                "esUY", "", sprintf "Interop.mk%sAttr \"locale\" \"es-UY\"", "Spanish (Uruguay)"
                "esVE", "", sprintf "Interop.mk%sAttr \"locale\" \"es-VE\"", "Spanish (Venezuela)"
                "es", "", sprintf "Interop.mk%sAttr \"locale\" \"es\"", "Spanish"
                "swKE", "", sprintf "Interop.mk%sAttr \"locale\" \"sw-KE\"", "Swahili (Kenya)"
                "swTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"sw-TZ\"", "Swahili (Tanzania)"
                "sw", "", sprintf "Interop.mk%sAttr \"locale\" \"sw\"", "Swahili"
                "svFI", "", sprintf "Interop.mk%sAttr \"locale\" \"sv-FI\"", "Swedish (Finland)"
                "svSE", "", sprintf "Interop.mk%sAttr \"locale\" \"sv-SE\"", "Swedish (Sweden)"
                "sv", "", sprintf "Interop.mk%sAttr \"locale\" \"sv\"", "Swedish"
                "gswCH", "", sprintf "Interop.mk%sAttr \"locale\" \"gsw-CH\"", "Swiss German (Switzerland)"
                "gsw", "", sprintf "Interop.mk%sAttr \"locale\" \"gsw\"", "Swiss German"
                "shiLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"shi-Latn\"", "Tachelhit (Latin)"
                "shiLatnMA", "", sprintf "Interop.mk%sAttr \"locale\" \"shi-Latn-MA\"", "Tachelhit (Latin, Morocco)"
                "shiTfng", "", sprintf "Interop.mk%sAttr \"locale\" \"shi-Tfng\"", "Tachelhit (Tifinagh)"
                "shiTfngMA", "", sprintf "Interop.mk%sAttr \"locale\" \"shi-Tfng-MA\"", "Tachelhit (Tifinagh, Morocco)"
                "shi", "", sprintf "Interop.mk%sAttr \"locale\" \"shi\"", "Tachelhit"
                "davKE", "", sprintf "Interop.mk%sAttr \"locale\" \"dav-KE\"", "Taita (Kenya)"
                "dav", "", sprintf "Interop.mk%sAttr \"locale\" \"dav\"", "Taita"
                "taIN", "", sprintf "Interop.mk%sAttr \"locale\" \"ta-IN\"", "Tamil (India)"
                "taLK", "", sprintf "Interop.mk%sAttr \"locale\" \"ta-LK\"", "Tamil (Sri Lanka)"
                "ta", "", sprintf "Interop.mk%sAttr \"locale\" \"ta\"", "Tamil"
                "teIN", "", sprintf "Interop.mk%sAttr \"locale\" \"te-IN\"", "Telugu (India)"
                "te", "", sprintf "Interop.mk%sAttr \"locale\" \"te\"", "Telugu"
                "teoKE", "", sprintf "Interop.mk%sAttr \"locale\" \"teo-KE\"", "Teso (Kenya)"
                "teoUG", "", sprintf "Interop.mk%sAttr \"locale\" \"teo-UG\"", "Teso (Uganda)"
                "teo", "", sprintf "Interop.mk%sAttr \"locale\" \"teo\"", "Teso"
                "thTH", "", sprintf "Interop.mk%sAttr \"locale\" \"th-TH\"", "Thai (Thailand)"
                "th", "", sprintf "Interop.mk%sAttr \"locale\" \"th\"", "Thai"
                "boCN", "", sprintf "Interop.mk%sAttr \"locale\" \"bo-CN\"", "Tibetan (China)"
                "boIN", "", sprintf "Interop.mk%sAttr \"locale\" \"bo-IN\"", "Tibetan (India)"
                "bo", "", sprintf "Interop.mk%sAttr \"locale\" \"bo\"", "Tibetan"
                "tiER", "", sprintf "Interop.mk%sAttr \"locale\" \"ti-ER\"", "Tigrinya (Eritrea)"
                "tiET", "", sprintf "Interop.mk%sAttr \"locale\" \"ti-ET\"", "Tigrinya (Ethiopia)"
                "ti", "", sprintf "Interop.mk%sAttr \"locale\" \"ti\"", "Tigrinya"
                "toTO", "", sprintf "Interop.mk%sAttr \"locale\" \"to-TO\"", "Tonga (Tonga)"
                "to'", "", sprintf "Interop.mk%sAttr \"locale\" \"to\"", "Tonga"
                "trTR", "", sprintf "Interop.mk%sAttr \"locale\" \"tr-TR\"", "Turkish (Turkey)"
                "tr", "", sprintf "Interop.mk%sAttr \"locale\" \"tr\"", "Turkish"
                "ukUA", "", sprintf "Interop.mk%sAttr \"locale\" \"uk-UA\"", "Ukrainian (Ukraine)"
                "uk", "", sprintf "Interop.mk%sAttr \"locale\" \"uk\"", "Ukrainian"
                "urIN", "", sprintf "Interop.mk%sAttr \"locale\" \"ur-IN\"", "Urdu (India)"
                "urPK", "", sprintf "Interop.mk%sAttr \"locale\" \"ur-PK\"", "Urdu (Pakistan)"
                "ur", "", sprintf "Interop.mk%sAttr \"locale\" \"ur\"", "Urdu"
                "uzArab", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Arab\"", "Uzbek (Arabic)"
                "uzArabAF", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Arab-AF\"", "Uzbek (Arabic, Afghanistan)"
                "uzCyrl", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Cyrl\"", "Uzbek (Cyrillic)"
                "uzCyrlUZ", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Cyrl-UZ\"", "Uzbek (Cyrillic, Uzbekistan)"
                "uzLatn", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Latn\"", "Uzbek (Latin)"
                "uzLatnUZ", "", sprintf "Interop.mk%sAttr \"locale\" \"uz-Latn-UZ\"", "Uzbek (Latin, Uzbekistan)"
                "uz", "", sprintf "Interop.mk%sAttr \"locale\" \"uz\"", "Uzbek"
                "viVN", "", sprintf "Interop.mk%sAttr \"locale\" \"vi-VN\"", "Vietnamese (Vietnam)"
                "vi", "", sprintf "Interop.mk%sAttr \"locale\" \"vi\"", "Vietnamese"
                "vunTZ", "", sprintf "Interop.mk%sAttr \"locale\" \"vun-TZ\"", "Vunjo (Tanzania)"
                "vun", "", sprintf "Interop.mk%sAttr \"locale\" \"vun\"", "Vunjo"
                "cyGB", "", sprintf "Interop.mk%sAttr \"locale\" \"cy-GB\"", "Welsh (United Kingdom)"
                "cy", "", sprintf "Interop.mk%sAttr \"locale\" \"cy\"", "Welsh"
                "yoNG", "", sprintf "Interop.mk%sAttr \"locale\" \"yo-NG\"", "Yoruba (Nigeria)"
                "yo", "", sprintf "Interop.mk%sAttr \"locale\" \"yo\"", "Yoruba"
                "zuZA", "", sprintf "Interop.mk%sAttr \"locale\" \"zu-ZA\"", "Zulu (South Africa)"
                "zu", "", sprintf "Interop.mk%sAttr \"locale\" \"zu\"", "Zulu" ] ]
            |> Map.ofList

        comps
        |> List.map (fun comp ->
            { comp with
                Props =
                    comp.Props
                    |> List.map (fun p ->
                        match sugars.TryFind(p.MethodName) with
                        | Some overloads ->
                            { p with
                                CustomOverloads =
                                    overloads
                                    |> List.map (fun (methodName, pCode, bCodeFun, docLine) ->
                                        let bCode = bCodeFun (String.upperFirst comp.MethodName)
                                        CustomPropOverload.create methodName pCode bCode
                                        |> fun res ->
                                            if System.String.IsNullOrEmpty docLine then res
                                            else CustomPropOverload.setDocs [ docLine ] res) }
                        | _ -> p) })

    let applyPropOverrides (comps: Component list) =
        let overrides =
            [ "globalTransforms",
              fun (prop: Prop) ->
                  { prop with
                      MethodName = "transforms"
                      RegularOverloads = [
                          ("(properties: #ITransformsProperty list)",
                           "(properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)")
                          ||> RegularPropOverload.create
                      ] }
              "rangebreaks",
              fun (prop: Prop) ->
                  { prop with
                      MethodName = "rangebreaks"
                      RegularOverloads = [
                          ("(properties: #IRangebreaksProperty list)",
                           "(properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)")
                          ||> RegularPropOverload.create
                      ] } ]
            |> Map.ofList

        comps
        |> List.map (fun comp ->
            { comp with
                Props =
                    comp.Props
                    |> List.map (fun p ->
                        match overrides.TryFind(p.MethodName) with
                        | Some propMap -> propMap p
                        | _ -> p) })

    /// Parse the Plotly.js json schema
    let parseApi() =
        let components =
            getAllComponents()
            |> addSugaredOverloads
            |> applyPropOverrides
            |> List.map (fun comp ->
                { comp with
                    Props =
                        comp.Props
                        |> List.sortBy (fun p -> p.MethodName) })

        let addAllComponents api = (api, components) ||> List.fold (flip ComponentApi.addComponent)

        let bindingsPrelude =
            [ "Create the plotly traces.",
              "static member inline traces (properties: #ITracesProperty list) = Bindings.extractTraces properties"
              "Create the plotly config.",
              "static member inline config (properties: #IConfigProperty list) = Interop.mkPlotAttr \"config\" (createObj !!properties)"
              "Create the plotly layout.",
              "static member inline layout (properties: #ILayoutProperty list) = Interop.mkPlotAttr \"layout\" (createObj !!properties)"
              "Create plot frames.",
              "static member inline frames (properties: #IFramesProperty list) = Interop.mkPlotAttr \"frames\" (createObj !!properties)"
              "When provided, causes the plot to update when the revision is incremented.",
              "static member inline revision (value: int) = Interop.mkPlotAttr \"revision\" value"
              "When provided, causes the plot to update when the revision is incremented.",
              "static member inline revision (value: float) = Interop.mkPlotAttr \"revision\" value"
              "Callback executed after plot is initialized.",
              "static member inline onInitialized (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr \"onInitialized\" handler"
              "Callback executed when when a plot is updated due to new data or layout, or when user interacts with a plot.",
              "static member inline onUpdate (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr \"onUpdate\" handler"
              "Callback executed when component unmounts, before Plotly.purge strips the graphDiv of all private attributes.",
              "static member inline onPurge (handler: Events.Figure -> HTMLElement -> unit) = Interop.mkPlotAttr \"onPurge\" handler"
              "Callback executed when a plotly.js API method rejects.",
              "static member inline onError (handler: ErrorEvent -> unit) = Interop.mkPlotAttr \"onError\" handler"
              "Id assigned to the <div> into which the plot is rendered.",
              "static member inline divId (value: string) = Interop.mkPlotAttr \"divId\" value"
              "Class applied to the <div> into which the plot is rendered.",
              "static member inline className (value: string) = Interop.mkPlotAttr \"className\" value"
              "Styles the <div> into which the plot is rendered.",
              "static member inline style (properties: #IStyleAttribute list) = Interop.mkPlotAttr \"style\" (createObj !!properties)"
              "Assign the graph div to window.gd for debugging.",
              "static member inline debug (value: bool) = Interop.mkPlotAttr \"debug\" value"
              "When true, adds a call to Plotly.Plot.resize() as a window.resize event handler.",
              "static member inline useResizeHandler (value: bool) = Interop.mkPlotAttr \"useResizeHandler\" value"
              "Callback executed when the plot is exported.",
              "static member inline onAfterExport (handler: unit -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "Callback executed when the plot is drawn.",
              "static member inline onAfterPlot (handler: unit -> unit) = Interop.mkPlotAttr \"onAfterPlot\" handler"
              "Callback executed when the plot has been animated.",
              "static member inline onAnimated (handler: unit -> unit) = Interop.mkPlotAttr \"onAnimated\" handler"
              "Callback executed when there is an animating frame.",
              "static member inline onAnimatingFrame (handler: Events.FrameAnimationEvent -> unit) = Interop.mkPlotAttr \"onAnimatingFrame\" handler"
              "Callback executed when an animation gets interrupted.",
              "static member inline onAnimationInterrupted (handler: unit -> unit) = Interop.mkPlotAttr \"onAnimationInterrupted\" handler"
              "Callback executed when the plot resizes automatically.",
              "static member inline onAutoSize (handler: unit -> unit) = Interop.mkPlotAttr \"onAutoSize\" handler"
              "Callback executed when a plot is being exported, before the export occurs.",
              "static member inline onBeforeExport (handler: unit -> unit) = Interop.mkPlotAttr \"onBeforeExport\" handler"
              "Callback executed when a plot is about to be hovered.",
              "static member inline onBeforeHover (handler: unit -> unit) = Interop.mkPlotAttr \"onBeforeHover\" handler"
              "Callback executed when a menu button is clicked.",
              "static member inline onButtonClicked (handler: Events.ButtonClickedEvent -> unit) = Interop.mkPlotAttr \"onButtonClicked\" handler"
              "Callback executed when a plot item is clicked.",
              "static member inline onClick (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onClick\" handler"
              "Callback executed when an annotation is clicked.",
              "static member inline onClickAnnotation (handler: Events.ClickAnnotationEvent -> unit) = Interop.mkPlotAttr \"onClickAnnotation\" handler"
              "Callback executed when a plot item is deselected.",
              "static member inline onDeselect (handler: unit -> unit) = Interop.mkPlotAttr \"onDeselect\" handler"
              "Callback executed when a plot point is double clicked.",
              "static member inline onDoubleClick (handler: unit -> unit) = Interop.mkPlotAttr \"onDoubleClick\" handler"
              "Callback executed when a plot creates or re-creates a framework.",
              "static member inline onFramework (handler: unit -> unit) = Interop.mkPlotAttr \"onFramework\" handler"
              "Callback executed when a plot item is hovered over.",
              "static member inline onHover (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onHover\" handler"
              "Callback executed when the legend is clicked.",
              "static member inline onLegendClick (handler: Events.LegendClickEvent -> unit) = Interop.mkPlotAttr \"onLegendClick\" handler"
              "Callback executed when the legend is double clicked.",
              "static member inline onLegendDoubleClick (handler: Events.LegendClickEvent -> unit) = Interop.mkPlotAttr \"onLegendDoubleClick\" handler"
              "Callback executed when the plot performs a relayout.",
              "static member inline onRelayout (handler: Events.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr \"onRelayout\" handler"
              "Callback executed when the plot is performing a relayout.",
              "static member inline onRelayouting (handler: Events.PlotRelayoutEvent -> unit) = Interop.mkPlotAttr \"onRelayouting\" handler"
              "Callback executed when the plot performs a restyle.",
              "static member inline onRestyle (handler: Events.PlotRestyleEvent -> unit) = Interop.mkPlotAttr \"onRestyle\" handler"
              "Callback executed when the plot is redrawn.",
              "static member inline onRedraw (handler: unit -> unit) = Interop.mkPlotAttr \"onRedraw\" handler"
              "Callback executed when a plot item is selected.",
              "static member inline onSelected (handler: Events.PlotSelectionEvent -> unit) = Interop.mkPlotAttr \"onSelected\" handler"
              "Callback executed when a plot item is about to be selected.",
              "static member inline onSelecting (handler: Events.PlotSelectionEvent -> unit) = Interop.mkPlotAttr \"onSelecting\" handler"
              "Callback executed when a plot slider is changing.",
              "static member inline onSliderChange (handler: Events.SliderChangeEvent -> unit) = Interop.mkPlotAttr \"onSliderChange\" handler"
              "Callback executed when a plot slider finished changing.",
              "static member inline onSliderEnd (handler: Events.SliderEndEvent -> unit) = Interop.mkPlotAttr \"onSliderEnd\" handler"
              "Callback executed when a plot slider is about to change.",
              "static member inline onSliderStart (handler: Events.SliderStartEvent -> unit) = Interop.mkPlotAttr \"onSliderStart\" handler"
              "Callback executed when a sunburst trace is clicked.",
              "static member inline onSunburstClick (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onSunburstClick\" handler"
              "Callback executed when a plot is performing a transition.",
              "static member inline onTransitioning (handler: unit -> unit) = Interop.mkPlotAttr \"onTransitioning\" handler"
              "Callback executed when a plot transition is interrupted.",
              "static member inline onTransitionInterrupted (handler: unit -> unit) = Interop.mkPlotAttr \"onTransitionInterrupted\" handler"
              "Callback executed when a plot item is unhovered.",
              "static member inline onUnhover (handler: Events.PlotMouseEvent -> unit) = Interop.mkPlotAttr \"onUnhover\" handler" ]

        let bindings =
            [ "Create a Plotly plot component.",
              "static member inline plot (props: #IPlotProperty list) : ReactElement = Bindings.createPlot (createObj !!props)" ]

        let customPropTypes =
            let format =
                CustomPropertyType.create "format"
                |> CustomPropertyType.addFunctions [
                    "The days in order of Sunday to Saturday.",
                    "static member inline days (value: seq<string>) = Interop.mkFormatAttr \"days\" (ResizeArray value)"
                    "The short form of days in order of Sunday to Saturday.",
                    "static member inline shortDays (value: seq<string>) = Interop.mkFormatAttr \"shortDays\" (ResizeArray value)"
                    "The months in order of January to December.",
                    "static member inline months (value: seq<string>) = Interop.mkFormatAttr \"months\" (ResizeArray value)"
                    "The short form of months in order of January to December.",
                    "static member inline shortMonths (value: seq<string>) = Interop.mkFormatAttr \"shortMonths\" (ResizeArray value)"
                    "The date in javascript format syntax (such as %d.%m.%Y).",
                    "static member inline date (value: string) = Interop.mkFormatAttr \"date\" value"
                ]

            let locale =
                CustomPropertyType.create "locale"
                |> CustomPropertyType.addFunctions [
                    "Add a dictionary to use for localization.",
                    "static member inline dictionary (entries: seq<(string * string)>) = Interop.mkLocaleAttr \"dictionary\" (createObj !!entries)"
                    "Add a dictionary to use for localization.",
                    "static member inline dictionary (entries: Map<string,string>) = Interop.mkLocaleAttr \"dictionary\" (createObj !!(List.ofSeq entries))"
                    "The formatting of dates and times.",
                    "static member inline format (properties: IFormatProperty list) = Interop.mkLocaleAttr \"format\" (createObj !!properties)"
                ]

            let locales =
                CustomPropertyType.create "locales"
                |> CustomPropertyType.addFunctions [
                    "Register a locale to be used with the plot, takes the name of the locale (such as en-US), and configuration.",
                    "static member inline locale (name: string) (properties: ILocaleProperty list) = Interop.mkLocalesAttr name (createObj !!properties)"
                ]

            let measure =
                CustomPropertyType.create "measure"
                |> CustomPropertyType.addProperties [
                    "absolute"
                    "relative"
                    "total"
                ]

            let modeBarButtons =
                CustomPropertyType.create "modeBarButtons"
                |> CustomPropertyType.addProperties [
                    "autoScale2d"
                    "editInChartStudio"
                    "hoverClosest3d"
                    "hoverClosestCartesian"
                    "hoverClosestGeo"
                    "hoverClosestPie"
                    "hoverCompareCartesian"
                    "lasso2d"
                    "orbitRotation"
                    "pan2d"
                    "pan3d"
                    "resetCameraDefault3d"
                    "resetCameraLastSave3d"
                    "resetGeo"
                    "resetScale2d"
                    "resetViewMapbox"
                    "resetViews"
                    "resetViewSankey"
                    "sendDataToCloud"
                    "select2d"
                    "tableRotation"
                    "toggleHover"
                    "toggleSpikelines"
                    "toImage"
                    "zoom2d"
                    "zoom3d"
                    "zoomIn2d"
                    "zoomInGeo"
                    "zoomOutGeo"
                    "zoomOut2d"
                ]
                |> CustomPropertyType.addFunctions [
                    "Convert a custom buttons.button to a modeBarButton.",
                    "static member inline fromButton (button: IButtonsProperty) = unbox<IModeBarButtonsProperty> button"
                    "Convert a list of buttons.button to a list of modeBarButtons.",
                    "static member inline fromButton (properties: #IButtonProperty list) = Interop.mkModeBarButtonsAttr \"button\" (createObj !!properties)"
                ]

            let template =
                CustomPropertyType.create "template"
                |> CustomPropertyType.addFunctions [
                    "Create the plotly template traces.",
                    "static member inline traces (properties: ITracesProperty list) = Interop.mkTemplateAttr \"data\" (createObj !!(Bindings.convertTracesToTemplate properties))"
                    "Create the plotly template layout.",
                    "static member inline layout (properties: #ILayoutProperty list) = Interop.mkTemplateAttr \"layout\" (createObj !!properties)"
            ]

            let toImageButtonOptions =
                CustomPropertyType.create "toImageButtonOptions"
                |> CustomPropertyType.addFunctions [
                    "Sets the image file name.",
                    "static member inline fileName (value: string) = Interop.mkToImageButtonOptionsAttr \"filename\" value"
                    "Sets the image height.",
                    "static member inline height (value: float) = Interop.mkToImageButtonOptionsAttr \"height\" value"
                    "Sets the image height.",
                    "static member inline height (value: int) = Interop.mkToImageButtonOptionsAttr \"height\" value"
                    "Sets the image scale, modifies the size of the title/legend/axis/canvas sizes by this value.",
                    "static member inline scale (value: float) = Interop.mkToImageButtonOptionsAttr \"scale\" value"
                    "Sets the image scale, modifies the size of the title/legend/axis/canvas sizes by this value.",
                    "static member inline scale (value: int) = Interop.mkToImageButtonOptionsAttr \"scale\" value"
                    "Sets the image width.",
                    "static member inline width (value: float) = Interop.mkToImageButtonOptionsAttr \"width\" value"
                    "Sets the image width.",
                    "static member inline width (value: int) = Interop.mkToImageButtonOptionsAttr \"width\" value"
                ]
                |> CustomPropertyType.addChildren [
                    CustomPropertyType.create "format"
                    |> CustomPropertyType.addEnums [
                        EnumPropOverload.createStr "jpeg"
                        EnumPropOverload.createStr "png"
                        EnumPropOverload.createStr "svg"
                        EnumPropOverload.createStr "webp"
                    ]
                ]

            [ format
              locale
              locales
              measure
              modeBarButtons
              template
              toImageButtonOptions ]

        let typePrelude =
            [ "ModeBarButtons", "interface end" ]

        let typePostlude =
            [ "Buttons", "inherit IModeBarButtonsProperty"
              "DownloadImage", "interface end"
              "Format", "interface end"
              "ToImageButtonOptions", "interface end"
              "Locale", "interface end"
              "Locales", "interface end"
              "Measure", "interface end"
              "Template", "interface end"
              "ToImage", "interface end" ]

        let api =
            ComponentApi.create "Feliz.Plotly" "Plot" "Plotly" bindingsPrelude bindings typePrelude typePostlude
            |> addAllComponents
            |> ComponentApi.addCustomPropertyTypes customPropTypes

        { GeneratorComponentApi = api
          PlotlyComponents = components }
