namespace Fable.Plotly.Generator

module rec Domain =
    open FSharp.Data
    open FSharp.Data.JsonExtensions

    type PrimSpecs =
        { ArrayOk: bool
          Explicit: (string * string) list
          Identity: ValType option
          IsCalcType: bool
          NullOk: bool
          NumArrayOk: bool
          TwoDimArrayOk: bool }

    type PrimSpecOverrides =
        { ArrayOk: bool * bool
          Explicit: (string * string) list
          Identity: ValType option
          IsCalcType: bool * bool
          NullOk: bool * bool
          NumArrayOk: bool * bool
          TwoDimArrayOk: bool * bool }

    module PrimSpecs =
        let create (jVal: JsonValue): PrimSpecs =
            let isArrayOk =
                match jVal.TryGetProperty("arrayOk") with
                | Some arrOk -> arrOk.AsBoolean()
                | None -> false

            { ArrayOk = isArrayOk
              Explicit = []
              Identity = None
              IsCalcType =
                  let editType =
                      jVal.TryGetProperty("editType")
                      |> Option.map (JsonExtensions.AsString >> (fun s -> s.Contains("calc")))
                      |> Option.defaultValue false

                  let role =
                      jVal.TryGetProperty("role")
                      |> Option.map (JsonExtensions.AsString >> (fun s -> s.Contains("data")))
                      |> Option.defaultValue false

                  editType && role
              NullOk =
                  match jVal.TryGetProperty("role") with
                  | Some role when role
                                   |> JsonExtensions.AsString = "data" -> true
                  | _ -> false
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
                      false }

        let allFalse: PrimSpecs =
            { ArrayOk = false
              Explicit = []
              Identity = None
              IsCalcType = false
              NullOk = false
              NumArrayOk = false
              TwoDimArrayOk = false }

        let applyOverride (overrides: PrimSpecOverrides) (baseSpecs: PrimSpecs) =
            { baseSpecs with
                  ArrayOk =
                      match overrides.ArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.ArrayOk
                  Explicit = overrides.Explicit
                  IsCalcType =
                      match overrides.IsCalcType with
                      | true, b -> b
                      | false, _ -> baseSpecs.IsCalcType
                  NullOk =
                      match overrides.NullOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.NullOk
                  NumArrayOk =
                      match overrides.NumArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.NumArrayOk
                  TwoDimArrayOk =
                      match overrides.TwoDimArrayOk with
                      | true, b -> b
                      | false, _ -> baseSpecs.TwoDimArrayOk }

    module PrimSpecOverrides =
        let empty: PrimSpecOverrides =
            { ArrayOk = false, false
              Explicit = []
              Identity = None
              IsCalcType = false, false
              NullOk = false, false
              NumArrayOk = false, false
              TwoDimArrayOk = false, false }

    [<RequireQualifiedAccess>]
    type ValType =
        | Any
        | Bool of PrimSpecs
        | Bounds
        | Color of PrimSpecs
        | ColorArray
        | ColorScale
        | Component of syntaxSugar: (string * string) list
        | ComponentArray
        | DataArray of PrimSpecs
        | Enumerated
        | EnumeratedArray
        | EnumeratedWithCustom
        | ExplicitOverride of PrimSpecs
        | FlagList
        | FloatArray
        | InfoArray of ValType
        | Int of PrimSpecs
        | List of ValType
        | Locales
        | Measure
        | ModeBarButtons
        | ModeBarButtonsInherited
        | Number of PrimSpecs
        | String of PrimSpecs
        | StringArray
        | Template
        | ToImageButtonOptions
        | TransformTarget

    module ValType =
        let boolStr = "(value: bool)", "value"
        let boolResizeSingleton = "(value: bool)", "(value |> Array.singleton |> ResizeArray)"
        let boolSeqStr = "(values: seq<bool>)", "(values |> ResizeArray)"
        let boolSeqStrOpt = "(values: seq<bool option>)", "(values |> ResizeArray)"
        let boolSingleton = "(value: bool)", "(value |> Array.singleton)"
        let bool2DSeqStr = "(values: seq<seq<bool>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let bool2DSeqStrOpt =
            "(values: seq<seq<bool option>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let bool2DListStr =
            "(values: seq<bool list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let bool2DListStrOpt =
            "(values: seq<bool option list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let bool2DArrayStr = "(values: seq<bool []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let bool2DArrayStrOpt = "(values: seq<bool option []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"

        let compArray s = sprintf "(properties: #I%sProperty list)" s, "(properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)"
        let compStr s = sprintf "(properties: #I%sProperty list)" s, "(createObj !!properties)"
        let compStrExplicit s = sprintf "(properties: I%sProperty list)" s, "(createObj !!properties)"
        let compStrExplicitExpanded s = sprintf "(id: int, properties: I%sProperty list)" s, "(createObj !!properties)"

        let data2D = "(values: seq<PlotData>)", "(values |> Seq.map PlotData.asDataResize |> ResizeArray)"

        let dateStr = "(value: System.DateTime)", "value"
        let dateResizeSingleton = "(value: System.DateTime)", "(value |> Array.singleton |> ResizeArray)"
        let dateSeqStr = "(values: seq<System.DateTime>)", "(values |> ResizeArray)"
        let dateSeqStrOpt = "(values: seq<System.DateTime option>)", "(values |> ResizeArray)"
        let dateSingleton = "(value: System.DateTime)", "(value |> Array.singleton)"

        let dateOffsetStr = "(value: System.DateTimeOffset)", "value"
        let dateOffsetResizeSingleton = "(value: System.DateTimeOffset)", "(value |> Array.singleton |> ResizeArray)"
        let dateOffsetSeqStr = "(values: seq<System.DateTimeOffset>)", "(values |> ResizeArray)"
        let dateOffsetSeqStrOpt = "(values: seq<System.DateTimeOffset option>)", "(values |> ResizeArray)"
        let dateOffsetSingleton = "(value: System.DateTimeOffset)", "(value |> Array.singleton)"

        let dayOfWeekSeqStr = "(days: seq<System.DayOfWeek>)", "(unbox<seq<int>> days)"
        let dayOfWeekSeqStrOptNull = "(days: seq<System.DayOfWeek option>)", "(unbox<seq<int option>> days |> Seq.map (Option.defaultValue (unbox<int> null)) |> ResizeArray)"

        let enumeratedArrayStrSeq s =
            sprintf "(properties: #I%sProperty list)" s,
            "(properties |> List.map (Bindings.getKV >> snd) |> ResizeArray)"

        let flaglistStrSeq s =
            sprintf "(properties: #I%sProperty list)" s,
            "(properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat \"+\")"

        let floatStr = "(value: float)", "value"
        let floatResizeSingleton = "(value: float)", "(value |> Array.singleton |> ResizeArray)"
        let floatSeqStr = "(values: seq<float>)", "(values |> ResizeArray)"
        let floatSeqStrOpt = "(values: seq<float option>)", "(values |> ResizeArray)"
        let floatSeqStrOptNull = "(values: seq<float option>)", "(values |> Seq.map (Option.defaultValue (unbox<float> null)) |> ResizeArray)"
        let floatSingleton = "(value: float)", "(value |> Array.singleton)"
        let float32FromFloatSeqStr = "(values: seq<float>)", "(values |> Seq.map float32 |> Array.ofSeq)"
        let float32FromFloatSeqStrOpt =
            "(values: seq<float option>)", "(values |> Seq.map (Option.map float32) |> Array.ofSeq)"
        let float32FromIntSeqStr = "(values: seq<int>)", "(values |> Seq.map float32 |> Array.ofSeq)"
        let float32FromIntSeqStrOpt =
            "(values: seq<int option>)", "(values |> Seq.map (Option.map float32) |> Array.ofSeq)"
        let float2DSeqStr =
            "(values: seq<seq<float>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let float2DSeqStrOpt =
            "(values: seq<seq<float option>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let float2DListStr =
            "(values: seq<float list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let float2DListStrOpt =
            "(values: seq<float option list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let float2DArrayStr = "(values: seq<float []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let float2DArrayStrOpt = "(values: seq<float option []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"

        let intStr = "(value: int)", "value"
        let intStrCustom s f = sprintf "(%s: int)" s, sprintf "%s" f
        let intSeqStrCustom s f = sprintf "(%s: seq<int>)" s, sprintf "%s" f
        let intResizeSingleton = "(value: int)", "(value |> Array.singleton |> ResizeArray)"
        let intSeqStr = "(values: seq<int>)", "(values |> ResizeArray)"
        let intSeqStrOpt = "(values: seq<int option>)", "(values |> ResizeArray)"
        let intSeqStrOptNull = "(values: seq<int option>)", "(values |> Seq.map (Option.defaultValue (unbox<int> null)) |> ResizeArray)"
        let intSingleton = "(value: int)", "(value |> Array.singleton)"
        let int2DSeqStr = "(values: seq<seq<int>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let int2DSeqStrOpt =
            "(values: seq<seq<int option>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let int2DListStr = "(values: seq<int list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let int2DListStrOpt =
            "(values: seq<int option list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let int2DArrayStr = "(values: seq<int []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let int2DArrayStrOpt = "(values: seq<int option []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"

        let locales = [ "(locales: ILocalesProperty list)", "(createObj !!locales)" ]

        let measure = [ "(values: #IMeasureProperty list)", "(values |> ResizeArray)" ]

        let modeBarButtons =
            [ "(value: #IModeBarButtonsProperty)", "(value |> Array.singleton)"
              "(values: #IModeBarButtonsProperty list)", "(values |> ResizeArray)" ]

        let modeBarButtonsInherited =
            [ "(value: IButtonsProperty)", "(unbox<IModeBarButtonsProperty> value |> Array.singleton |> Array.singleton)"
              "(value: IModeBarButtonsProperty)", "(value |> Array.singleton |> Array.singleton)"
              "(values: IModeBarButtonsProperty list)", "(values |> ResizeArray |> Array.singleton)"
              "(values: IButtonsProperty list)", "(values |> Seq.map unbox<IModeBarButtonsProperty> |> ResizeArray |> Array.singleton)"
              "(values: seq<#IModeBarButtonsProperty> list)", "(values |> Seq.map ResizeArray |> ResizeArray)" ]

        let stringStr = "(value: string)", "value"
        let stringResizeSingleton = "(value: string)", "(value |> Array.singleton |> ResizeArray)"
        let stringSeqStr = "(values: seq<string>)", "(values |> ResizeArray)"
        let stringSeqStrOpt = "(values: seq<string option>)", "(values |> ResizeArray)"
        let stringSeqStrOptNull = "(values: seq<string option>)", "(values |> Seq.map (Option.defaultValue null) |> ResizeArray)"
        let stringSingleton = "(value: string)", "(value |> Array.singleton)"
        let string2DSeqStr =
            "(values: seq<seq<string>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let string2DSeqStrOpt =
            "(values: seq<seq<string option>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let string2DListStr =
            "(values: seq<string list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let string2DListStrOpt =
            "(values: seq<string option list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let string2DArrayStr = "(values: seq<string []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
        let string2DArrayStrOpt = "(values: seq<string option []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"

        let template = [ "(properties: #ITemplateProperty list)", "(createObj !!properties)" ]

        let titleStr = [ "(value: string)", "(createObj !!((Interop.mkTitleAttr \"text\" value) |> Array.singleton))" ]

        let toImageButtonOptions = [ "(properties: IToImageButtonOptionsProperty list)", "(createObj !!properties)" ]

        let transformTargetStrs = [
            "(value: string)", "value"
            "(values: seq<string>)", "(values |> ResizeArray)"
            "(values: seq<string option>)", "(values |> Seq.map Bindings.optToString |> ResizeArray)"
            "(values: seq<seq<string>>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
            "(values: seq<seq<string option>>)", "(values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<string list>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
            "(values: seq<string option list>)", "(values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<string []>)", "(values |> Seq.map ResizeArray |> ResizeArray)"
            "(values: seq<string option []>)", "(values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)"

            "(values: seq<int>)", "(values |> Seq.map string |> ResizeArray)"
            "(values: seq<int option>)", "(values |> Seq.map Bindings.optToString |> ResizeArray)"
            "(values: seq<seq<int>>)", "(values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<seq<int option>>)", "(values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<int list>)", "(values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<int option list>)", "(values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<int []>)", "(values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<int option []>)", "(values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)"

            "(values: seq<float>)", "(values |> Seq.map string |> ResizeArray)"
            "(values: seq<float option>)", "(values |> Seq.map Bindings.optToString |> ResizeArray)"
            "(values: seq<seq<float>>)", "(values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<seq<float option>>)", "(values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<float list>)", "(values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<float option list>)", "(values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<float []>)", "(values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<float option []>)", "(values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)"

            "(values: seq<System.DateTime>)", "(values |> Seq.map string |> ResizeArray)"
            "(values: seq<System.DateTime option>)", "(values |> Seq.map Bindings.optToString |> ResizeArray)"

            "(values: seq<bool>)", "(values |> Seq.map string |> ResizeArray)"
            "(values: seq<bool option>)", "(values |> Seq.map Bindings.optToString |> ResizeArray)"
            "(values: seq<seq<bool>>)", "(values |> Seq.map (Seq.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<seq<bool option>>)", "(values |> Seq.map (Seq.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<bool list>)", "(values |> Seq.map (List.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<bool option list>)", "(values |> Seq.map (List.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
            "(values: seq<bool []>)", "(values |> Seq.map (Array.map string >> ResizeArray) |> ResizeArray)"
            "(values: seq<bool option []>)", "(values |> Seq.map (Array.map Bindings.optToString >> ResizeArray) |> ResizeArray)"
        ]

        let allNormalStrs =
            [ boolStr; boolSeqStr; dateStr; dateOffsetStr; dateSeqStr; dateOffsetSeqStr; intStr; intSeqStr; floatStr; floatSeqStr; stringStr; stringSeqStr ]

        let allNormalOptStrs = [ boolSeqStrOpt; dateSeqStrOpt; dateOffsetSeqStrOpt; intSeqStrOpt; floatSeqStrOpt; stringSeqStrOpt ]

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

        let all2DStrs = all2DStrsNoUnions @ [ data2D ]

        let allBoolArrStrs = [ boolSingleton; boolSeqStr ]
        let allBoolArrResizeStrs = [ boolResizeSingleton; boolSeqStr ]

        let allDateArrStrs = [ dateSingleton; dateOffsetSingleton; dateSeqStr; dateOffsetSeqStr ]
        let allDateArrResizeStrs = [ dateResizeSingleton; dateOffsetResizeSingleton; dateSeqStr; dateOffsetSeqStr ]

        let allFloatArrStrs = [ floatSingleton; floatSeqStr ]
        let allFloatArrResizeStrs = [ floatResizeSingleton; floatSeqStr ]

        let allIntArrStrs = [ intSingleton; intSeqStr ]
        let allIntArrResizeStrs = [ intResizeSingleton; intSeqStr ]

        let allStringArrStrs = [ stringSingleton; stringSeqStr ]
        let allStringArrResizeStrs = [ stringResizeSingleton; stringSeqStr ]

        let allArrStrs =
            allBoolArrStrs
            @ allDateArrStrs
            @ allFloatArrStrs
            @ allIntArrStrs
            @ allStringArrStrs

        let allArrResizeStrs =
            allBoolArrResizeStrs
            @ allDateArrResizeStrs
            @ allFloatArrResizeStrs
            @ allIntArrResizeStrs
            @ allStringArrResizeStrs

        let allArrResizeOptStrs =
            [ boolSeqStrOpt; dateSeqStrOpt; dateOffsetSeqStrOpt; intSeqStrOpt; floatSeqStrOpt; stringSeqStrOpt ]

        let getPrimativeOverloadSeq =
            function
            | ValType.Any -> allArrResizeStrs
            | ValType.Bool _ -> allBoolArrResizeStrs
            | ValType.ColorScale -> [ stringStr; yield! allStr2DStrs ]
            | ValType.Enumerated -> []
            | ValType.EnumeratedWithCustom -> []
            | ValType.FlagList -> []
            | ValType.Int _ -> allIntArrResizeStrs
            | ValType.Number _ -> allIntArrResizeStrs @ allFloatArrResizeStrs
            | ValType.String _ -> allStringArrResizeStrs
            | s ->
                printfn "%s" (s.ToString())
                [ "(value: TODO)", "value" ]

        /// Extracts the type of the prop
        let rec getType propName attribOverrides (jVal: JsonValue) =
            let hasValType = jVal.TryGetProperty("valType").IsSome

            let isEnumeratedWithCustom() =
                jVal?values.AsArray()
                |> Array.filter (fun s -> s.AsString() |> String.containsRegex)
                |> Array.length > 0

            let attributes = PrimSpecs.create jVal |> PrimSpecs.applyOverride attribOverrides

            match propName, hasValType with
            | _ when attributes.Explicit.IsEmpty |> not ->
                ValType.ExplicitOverride
                    { attributes with Identity = Some <| getType propName { attribOverrides with Explicit = [] } jVal }
            | "bounds", true when jVal?valType.AsString() = "info_array" -> ValType.Bounds
            | "layers", false when jVal?role.AsString() = "object" -> ValType.ComponentArray
            | "locales", true when jVal?valType.AsString() = "any" -> ValType.Locales
            | "matches", true when jVal?valType.AsString() = "enumerated" -> ValType.String attributes
            | "measure", true when jVal?valType.AsString() = "data_array" -> ValType.Measure
            | "modeBarButtons", true -> ValType.ModeBarButtonsInherited
            | "modeBarButtonsToAdd", true -> ValType.ModeBarButtons
            | "modeBarButtonsToRemove", true -> ValType.ModeBarButtons
            | "source", true when jVal?valType.AsString() = "any" -> ValType.StringArray
            | "target", true when jVal?valType.AsString() = "string" -> ValType.TransformTarget
            | "template", true -> ValType.Template
            | "toImageButtonOptions", true -> ValType.ToImageButtonOptions
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
                | "data_array" -> ValType.DataArray attributes
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
                | "string" when jVal.TryGetProperty("values").IsSome -> ValType.EnumeratedWithCustom
                | "string" -> ValType.String attributes
                | "subplotid" -> ValType.String attributes
                | _ -> ValType.Any
            | "title", _ -> ValType.Component titleStr
            | _ -> ValType.Component []

        /// Returns a list of primative overloads for the `ValType`
        let rec getOverloadStrings (parentName: string) (compName: string) (vType: ValType) =
            match vType with
            | ValType.Any -> allNormalStrs
            | ValType.Bool attrib ->
                [ boolStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          boolSeqStr
                      else
                          boolSeqStr
                          if attrib.TwoDimArrayOk then yield! allBool2DStrs ]
            | ValType.Bounds ->
                [ stringSeqStr; floatSeqStr; intSeqStr; dayOfWeekSeqStr
                  stringSeqStrOptNull; floatSeqStrOptNull; intSeqStrOptNull; dayOfWeekSeqStrOptNull ]
            | ValType.Color attrib ->
                [ stringStr
                  if attrib.IsCalcType then
                      stringSeqStr
                  else
                      stringSeqStr
                      intSeqStr
                      floatSeqStr
                      if attrib.TwoDimArrayOk then yield! allStr2DStrs ]
            | ValType.ColorArray -> [ stringStr; stringSeqStr; intSingleton; intSeqStr; floatSingleton; floatSeqStr ]
            | ValType.ColorScale -> [ stringStr; yield! allStr2DStrs ]
            | ValType.Component sugar -> [ compStr compName; yield! sugar ]
            | ValType.ComponentArray -> [ compArray compName ]
            | ValType.DataArray attrib ->
                if attrib.IsCalcType then allArrStrs @ all2DStrs @ allArrResizeOptStrs
                else allArrResizeStrs @ all2DStrs @ allArrResizeOptStrs
            | ValType.Enumerated -> []
            | ValType.EnumeratedArray -> [ enumeratedArrayStrSeq parentName ]
            | ValType.EnumeratedWithCustom -> []
            | ValType.ExplicitOverride attrib ->
                match attrib.Identity with
                | Some propIdentity -> getOverloadStrings parentName compName propIdentity
                | _ -> []
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
                          intSeqStr
                          if attrib.TwoDimArrayOk then yield! allInt2DStrs ]
            | ValType.List vt -> getPrimativeOverloadSeq vt
            | ValType.Locales -> locales
            | ValType.Measure -> measure
            | ValType.ModeBarButtons -> modeBarButtons
            | ValType.ModeBarButtonsInherited -> modeBarButtonsInherited
            | ValType.Number attrib ->
                [ intStr
                  floatStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          yield! [ intSeqStr; floatSeqStr ]
                      else
                          yield! [ intSeqStr; floatSeqStr ]
                          if attrib.TwoDimArrayOk then
                              yield! [ yield! allInt2DStrs
                                       yield! allFloat2DStrs ] ]
            | ValType.String attrib ->
                [ stringStr
                  if attrib.ArrayOk then
                      if attrib.IsCalcType then
                          stringSeqStr
                      else
                          stringSeqStr
                          if attrib.TwoDimArrayOk then yield! allStr2DStrs ]
            | ValType.StringArray ->
                [ stringSingleton; stringSeqStr ]
            | ValType.Template -> template
            | ValType.ToImageButtonOptions -> toImageButtonOptions
            | ValType.TransformTarget -> transformTargetStrs

        /// Returns a list of primative overloads for explicit overrides if any are present
        let getExplicitOverloadStrings (vType: ValType) =
            match vType with
            | ValType.ExplicitOverride attrib -> attrib.Explicit
            | _ -> []

        let rec isPrimative (vType: ValType) =
            match vType with
            | ValType.ExplicitOverride attrib ->
                match attrib.Identity with
                | Some vt -> isPrimative vt
                | _ -> false
            | ValType.Component _
            | ValType.Enumerated
            | ValType.EnumeratedArray
            | ValType.EnumeratedWithCustom
            | ValType.FlagList -> false
            | _ -> true

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

    [<RequireQualifiedAccess>]
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

    [<RequireQualifiedAccess>]
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

        /// Creates an EnumPropOverload with the Value and ParamsCode from ValType.stringStr.
        let createStr methodName =
            let paramsCode, valueCode = ValType.stringStr
            create methodName valueCode
            |> setParamsCode paramsCode

    type CustomPropOverload =
        { /// The doc lines for the enum prop's value/overload, without leading ///.
          DocLines: string list
          /// The name of the enum prop's value/overload.
          MethodName: string
          /// The code for the method parameters, e.g. `(value: string)`.
          ParamsCode: string
          /// The code for the prop value.
          BodyCode: string
          /// Whether the member is inline.
          IsInline: bool }

    [<RequireQualifiedAccess>]
    module CustomPropOverload =
        /// Creates an inline prop overload with the specified code for params and
        /// value expression, implemented as a regular (non-extension) member.
        let create methodName paramsCode bodyCode =
            { DocLines = []
              MethodName = methodName
              ParamsCode = paramsCode
              BodyCode = bodyCode
              IsInline = true }

        /// Sets the doc lines of the enum prop value/overload.
        let setDocs docLines (overload: CustomPropOverload) = { overload with DocLines = docLines }

        /// Sets whether the overload is inline.
        let setInline isInline (overload: CustomPropOverload) = { overload with IsInline = isInline }

        /// Sets the params code for the enum prop value/overload.
        let setParamsCode code (overload: CustomPropOverload) = { overload with ParamsCode = code }

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
          /// Custom prop overloads that are placed in the sub module for the component.
          CustomOverloads: CustomPropOverload list
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
              CustomOverloads = []
              ParentNameTree = []
              PropType = propType }

        /// Sets the prop's doc lines.
        let setDocs docLines (prop: Prop) = { prop with DocLines = docLines }

        /// Adds the specified regular (non-enum) overload to the prop.
        let addRegularOverload overload prop = { prop with RegularOverloads = prop.RegularOverloads @ [ overload ] }

        /// Adds the specified enum value/overload to the prop.
        let addEnumOverload overload prop = { prop with EnumOverloads = prop.EnumOverloads @ [ overload ] }

        /// Adds the specified custom sub module prop overload.
        let addCustomOverload overload prop = { prop with CustomOverloads = prop.CustomOverloads @ [ overload ] }

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

    [<RequireQualifiedAccess>]
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

    [<RequireQualifiedAccess>]
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

    /// Types that only contain properties, such as enums.
    type CustomPropertyType =
        { ActualName: string
          Name: string
          Enums: EnumPropOverload list
          Properties: string list
          Functions: (string * string) list
          Children: CustomPropertyType list
          ParentNameTree: string list
          ParentActualNameTree: string list }

    [<RequireQualifiedAccess>]
    module CustomPropertyType =
        /// Creates a custom property type with the given name.
        let create name =
            { ActualName = name
              Name = name
              Enums = []
              Properties = []
              Functions = []
              Children = []
              ParentNameTree = []
              ParentActualNameTree = [] }

        let addChildren (children: CustomPropertyType list) (cusProp: CustomPropertyType) =
            cusProp
            |> List.foldBack (fun child state ->
                { state with
                    Children =
                        state.Children @ [
                            { child with
                                ParentNameTree = child.ParentNameTree @ [ state.Name ]
                                ParentActualNameTree = child.ParentActualNameTree @ [ state.ActualName ] }
                        ] }
            ) children

        let addEnums (enums: EnumPropOverload list) (cusProp: CustomPropertyType) =
            { cusProp with Enums = cusProp.Enums @ enums }

        let addFunctions (funcs: (string * string) list) (cusProp: CustomPropertyType) =
            { cusProp with Functions = cusProp.Functions @ funcs }

        let addProperties (props: string list) (cusProp: CustomPropertyType) =
            { cusProp with Properties = cusProp.Properties @ props }

        let setActualName (name: string) (cusProp: CustomPropertyType) =
            { cusProp with ActualName = name }

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
          BindingsPrelude: (string * string) list
          Bindings: (string * string) list
          TypePrelude: (string * string) list
          /// Lines to insert after the component definitions.
          TypePostlude: (string * string) list
          /// Types to insert after the Types file that only contain properties
          CustomPropertyTypes: CustomPropertyType list }

    [<RequireQualifiedAccess>]
    module ComponentApi =
        /// Creates a component API with the specified namespace and component type
        /// name and no components.
        let create namespace' typeName containerName bindingsPrelude bindings typePrelude typesPostlude =
            { Namespace = namespace'
              ComponentsPrelude = []
              PropsPrelude = []
              ComponentContainerName = containerName
              ComponentContainerTypeName = typeName
              Components = []
              BindingsPrelude = bindingsPrelude
              Bindings = bindings
              TypePrelude = typePrelude
              TypePostlude = typesPostlude
              CustomPropertyTypes = [] }

        /// Adds the specified component to the API.
        let addComponent component' api: ComponentApi = { api with Components = api.Components @ [ component' ] }

        /// Adds the specified components prelude to the API.
        let setComponentsPrelude lines api = { api with ComponentsPrelude = lines }

        /// Adds the specified props prelude to the API.
        let setPropsPrelude lines api = { api with PropsPrelude = lines }

        /// Adds the specified CustomPropertyTypes
        let addCustomPropertyTypes customPropertyTypes api = { api with CustomPropertyTypes = customPropertyTypes }

    type PlotlyComponentApi =
        { GeneratorComponentApi: ComponentApi
          PlotlyComponents: Component list }
