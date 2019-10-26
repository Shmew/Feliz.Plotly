namespace Fable.Plotly.Generator

module rec Domain =
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

    [<RequireQualifiedAccess>]
    type ValType =
        | Any
        | Bool of bool
        | ColorArray
        | DataArray
        | Enumerated
        | EnumeratedArray
        | EnumeratedWithCustom
        | FlagList
        | InfoArray of ValType
        | Int of bool
        | List of ValType
        | Number of bool
        | NumList of ValType
        | String of bool
        | Component

    module ValType =
        open FSharp.Data
        open FSharp.Data.JsonExtensions

        let boolStr = "(value: bool)", "value"
        let boolSeqStr = "(values: seq<bool>)", "(values |> Array.ofSeq)"
        let stringStr = "(value: string)", "value"
        let stringSeqStr = "(values: seq<string>)", "(values |> Array.ofSeq)"
        let intStr = "(value: int)", "value"
        let intSeqStr = "(values: seq<int>)", "(values |> Array.ofSeq)"
        let floatStr = "(value: float)", "value"
        let floatSeqStr = "(values: seq<float>)", "(values |> Array.ofSeq)"
        let compStr s = sprintf "(properties: #I%sProperty list)" s, "(createObj !!properties)"

        let getPrimativeOverloadSeq =
            function
            | ValType.Bool _ -> [ boolSeqStr ]
            | ValType.Int _ -> [ intSeqStr ]
            | ValType.Number _ -> [ intSeqStr; floatSeqStr ]
            | ValType.String _ -> [ stringSeqStr ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedWithCustom -> []
            | ValType.FlagList -> []
            | ValType.Any -> [ boolSeqStr; intSeqStr; floatSeqStr; stringSeqStr ]
            | s ->
                printfn "%s" (s.ToString())
                [ "(value: TODO)", "value" ]

        /// Extracts the type of the prop recursively
        let rec getType propName (jVal: JsonValue) =
            let hasValType = jVal.TryGetProperty("valType").IsSome

            let isEnumeratedWithCustom() =
                jVal?values.AsArray()
                |> Array.filter (fun s -> s.AsString() |> String.containsRegex)
                |> Array.length > 0

            let isArrayOk =
                match jVal.TryGetProperty("arrayOk") with
                | Some arrOk -> arrOk.AsBoolean()
                | None -> false

            let isNumArrayOk =
                match jVal.TryGetProperty("description") with
                | Some desc when desc.AsString().Contains("array of numbers") -> true
                | _ -> false

            match propName, hasValType with
            | "scaleanchor", true -> ValType.String isArrayOk
            | "matches", true when jVal?valType.AsString() = "enumerated" -> ValType.String isArrayOk
            | _, true ->
                match jVal?valType
                      |> JsonValue.asString
                      |> fun s -> s.Trim('"') with
                | "angle" -> ValType.Number isArrayOk
                | "any" -> ValType.Any
                | "boolean" -> ValType.Bool isArrayOk
                | "color" -> 
                    match isArrayOk && isNumArrayOk with
                    | true -> ValType.ColorArray
                    | false -> ValType.String isArrayOk
                | "colorlist" -> ValType.String false |> ValType.List 
                | "colorscale" -> ValType.String false |> ValType.List
                | "data_array" -> ValType.DataArray
                | "flaglist" -> ValType.FlagList
                | "info_array" ->
                    if jVal?items.AsArray().Length < 1 then jVal?items
                    else jVal?items.AsArray().[0]
                    |> getType propName
                    |> ValType.InfoArray
                | "integer" -> ValType.Int isArrayOk
                | "number" -> ValType.Number isArrayOk
                | "string" -> ValType.String isArrayOk
                | "subplotid" -> ValType.String false |> ValType.List 
                | "enumerated" when isEnumeratedWithCustom() -> 
                    ValType.EnumeratedWithCustom
                | "enumerated" -> 
                    if isArrayOk then ValType.EnumeratedArray
                    else ValType.Enumerated
                | _ -> ValType.Any
            | _ -> ValType.Component

        /// Returns a list of primative overloads for the `ValType`
        let getOverloadStrings (compName: string) (vType: ValType) =
            match vType with
            | ValType.Any -> [ boolStr; boolSeqStr; stringStr; stringSeqStr; intStr; intSeqStr; floatStr; floatSeqStr ]
            | ValType.Bool b -> [ boolStr; if b then boolSeqStr ]
            | ValType.ColorArray -> [ stringStr; stringSeqStr; intSeqStr; floatSeqStr ]
            | ValType.DataArray -> [ boolSeqStr; stringSeqStr; intSeqStr; floatSeqStr ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedArray -> []
            | ValType.EnumeratedWithCustom -> []
            | ValType.FlagList -> []
            | ValType.InfoArray vt ->
                match vt with
                | ValType.List vtPrim -> vtPrim
                | _ -> vt
                |> getPrimativeOverloadSeq
            | ValType.Int b -> [ intStr; if b then intSeqStr ]
            | ValType.List vt -> getPrimativeOverloadSeq vt
            | ValType.Number b -> [ intStr; floatStr; if b then yield! [intSeqStr; floatSeqStr] ]
            | ValType.NumList vt -> getPrimativeOverloadSeq vt
            | ValType.String b -> [ stringStr; if b then stringSeqStr ]
            | ValType.Component -> [ compStr compName ]

        let isPrimative (vType: ValType) =
            match vType with
            | ValType.Enumerated
            | ValType.EnumeratedArray
            | ValType.EnumeratedWithCustom
            | ValType.FlagList
            | ValType.Component -> false
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
