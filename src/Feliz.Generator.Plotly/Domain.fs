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
          /// Components within the prop
          Components: Component list
          ParentComponentName: string }

    module Prop =
        /// Creates a prop with the specified native API name and method name and no
        /// docs or overloads.
        let create realPropName methodName =
            { DocLines = []
              RealPropName = realPropName
              MethodName = methodName
              RegularOverloads = []
              EnumOverloads = []
              Components = []
              ParentComponentName = "Plot" }

        /// Sets the prop's doc lines.
        let setDocs docLines (prop: Prop) = { prop with DocLines = docLines }

        /// Adds the specified regular (non-enum) overload to the prop.
        let addRegularOverload overload prop = { prop with RegularOverloads = prop.RegularOverloads @ [ overload ] }

        /// Adds the specified enum value/overload to the prop.
        let addEnumOverload overload prop = { prop with EnumOverloads = prop.EnumOverloads @ [ overload ] }

        let addComponent comp (prop: Prop) = { prop with Components = prop.Components @ [ comp ] }

        let addParentComponentName (name: string) (prop: Prop) = { prop with ParentComponentName = (name |> String.upperFirst) }

        /// Indicates whether all regular prop overloads are inline.
        let allRegularOverloadsAreInline prop = prop.RegularOverloads |> List.forall (fun o -> o.IsInline)

    type ComponentOverload =
        { /// The code for the method parameters, e.g. `props` or `(text: string)`.
          ParamsCode: string
          /// The expression for the props passed to the created element, e.g. `props`
          /// or `[ prop.children (Html.text text) ]`.
          PropsCode: string
          /// Whether the member is inline.
          IsInline: bool }

    module ComponentOverload =
        /// A default overload that accepts and passes a list of props.
        let defaults name =
            [ { ParamsCode = sprintf "(properties: #I%sProperty list)" (name |> String.upperFirst)
                PropsCode = "(createObj !!properties)"
                IsInline = true }
              { ParamsCode = sprintf "(properties: (bool * I%sProperty list) list)" (name |> String.upperFirst)
                PropsCode = "(properties |> Bindings.Internal.withConditionals)"
                IsInline = false  } ]

        /// Creates an inline component overload with the specified code for params
        /// and props expression.
        let create paramsCode propsCode =
            { ParamsCode = paramsCode
              PropsCode = propsCode
              IsInline = true }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: ComponentOverload) = { overload with IsInline = isInline }

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
          ParentComponentName: string }

    module Component =
        /// Creates a component with the specified method name and import path, no
        /// documentation, import selector, or props, and the default component
        /// overload.
        let create methodName =
            { DocLines = []
              MethodName = methodName
              ImportSelector = None
              Overloads = ComponentOverload.defaults methodName
              Props = []
              ParentComponentName = "Plot" }

        /// Sets the import selector of the component.
        let setImportSelector selector comp = { comp with ImportSelector = Some selector }

        /// Sets the component's doc lines.
        let setDocs docLines (comp: Component) = { comp with DocLines = docLines }

        /// Adds the specified overload to the component.
        let addOverload overload comp = { comp with Overloads = comp.Overloads @ [ overload ] }

        /// Removes the default overload that accepts a list of props.
        let removeDefaultOverload comp =
            { comp with Overloads = comp.Overloads |> List.except (ComponentOverload.defaults comp.MethodName) }

        /// Adds the specified prop to the component.
        let addProp prop comp = { comp with Props = comp.Props @ [ prop ] }

        /// Indicates whether all components have only inline overloads.
        let hasOnlyInlineOverloads comp = comp.Overloads |> List.forall (fun o -> o.IsInline)

        let addParentComponentName (name: string) (comp: Component) = { comp with ParentComponentName = (name |> String.upperFirst) }

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
