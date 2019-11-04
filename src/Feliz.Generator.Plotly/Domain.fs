namespace Fable.Plotly.Generator

module rec Domain =
    open FSharp.Data
    open FSharp.Data.JsonExtensions

    type RegularPropOverloadBody =
        | ValueExprOnly of string
        | CustomBody of string

    type RegularPropOverload =
        { /// The code for the method parameters, e.g. `(value: string)`.
          ParamsCode: string
          /// The code for the prop value expression, e.g. `value` or
          /// `(System.Func<_,_,_> handler)`.
          BodyCode: RegularPropOverloadBody
          /// Whether the member is inline.
          IsInline: bool
          /// Whether the member should be implemented as an extension member.
          IsExtension: bool }

    module RegularPropOverload =
        /// Creates an inline prop overload with the specified code for params and
        /// value expression, implemented as a regular (non-extension) member.
        let create paramsCode valueCode =
            { ParamsCode = paramsCode
              BodyCode = ValueExprOnly valueCode
              IsInline = true
              IsExtension = false }

        /// Creates an inline prop overload with the specified code for params and
        /// body, implemented as a regular (non-extension) member.
        let createCustom paramsCode customBodyCode =
            { ParamsCode = paramsCode
              BodyCode = CustomBody customBodyCode
              IsInline = true
              IsExtension = false }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: RegularPropOverload) = { overload with IsInline = isInline }

        /// Sets whether the overload is implemented as an extension member.
        let setExtension isExtension (overload: RegularPropOverload) = { overload with IsExtension = isExtension }

    type EnumPropOverload =
        { /// The doc lines for the enum prop's value/overload, without leading ///.
          DocLines: string list
          /// The name of the enum prop's value/overload.
          MethodName: string
          /// The code for the method parameters, e.g. `(value: string)`. Normally this
          /// would be `None` (for simple enum values).
          ParamsCode: string option
          /// The code for the prop value expression. Normally this would be the enum
          /// value, e.g. `"topRight"`.
          ValueCode: string
          /// Whether the member is inline.
          IsInline: bool }

    module EnumPropOverload =
        /// Creates an inline enum prop value/overload with the specified method name
        /// and code for value expression and no docs or params.
        let create methodName valueCode =
            { DocLines = []
              MethodName = methodName
              ParamsCode = None
              ValueCode = valueCode
              IsInline = true }

        /// Sets the doc lines of the enum prop value/overload.
        let setDocs docLines (overload: EnumPropOverload) = { overload with DocLines = docLines }

        /// Sets the params code for the enum prop value/overload.
        let setParamsCode code (overload: EnumPropOverload) = { overload with ParamsCode = Some code }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: EnumPropOverload) = { overload with IsInline = isInline }

    type PrimSpecs =
        { ArrayOk: bool
          NumArrayOk: bool
          TwoDimArrayOk: bool
          NullOk: bool
          IsCalcType: bool }

    type PrimSpecOverrides =
        { ArrayOk: bool * bool
          NumArrayOk: bool * bool
          TwoDimArrayOk: bool * bool
          NullOk: bool * bool
          IsCalcType: bool * bool }

    module PrimSpecs =
        let create (jVal: JsonValue) : PrimSpecs =
            let isArrayOk =
                match jVal.TryGetProperty("arrayOk") with
                | Some arrOk -> arrOk.AsBoolean()
                | None -> false

            { ArrayOk = isArrayOk
              NumArrayOk =
                  match jVal.TryGetProperty("description") with
                  | Some desc when desc.AsString().Contains("array of numbers") -> true
                  | _ -> false
              TwoDimArrayOk =
                  if isArrayOk then
                      jVal.TryGetProperty("description")
                      |> Option.map (JsonExtensions.AsString >> (fun s -> s.Contains "2D array"))
                      |> Option.defaultValue false
                  else
                      false
              NullOk =
                  match jVal.TryGetProperty("role") with
                  | Some role when role |> JsonExtensions.AsString = "data" -> true
                  | _ -> false
              IsCalcType =
                  let editType =
                      jVal.TryGetProperty("editType")
                      |> Option.map (JsonExtensions.AsString >> ((=) "calc"))
                      |> Option.defaultValue false

                  let role =
                      jVal.TryGetProperty("role")
                      |> Option.map (JsonExtensions.AsString >> ((=) "data"))
                      |> Option.defaultValue false

                  editType && role }

        let allFalse : PrimSpecs =
            { ArrayOk = false
              NumArrayOk = false
              TwoDimArrayOk = false
              NullOk = false
              IsCalcType = false }

        let applyOverride (overrides: PrimSpecOverrides) (baseSpecs: PrimSpecs) =
            { baseSpecs with
                ArrayOk =
                    match overrides.ArrayOk with
                    | true, b -> b
                    | false, _ -> baseSpecs.ArrayOk 
                NumArrayOk =
                    match overrides.NumArrayOk with
                    | true, b -> b
                    | false, _ -> baseSpecs.NumArrayOk
                TwoDimArrayOk =
                    match overrides.TwoDimArrayOk with
                    | true, b -> b
                    | false, _ -> baseSpecs.TwoDimArrayOk
                NullOk =
                    match overrides.NullOk with
                    | true, b -> b
                    | false, _ -> baseSpecs.NullOk
                IsCalcType =
                    match overrides.IsCalcType with
                    | true, b -> b
                    | false, _ -> baseSpecs.IsCalcType }

    module PrimSpecOverrides =
        let empty : PrimSpecOverrides =
            { ArrayOk = false, false
              NumArrayOk = false, false
              TwoDimArrayOk = false, false
              NullOk = false, false
              IsCalcType = false, false }

    [<RequireQualifiedAccess>]
    type ValType =
        | Any
        | Bool of PrimSpecs
        | Color of PrimSpecs
        | ColorArray
        | ColorScale
        | DataArray
        | Enumerated
        | EnumeratedArray
        | EnumeratedWithCustom
        | FlagList
        | FloatArray
        | InfoArray of ValType
        | Int of PrimSpecs
        | List of ValType
        | Number of PrimSpecs
        | String of PrimSpecs
        | Component

    module ValType =
        let boolStr = "(value: bool)", "value"
        let boolResizeSingleton = "(value: bool)", "(value |> Array.singleton |> ResizeArray)"
        let boolSeqResizeStr = "(values: seq<bool>)", "(values |> ResizeArray)"
        let boolSeqResizeStrOpt = "(values: seq<bool option>)", "(values |> ResizeArray)"
        let boolSeqStr = "(values: seq<bool>)", "(values |> Array.ofSeq)"
        let boolSeqStrOpt = "(values: seq<bool option>)", "(values |> Array.ofSeq)"
        let boolSingleton = "(value: bool)", "(value |> Array.singleton)"
        let bool2DSeqStr = "(values: seq<seq<bool>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let bool2DSeqStrOpt = "(values: seq<seq<bool option>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let bool2DListStr =
            "(values: seq<bool list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let bool2DListStrOpt =
            "(values: seq<bool option list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let bool2DArrayStr = "(values: seq<bool []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"
        let bool2DArrayStrOpt = "(values: seq<bool option []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"
        
        let compStr s = sprintf "(properties: #I%sProperty list)" s, "(createObj !!properties)"

        let dataU42DArray = // When you refactor this add options into the mix
            "(values: seq<U4<int [], float [], string [], bool []>>)",
            "(values |> Seq.map U4.mapArrayToResize |> Array.ofSeq)"
        let dataU42DList =
            "(values: seq<U4<int list, float list, string list, bool list>>)",
            "(values |> Seq.map U4.mapListToResize |> Array.ofSeq)"

        let dateStr = "(value: System.DateTime)", "value"
        let dateResizeSingleton = "(value: System.DateTime)", "(value |> Array.singleton |> ResizeArray)"
        let dateSeqResizeStr = "(values: seq<System.DateTime>)", "(values |> ResizeArray)"
        let dateSeqResizeStrOpt = "(values: seq<System.DateTime option>)", "(values |> ResizeArray)"
        let dateSeqStr = "(values: seq<System.DateTime>)", "(values |> Array.ofSeq)"
        let dateSeqStrOpt = "(values: seq<System.DateTime option>)", "(values |> Array.ofSeq)"
        let dateSingleton = "(value: System.DateTime)", "(value |> Array.singleton)"

        let enumeratedArrayStrSeq s =
            sprintf "(properties: #I%sProperty list)" s, "(properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)"

        let flaglistStrSeq s =
            sprintf "(properties: #I%sProperty list)" s,
            "(properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat \"+\")"

        let floatStr = "(value: float)", "value"
        let floatResizeSingleton = "(value: float)", "(value |> Array.singleton |> ResizeArray)"
        let floatSeqResizeStr = "(values: seq<float>)", "(values |> ResizeArray)"
        let floatSeqResizeStrOpt = "(values: seq<float option>)", "(values |> ResizeArray)"
        let floatSeqStr = "(values: seq<float>)", "(values |> Array.ofSeq)"
        let floatSeqStrOpt = "(values: seq<float option>)", "(values |> Array.ofSeq)"
        let floatSingleton = "(value: float)", "(value |> Array.singleton)"
        let float32FromFloatSeqStr = "(values: seq<float>)", "(values |> Seq.map float32 |> Array.ofSeq)"
        let float32FromFloatSeqStrOpt = "(values: seq<float option>)", "(values |> Seq.map (Option.map float32) |> Array.ofSeq)"
        let float32FromIntSeqStr = "(values: seq<int>)", "(values |> Seq.map float32 |> Array.ofSeq)"
        let float32FromIntSeqStrOpt = "(values: seq<int option>)", "(values |> Seq.map (Option.map float32) |> Array.ofSeq)"
        let float2DSeqStr =
            "(values: seq<seq<float>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let float2DSeqStrOpt =
            "(values: seq<seq<float option>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let float2DListStr =
            "(values: seq<float list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let float2DListStrOpt =
            "(values: seq<float option list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let float2DArrayStr = "(values: seq<float []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"
        let float2DArrayStrOpt = "(values: seq<float option []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"

        let intStr = "(value: int)", "value"
        let intResizeSingleton = "(value: int)", "(value |> Array.singleton |> ResizeArray)"
        let intSeqResizeStr = "(values: seq<int>)", "(values |> ResizeArray)"
        let intSeqResizeStrOpt = "(values: seq<int option>)", "(values |> ResizeArray)"
        let intSeqStr = "(values: seq<int>)", "(values |> Array.ofSeq)"
        let intSeqStrOpt = "(values: seq<int option>)", "(values |> Array.ofSeq)"
        let intSingleton = "(value: int)", "(value |> Array.singleton)"
        let int2DSeqStr = "(values: seq<seq<int>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let int2DSeqStrOpt = "(values: seq<seq<int option>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let int2DListStr = "(values: seq<int list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let int2DListStrOpt = "(values: seq<int option list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let int2DArrayStr = "(values: seq<int option []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"
        let int2DArrayStrOpt = "(values: seq<int option []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"

        let stringStr = "(value: string)", "value"
        let stringResizeSingleton = "(value: string)", "(value |> Array.singleton |> ResizeArray)"
        let stringSeqResizeStr = "(values: seq<string>)", "(values |> ResizeArray)"
        let stringSeqResizeStrOpt = "(values: seq<string option>)", "(values |> ResizeArray)"
        let stringSeqStr = "(values: seq<string>)", "(values |> Array.ofSeq)"
        let stringSeqStrOpt = "(values: seq<string option>)", "(values |> Array.ofSeq)"
        let stringSingleton = "(value: string)", "(value |> Array.singleton)"
        let string2DSeqStr =
            "(values: seq<seq<string>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let string2DSeqStrOpt =
            "(values: seq<seq<string option>>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let string2DListStr =
            "(values: seq<string list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let string2DListStrOpt =
            "(values: seq<string option list>)", "(values |> Seq.map (Array.ofSeq >> ResizeArray) |> Array.ofSeq)"
        let string2DArrayStr = "(values: seq<string []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"
        let string2DArrayStrOpt = "(values: seq<string option []>)", "(values |> Seq.map ResizeArray |> Array.ofSeq)"

        let allNormalStrs =
            [ boolStr; boolSeqStr; dateStr; dateSeqStr; intStr; intSeqStr; floatStr; floatSeqStr; stringStr; stringSeqStr ]

        let allNormalOptStrs =
            [ boolSeqStrOpt; dateSeqStrOpt; intSeqStrOpt; floatSeqStrOpt; stringSeqStrOpt ]

        let allBool2DStrs = [ bool2DSeqStr; bool2DListStr; bool2DArrayStr ]
        let allBool2DStrOpt = [ bool2DSeqStrOpt; bool2DListStrOpt; bool2DArrayStrOpt ]

        let allFloat2DStrs = [ float2DSeqStr; float2DListStr; float2DArrayStr ]
        let allFloat2DStrOpt = [ float2DSeqStrOpt; float2DListStrOpt; float2DArrayStrOpt ]

        let allInt2DStrs = [ int2DSeqStr; int2DListStr; int2DArrayStr ]
        let allInt2DStrOpt = [ int2DSeqStrOpt; int2DListStrOpt; int2DArrayStrOpt ]

        let allStr2DStrs = [ string2DSeqStr; string2DListStr; string2DArrayStr ]
        let allStr2DStrOpt = [ string2DSeqStrOpt; string2DListStrOpt; string2DArrayStrOpt ]

        let all2DStrsNoUnions = allBool2DStrs @ allStr2DStrs @ allInt2DStrs @ allFloat2DStrs
        let all2DStrsNoUnionsOpt = allBool2DStrOpt @ allFloat2DStrOpt @ allInt2DStrOpt @ allStr2DStrOpt

        let all2DStrs = all2DStrsNoUnions @ [ dataU42DArray; dataU42DList ]

        let allBoolArrStrs = [ boolResizeSingleton; boolSeqResizeStr ]

        let allDateArrStrs = [ dateResizeSingleton; dateSeqResizeStr ]

        let allFloatArrStrs = [ floatResizeSingleton; floatSeqResizeStr ]

        let allIntArrStrs = [ intResizeSingleton; intSeqResizeStr ]

        let allStringArrStrs = [ stringResizeSingleton; stringSeqResizeStr ]

        let allArrStrs = allBoolArrStrs @ allDateArrStrs @ allIntArrStrs @ allFloatArrStrs @ allStringArrStrs

        let allArrOptStrs = [ boolSeqResizeStrOpt; dateSeqResizeStrOpt; intSeqResizeStrOpt; floatSeqResizeStrOpt; stringSeqResizeStrOpt ]

        let getPrimativeOverloadSeq =
            function
            | ValType.Any -> allArrStrs
            | ValType.Bool _ -> allBoolArrStrs
            | ValType.ColorScale -> [ stringStr; string2DListStr ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedWithCustom -> []
            | ValType.FlagList -> []
            | ValType.Int _ -> allIntArrStrs
            | ValType.Number _ -> allIntArrStrs @ allFloatArrStrs
            | ValType.String _ -> allStringArrStrs
            | s ->
                printfn "%s" (s.ToString())
                [ "(value: TODO)", "value" ]

        /// Extracts the type of the prop recursively
        let rec getType propName attribOverrides (jVal: JsonValue) =
            let hasValType = jVal.TryGetProperty("valType").IsSome

            let isEnumeratedWithCustom() =
                jVal?values.AsArray()
                |> Array.filter (fun s -> s.AsString() |> String.containsRegex)
                |> Array.length > 0

            let attributes = 
                PrimSpecs.create jVal
                |> PrimSpecs.applyOverride attribOverrides

            match propName, hasValType with
            | "scaleanchor", true -> ValType.String attributes
            | "matches", true when jVal?valType.AsString() = "enumerated" -> ValType.String attributes
            | "xy", true -> ValType.FloatArray
            | _, true ->
                match jVal?valType
                      |> JsonValue.asString
                      |> fun s -> s.Trim('"') with
                | "angle" -> ValType.Number attributes
                | "any" -> ValType.Any
                | "boolean" -> ValType.Bool attributes
                | "color" ->
                    match attributes.ArrayOk && attributes.NumArrayOk with
                    | true -> ValType.ColorArray
                    | false when attributes.ArrayOk -> ValType.Color attributes
                    | false -> ValType.String attributes
                | "colorlist" -> ValType.String PrimSpecs.allFalse |> ValType.List
                | "colorscale" -> ValType.ColorScale
                | "data_array" -> ValType.DataArray
                | "enumerated" when isEnumeratedWithCustom() -> ValType.EnumeratedWithCustom
                | "enumerated" ->
                    if attributes.ArrayOk then ValType.EnumeratedArray
                    else ValType.Enumerated
                | "flaglist" -> ValType.FlagList
                | "info_array" ->
                    if jVal?items.AsArray().Length < 1 then jVal?items
                    else jVal?items.AsArray().[0]
                    |> getType propName attribOverrides
                    |> ValType.InfoArray
                | "integer" -> ValType.Int attributes
                | "number" -> ValType.Number attributes
                | "string" -> ValType.String attributes
                | "subplotid" -> ValType.String attributes
                | _ -> ValType.Any
            | _ -> ValType.Component

        /// Returns a list of primative overloads for the `ValType`
        let getOverloadStrings (parentName: string) (compName: string) (vType: ValType) =
            match vType with
            | ValType.Any -> allNormalStrs
            | ValType.Bool attrib ->
                [ boolStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          boolSeqStr
                      else
                          boolSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allBool2DStrs ]
            | ValType.Color attrib -> [ stringStr; if attrib.IsCalcType then stringSeqStr else stringSeqResizeStr; intSeqStr; floatSeqStr; if attrib.TwoDimArrayOk then yield! allStr2DStrs  ]
            | ValType.ColorArray -> [ stringStr; stringSeqStr; intSingleton; intSeqStr; floatSingleton; floatSeqStr ]
            | ValType.ColorScale -> [ stringStr; string2DListStr ]
            | ValType.DataArray -> allNormalStrs @ all2DStrs @ allArrOptStrs
            | ValType.Enumerated -> [ ]
            | ValType.EnumeratedArray -> [ enumeratedArrayStrSeq parentName ]
            | ValType.EnumeratedWithCustom -> [ ]
            | ValType.FlagList -> [ flaglistStrSeq parentName ]
            | ValType.FloatArray -> [ float32FromIntSeqStr; float32FromFloatSeqStr ]
            | ValType.InfoArray vt ->
                match vt with
                | ValType.List vtPrim -> vtPrim
                | _ -> vt
                |> getPrimativeOverloadSeq
            | ValType.Int attrib ->
                [ intStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          intSeqStr
                      else
                          intSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allInt2DStrs ]
            | ValType.List vt -> getPrimativeOverloadSeq vt
            | ValType.Number attrib ->
                [ intStr
                  floatStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          yield! [ intSeqStr; floatSeqStr ]
                      else
                          yield! [ intSeqResizeStr; floatSeqResizeStr ]
                          if attrib.TwoDimArrayOk then
                              yield! [ yield! allInt2DStrs
                                       yield! allFloat2DStrs ] ]
            | ValType.String attrib ->
                [ stringStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          stringSeqStr
                      else
                          stringSeqResizeStr
                          if attrib.TwoDimArrayOk then yield! allStr2DStrs ]
            | ValType.Component -> [ compStr compName ]

        let isPrimative (vType: ValType) =
            match vType with
            | ValType.Component
            | ValType.Enumerated
            | ValType.EnumeratedArray
            | ValType.EnumeratedWithCustom
            | ValType.FlagList -> false
            | _ -> true

    type Prop =
        { /// The doc lines for the prop, without leading ///.
          DocLines: string list
          /// The actual name of the prop in the native API.
          RealPropName: string
          /// The name used for the prop overload methods.
          MethodName: string
          /// The prop overloads.
          RegularOverloads: RegularPropOverload list
          /// The prop overloads.
          EnumOverloads: EnumPropOverload list
          /// The list of parent components
          ParentNameTree: string list
          /// The data type of the prop
          PropType: ValType }

    module Prop =
        /// Creates a prop with the specified native API name and method name and no
        /// docs or overloads.
        let create propType realPropName methodName =
            { DocLines = []
              RealPropName = realPropName
              MethodName = methodName
              RegularOverloads = []
              EnumOverloads = []
              ParentNameTree = []
              PropType = propType }

        /// Sets the prop's doc lines.
        let setDocs docLines (prop: Prop) = { prop with DocLines = docLines }

        /// Adds the specified regular (non-enum) overload to the prop.
        let addRegularOverload overload prop = { prop with RegularOverloads = prop.RegularOverloads @ [ overload ] }

        /// Adds the specified enum value/overload to the prop.
        let addEnumOverload overload prop = { prop with EnumOverloads = prop.EnumOverloads @ [ overload ] }

        /// Adds the specified component tree to the prop.
        let addParentComponentTree (tree: string list) (prop: Prop) =
            { prop with ParentNameTree = prop.ParentNameTree @ (tree |> List.map String.upperFirst) }

        /// Indicates whether all regular prop overloads are inline.
        let allRegularOverloadsAreInline prop = prop.RegularOverloads |> List.forall (fun o -> o.IsInline)

    type ComponentOverload =
        { /// The code for the method parameters, e.g. `props` or `(text: string)`.
          ParamFun: string -> string
          /// The expression for the props passed to the created element, e.g. `props`
          /// or `[ prop.children (Html.text text) ]`.
          PropsCode: string
          /// Whether the member is inline.
          IsInline: bool
          /// Whether the attribute should produce an attribute for a higher level component
          SkipAttr: bool }

    module ComponentOverload =
        /// A default overload that accepts and passes a list of props.
        let defaults =
            [ { ParamFun = sprintf "(properties: #I%sProperty list)"
                PropsCode = "(createObj !!properties)"
                IsInline = true
                SkipAttr = false } ]

        /// Creates an inline component overload with the specified code for params
        /// and props expression.
        let create paramFun propsCode =
            { ParamFun = paramFun
              PropsCode = propsCode
              IsInline = true
              SkipAttr = false }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: ComponentOverload) = { overload with IsInline = isInline }

        /// Sets the overload parameter function
        let setParamFun paramFun (overload: ComponentOverload) = { overload with ParamFun = paramFun }

        /// Sets the overload props code
        let setPropsCode propsCode (overload: ComponentOverload) = { overload with PropsCode = propsCode }

        /// Sets if the component should produce an attribute for a higher level component
        let setSkipAttr b (overload: ComponentOverload) = { overload with SkipAttr = b }

    type Component =
        { /// The doc lines for the component, without leading ///.
          DocLines: string list
          /// The name used for the component overloads.
          MethodName: string
          /// The path the component will be imported from.
          ImportSelector: string option
          /// The overloads used to create the component.
          Overloads: ComponentOverload list
          /// The component's props.
          Props: Prop list
          /// The list of parent components
          ParentNameTree: string list }

    module Component =
        /// Creates a component with the specified method name and import path, no
        /// documentation, import selector, or props, and the default component
        /// overload.
        let create methodName =
            { DocLines = []
              MethodName = methodName
              ImportSelector = None
              Overloads = ComponentOverload.defaults
              Props = []
              ParentNameTree = [] }

        /// Sets the import selector of the component.
        let setImportSelector selector comp = { comp with ImportSelector = Some selector }

        /// Sets the component's doc lines.
        let setDocs docLines (comp: Component) = { comp with DocLines = docLines }

        /// Adds the specified overload to the component.
        let addOverload overload comp = { comp with Overloads = comp.Overloads @ [ overload ] }

        /// Adds the specified prop to the component.
        let addProp prop comp = { comp with Props = comp.Props @ [ prop ] }

        /// Indicates whether all components have only inline overloads.
        let hasOnlyInlineOverloads comp = comp.Overloads |> List.forall (fun o -> o.IsInline)

        /// Add a component tree list
        let addParentComponentTree (tree: string list) (comp: Component) =
            { comp with ParentNameTree = comp.ParentNameTree @ (tree |> List.map String.upperFirst) }

    type ComponentApi =
        { /// The namespace for the API.
          Namespace: string
          /// Lines to insert before the component definitions.
          ComponentsPrelude: string list
          /// Lines to insert before the prop definitions.
          PropsPrelude: string list
          /// The name of the module the types are placed under.
          ComponentContainerName: string
          /// The type the component methods will be placed in.
          ComponentContainerTypeName: string
          /// All components in the API.
          Components: Component list
          /// Bindings for the API.
          Bindings: (string * string) list
          /// Lines to insert after the component definitions.
          TypePostlude: (string * string) list }

    module ComponentApi =
        /// Creates a component API with the specified namespace and component type
        /// name and no components.
        let create namespace' typeName containerName bindings typePostlude =
            { Namespace = namespace'
              ComponentsPrelude = []
              PropsPrelude = []
              ComponentContainerName = containerName
              ComponentContainerTypeName = typeName
              Components = []
              Bindings = bindings
              TypePostlude = typePostlude }

        /// Adds the specified component to the API.
        let addComponent component' api: ComponentApi = { api with Components = api.Components @ [ component' ] }

        /// Adds the specified components prelude to the API.
        let setComponentsPrelude lines api = { api with ComponentsPrelude = lines }

        /// Adds the specified props prelude to the API.
        let setPropsPrelude lines api = { api with PropsPrelude = lines }

    type PlotlyComponentApi =
        { GeneratorComponentApi: ComponentApi
          PlotlyComponents: Component list }
