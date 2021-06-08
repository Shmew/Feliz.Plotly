namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type config =
    /// Determines whether the graphs are plotted with respect to layout.autosize:true and infer its container size.
    static member inline autosizable (value: bool) = Interop.mkConfigAttr "autosizable" value
    /// Determines whether or not the plotly logo is displayed on the end of the mode bar.
    static member inline displaylogo (value: bool) = Interop.mkConfigAttr "displaylogo" value
    /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
    static member inline doubleClickDelay (value: int) = Interop.mkConfigAttr "doubleClickDelay" value
    /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
    static member inline doubleClickDelay (value: float) = Interop.mkConfigAttr "doubleClickDelay" value
    /// Determines whether the graph is editable or not. Sets all pieces of `edits` unless a separate `edits` config item overrides individual parts.
    static member inline editable (value: bool) = Interop.mkConfigAttr "editable" value
    static member inline edits (properties: #IEditsProperty list) = Interop.mkConfigAttr "edits" (createObj !!properties)
    /// When `layout.autosize` is turned on, determines whether the graph fills the container (the default) or the screen (if set to *true*).
    static member inline fillFrame (value: bool) = Interop.mkConfigAttr "fillFrame" value
    /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
    static member inline frameMargins (value: int) = Interop.mkConfigAttr "frameMargins" value
    /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
    static member inline frameMargins (value: float) = Interop.mkConfigAttr "frameMargins" value
    /// Sets the text appearing in the `showLink` link.
    static member inline linkText (value: string) = Interop.mkConfigAttr "linkText" value
    /// Which localization should we use? Should be a string like 'en' or 'en-US'.
    static member inline locale (value: string) = Interop.mkConfigAttr "locale" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (locales: ILocalesProperty list) = Interop.mkConfigAttr "locales" (createObj !!locales)
    /// Turn all console logging on or off (errors will be thrown) This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings and errors, but not informational messages 2: verbose logs
    static member inline logging (value: int) = Interop.mkConfigAttr "logging" value
    /// Mapbox access token (required to plot mapbox trace types) If using an Mapbox Atlas server, set this option to '' so that plotly.js won't attempt to authenticate to the public Mapbox server.
    static member inline mapboxAccessToken (value: string) = Interop.mkConfigAttr "mapboxAccessToken" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: IButtonsProperty) = Interop.mkConfigAttr "modeBarButtons" (unbox<IModeBarButtonsProperty> value |> Array.singleton |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: IModeBarButtonsProperty) = Interop.mkConfigAttr "modeBarButtons" (value |> Array.singleton |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: IModeBarButtonsProperty list) = Interop.mkConfigAttr "modeBarButtons" (values |> ResizeArray |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: IButtonsProperty list) = Interop.mkConfigAttr "modeBarButtons" (values |> Seq.map unbox<IModeBarButtonsProperty> |> ResizeArray |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<#IModeBarButtonsProperty> list) = Interop.mkConfigAttr "modeBarButtons" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments. To enable predefined modebar buttons e.g. shape drawing, hover and spikelines, simply provide their string name(s). This could include: *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect* and *eraseshape*. Please note that these predefined buttons will only be shown if they are compatible with all trace types used in a graph.
    static member inline modeBarButtonsToAdd (value: #IModeBarButtonsProperty) = Interop.mkConfigAttr "modeBarButtonsToAdd" (value |> Array.singleton)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments. To enable predefined modebar buttons e.g. shape drawing, hover and spikelines, simply provide their string name(s). This could include: *v1hovermode*, *hoverclosest*, *hovercompare*, *togglehover*, *togglespikelines*, *drawline*, *drawopenpath*, *drawclosedpath*, *drawcircle*, *drawrect* and *eraseshape*. Please note that these predefined buttons will only be shown if they are compatible with all trace types used in a graph.
    static member inline modeBarButtonsToAdd (values: #IModeBarButtonsProperty list) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: #IModeBarButtonsProperty) = Interop.mkConfigAttr "modeBarButtonsToRemove" (value |> Array.singleton)
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: #IModeBarButtonsProperty list) = Interop.mkConfigAttr "modeBarButtonsToRemove" (values |> ResizeArray)
    /// Set on-graph logging (notifier) level This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no on-graph logs 1: warnings and errors, but not informational messages 2: verbose logs
    static member inline notifyOnLogging (value: int) = Interop.mkConfigAttr "notifyOnLogging" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: int) = Interop.mkConfigAttr "plotGlPixelRatio" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: float) = Interop.mkConfigAttr "plotGlPixelRatio" value
    /// When set it determines base URL for the 'Edit in Chart Studio' `showEditInChartStudio`/`showSendToCloud` mode bar button and the showLink/sendData on-graph link. To enable sending your data to Chart Studio Cloud, you need to set both `plotlyServerURL` to 'https://chart-studio.plotly.com' and also set `showSendToCloud` to true.
    static member inline plotlyServerURL (value: string) = Interop.mkConfigAttr "plotlyServerURL" value
    /// Sets the length of the undo/redo queue.
    static member inline queueLength (value: int) = Interop.mkConfigAttr "queueLength" value
    /// Determines whether to change the layout size when window is resized. In v3, this option will be removed and will always be true.
    static member inline responsive (value: bool) = Interop.mkConfigAttr "responsive" value
    /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
    static member inline scrollZoom (properties: #IConfigProperty list) = Interop.mkConfigAttr "scrollZoom" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// If *showLink* is true, does it contain data just link to a Chart Studio Cloud file?
    static member inline sendData (value: bool) = Interop.mkConfigAttr "sendData" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: bool) = Interop.mkConfigAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<bool>) = Interop.mkConfigAttr "setBackground" (values |> ResizeArray)
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: System.DateTime) = Interop.mkConfigAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<System.DateTime>) = Interop.mkConfigAttr "setBackground" (values |> ResizeArray)
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: int) = Interop.mkConfigAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<int>) = Interop.mkConfigAttr "setBackground" (values |> ResizeArray)
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: float) = Interop.mkConfigAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<float>) = Interop.mkConfigAttr "setBackground" (values |> ResizeArray)
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: string) = Interop.mkConfigAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<string>) = Interop.mkConfigAttr "setBackground" (values |> ResizeArray)
    /// Set to *false* to omit cartesian axis pan/zoom drag handles.
    static member inline showAxisDragHandles (value: bool) = Interop.mkConfigAttr "showAxisDragHandles" value
    /// Set to *false* to omit direct range entry at the pan/zoom drag points, note that `showAxisDragHandles` must be enabled to have an effect.
    static member inline showAxisRangeEntryBoxes (value: bool) = Interop.mkConfigAttr "showAxisRangeEntryBoxes" value
    /// Same as `showSendToCloud`, but use a pencil icon instead of a floppy-disk. Note that if both `showSendToCloud` and `showEditInChartStudio` are turned, only `showEditInChartStudio` will be honored.
    static member inline showEditInChartStudio (value: bool) = Interop.mkConfigAttr "showEditInChartStudio" value
    /// Determines whether a link to Chart Studio Cloud is displayed at the bottom right corner of resulting graphs. Use with `sendData` and `linkText`.
    static member inline showLink (value: bool) = Interop.mkConfigAttr "showLink" value
    /// Should we include a ModeBar button, labeled \"Edit in Chart Studio\", that sends this chart to chart-studio.plotly.com (formerly plot.ly) or another plotly server as specified by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0 this button was included by default, now it is opt-in using this flag. Note that this button can (depending on `plotlyServerURL` being set) send your data to an external server. However that server does not persist your data until you arrive at the Chart Studio and explicitly click \"Save\".
    static member inline showSendToCloud (value: bool) = Interop.mkConfigAttr "showSendToCloud" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: bool) = Interop.mkConfigAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<bool>) = Interop.mkConfigAttr "showSources" (values |> ResizeArray)
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: System.DateTime) = Interop.mkConfigAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<System.DateTime>) = Interop.mkConfigAttr "showSources" (values |> ResizeArray)
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: int) = Interop.mkConfigAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<int>) = Interop.mkConfigAttr "showSources" (values |> ResizeArray)
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: float) = Interop.mkConfigAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<float>) = Interop.mkConfigAttr "showSources" (values |> ResizeArray)
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: string) = Interop.mkConfigAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<string>) = Interop.mkConfigAttr "showSources" (values |> ResizeArray)
    /// Determines whether or not tips are shown while interacting with the resulting graphs.
    static member inline showTips (value: bool) = Interop.mkConfigAttr "showTips" value
    /// Determines whether the graphs are interactive or not. If *false*, no interactivity, for export or image generation.
    static member inline staticPlot (value: bool) = Interop.mkConfigAttr "staticPlot" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (properties: IToImageButtonOptionsProperty list) = Interop.mkConfigAttr "toImageButtonOptions" (createObj !!properties)
    /// Set the URL to topojson used in geo charts. By default, the topojson files are fetched from cdn.plot.ly. For example, set this option to: <path-to-plotly.js>/dist/topojson/ to render geographical feature using the topojson files that ship with the plotly.js module.
    static member inline topojsonURL (value: string) = Interop.mkConfigAttr "topojsonURL" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkConfigAttr "globalTransforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// watermark the images with the company's logo
    static member inline watermark (value: bool) = Interop.mkConfigAttr "watermark" value

[<Erase;RequireQualifiedAccess>]
module config =
    /// Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container.
    [<Erase>]
    type displayModeBar =
        static member inline hover = Interop.mkConfigAttr "displayModeBar" "hover"
        static member inline false' = Interop.mkConfigAttr "displayModeBar" false
        static member inline true' = Interop.mkConfigAttr "displayModeBar" true

    /// Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values.
    [<Erase>]
    type doubleClick =
        static member inline autosize = Interop.mkConfigAttr "doubleClick" "autosize"
        static member inline reset = Interop.mkConfigAttr "doubleClick" "reset"
        static member inline resetAndAutosize = Interop.mkConfigAttr "doubleClick" "reset+autosize"
        static member inline false' = Interop.mkConfigAttr "doubleClick" false

    /// Which localization should we use? Should be a string like 'en' or 'en-US'.
    [<Erase>]
    type locale =
        /// Afrikaans (Namibia)
        static member inline afNA = Interop.mkConfigAttr "locale" "af-NA"
        /// Afrikaans (South Africa)
        static member inline afZA = Interop.mkConfigAttr "locale" "af-ZA"
        /// Afrikaans
        static member inline af = Interop.mkConfigAttr "locale" "af"
        /// Akan (Ghana)
        static member inline akGH = Interop.mkConfigAttr "locale" "ak-GH"
        /// Akan
        static member inline ak = Interop.mkConfigAttr "locale" "ak"
        /// Albanian (Albania)
        static member inline sqAL = Interop.mkConfigAttr "locale" "sq-AL"
        /// Albanian
        static member inline sq = Interop.mkConfigAttr "locale" "sq"
        /// Amharic (Ethiopia)
        static member inline amET = Interop.mkConfigAttr "locale" "am-ET"
        /// Amharic
        static member inline am = Interop.mkConfigAttr "locale" "am"
        /// Arabic (Algeria)
        static member inline arDZ = Interop.mkConfigAttr "locale" "ar-DZ"
        /// Arabic (Bahrain)
        static member inline arBH = Interop.mkConfigAttr "locale" "ar-BH"
        /// Arabic (Egypt)
        static member inline arEG = Interop.mkConfigAttr "locale" "ar-EG"
        /// Arabic (Iraq)
        static member inline arIQ = Interop.mkConfigAttr "locale" "ar-IQ"
        /// Arabic (Jordan)
        static member inline arJO = Interop.mkConfigAttr "locale" "ar-JO"
        /// Arabic (Kuwait)
        static member inline arKW = Interop.mkConfigAttr "locale" "ar-KW"
        /// Arabic (Lebanon)
        static member inline arLB = Interop.mkConfigAttr "locale" "ar-LB"
        /// Arabic (Libya)
        static member inline arLY = Interop.mkConfigAttr "locale" "ar-LY"
        /// Arabic (Morocco)
        static member inline arMA = Interop.mkConfigAttr "locale" "ar-MA"
        /// Arabic (Oman)
        static member inline arOM = Interop.mkConfigAttr "locale" "ar-OM"
        /// Arabic (Qatar)
        static member inline arQA = Interop.mkConfigAttr "locale" "ar-QA"
        /// Arabic (Saudi Arabia)
        static member inline arSA = Interop.mkConfigAttr "locale" "ar-SA"
        /// Arabic (Sudan)
        static member inline arSD = Interop.mkConfigAttr "locale" "ar-SD"
        /// Arabic (Syria)
        static member inline arSY = Interop.mkConfigAttr "locale" "ar-SY"
        /// Arabic (Tunisia)
        static member inline arTN = Interop.mkConfigAttr "locale" "ar-TN"
        /// Arabic (United Arab Emirates)
        static member inline arAE = Interop.mkConfigAttr "locale" "ar-AE"
        /// Arabic (Yemen)
        static member inline arYE = Interop.mkConfigAttr "locale" "ar-YE"
        /// Arabic
        static member inline ar = Interop.mkConfigAttr "locale" "ar"
        /// Armenian (Armenia)
        static member inline hyAM = Interop.mkConfigAttr "locale" "hy-AM"
        /// Armenian
        static member inline hy = Interop.mkConfigAttr "locale" "hy"
        /// Assamese (India)
        static member inline asIN = Interop.mkConfigAttr "locale" "as-IN"
        /// Assamese
        static member inline as' = Interop.mkConfigAttr "locale" "as"
        /// Asu (Tanzania)
        static member inline asaTZ = Interop.mkConfigAttr "locale" "asa-TZ"
        /// Asu
        static member inline asa = Interop.mkConfigAttr "locale" "asa"
        /// Azerbaijani (Cyrillic)
        static member inline azCyrl = Interop.mkConfigAttr "locale" "az-Cyrl"
        /// Azerbaijani (Cyrillic, Azerbaijan)
        static member inline azCyrlAZ = Interop.mkConfigAttr "locale" "az-Cyrl-AZ"
        /// Azerbaijani (Latin)
        static member inline azLatn = Interop.mkConfigAttr "locale" "az-Latn"
        /// Azerbaijani (Latin, Azerbaijan)
        static member inline azLatnAZ = Interop.mkConfigAttr "locale" "az-Latn-AZ"
        /// Azerbaijani
        static member inline az = Interop.mkConfigAttr "locale" "az"
        /// Bambara (Mali)
        static member inline bmML = Interop.mkConfigAttr "locale" "bm-ML"
        /// Bambara
        static member inline bm = Interop.mkConfigAttr "locale" "bm"
        /// Basque (Spain)
        static member inline euES = Interop.mkConfigAttr "locale" "eu-ES"
        /// Basque
        static member inline eu = Interop.mkConfigAttr "locale" "eu"
        /// Belarusian (Belarus)
        static member inline beBY = Interop.mkConfigAttr "locale" "be-BY"
        /// Belarusian
        static member inline be = Interop.mkConfigAttr "locale" "be"
        /// Bemba (Zambia)
        static member inline bemZM = Interop.mkConfigAttr "locale" "bem-ZM"
        /// Bemba
        static member inline bem = Interop.mkConfigAttr "locale" "bem"
        /// Bena (Tanzania)
        static member inline bezTZ = Interop.mkConfigAttr "locale" "bez-TZ"
        /// Bena
        static member inline bez = Interop.mkConfigAttr "locale" "bez"
        /// Bengali (Bangladesh)
        static member inline bnBD = Interop.mkConfigAttr "locale" "bn-BD"
        /// Bengali (India)
        static member inline bnIN = Interop.mkConfigAttr "locale" "bn-IN"
        /// Bengali
        static member inline bn = Interop.mkConfigAttr "locale" "bn"
        /// Bosnian (Bosnia and Herzegovina)
        static member inline bsBA = Interop.mkConfigAttr "locale" "bs-BA"
        /// Bosnian
        static member inline bs = Interop.mkConfigAttr "locale" "bs"
        /// Bulgarian (Bulgaria)
        static member inline bgBG = Interop.mkConfigAttr "locale" "bg-BG"
        /// Bulgarian
        static member inline bg = Interop.mkConfigAttr "locale" "bg"
        /// Burmese (Myanmar [Burma])
        static member inline myMM = Interop.mkConfigAttr "locale" "my-MM"
        /// Burmese
        static member inline my = Interop.mkConfigAttr "locale" "my"
        /// Cantonese (Traditional, Hong Kong SAR China)
        static member inline yueHantHK = Interop.mkConfigAttr "locale" "yue-Hant-HK"
        /// Catalan (Spain)
        static member inline caES = Interop.mkConfigAttr "locale" "ca-ES"
        /// Catalan
        static member inline ca = Interop.mkConfigAttr "locale" "ca"
        /// Central Morocco Tamazight (Latin)
        static member inline tzmLatn = Interop.mkConfigAttr "locale" "tzm-Latn"
        /// Central Morocco Tamazight (Latin, Morocco)
        static member inline tzmLatnMA = Interop.mkConfigAttr "locale" "tzm-Latn-MA"
        /// Central Morocco Tamazight
        static member inline tzm = Interop.mkConfigAttr "locale" "tzm"
        /// Cherokee (United States)
        static member inline chrUS = Interop.mkConfigAttr "locale" "chr-US"
        /// Cherokee
        static member inline chr = Interop.mkConfigAttr "locale" "chr"
        /// Chiga (Uganda)
        static member inline cggUG = Interop.mkConfigAttr "locale" "cgg-UG"
        /// Chiga
        static member inline cgg = Interop.mkConfigAttr "locale" "cgg"
        /// Chinese (Simplified Han)
        static member inline zhHans = Interop.mkConfigAttr "locale" "zh-Hans"
        /// Chinese (Simplified Han, China)
        static member inline zhHansCN = Interop.mkConfigAttr "locale" "zh-Hans-CN"
        /// Chinese (Simplified Han, Hong Kong SAR China)
        static member inline zhHansHK = Interop.mkConfigAttr "locale" "zh-Hans-HK"
        /// Chinese (Simplified Han, Macau SAR China)
        static member inline zhHansMO = Interop.mkConfigAttr "locale" "zh-Hans-MO"
        /// Chinese (Simplified Han, Singapore)
        static member inline zhHansSG = Interop.mkConfigAttr "locale" "zh-Hans-SG"
        /// Chinese (Traditional Han)
        static member inline zhHant = Interop.mkConfigAttr "locale" "zh-Hant"
        /// Chinese (Traditional Han, Hong Kong SAR China)
        static member inline zhHantHK = Interop.mkConfigAttr "locale" "zh-Hant-HK"
        /// Chinese (Traditional Han, Macau SAR China)
        static member inline zhHantMO = Interop.mkConfigAttr "locale" "zh-Hant-MO"
        /// Chinese (Traditional Han, Taiwan)
        static member inline zhHantTW = Interop.mkConfigAttr "locale" "zh-Hant-TW"
        /// Chinese
        static member inline zh = Interop.mkConfigAttr "locale" "zh"
        /// Cornish (United Kingdom)
        static member inline kwGB = Interop.mkConfigAttr "locale" "kw-GB"
        /// Cornish
        static member inline kw = Interop.mkConfigAttr "locale" "kw"
        /// Croatian (Croatia)
        static member inline hrHR = Interop.mkConfigAttr "locale" "hr-HR"
        /// Croatian
        static member inline hr = Interop.mkConfigAttr "locale" "hr"
        /// Czech (Czech Republic)
        static member inline csCZ = Interop.mkConfigAttr "locale" "cs-CZ"
        /// Czech
        static member inline cs = Interop.mkConfigAttr "locale" "cs"
        /// Danish (Denmark)
        static member inline daDK = Interop.mkConfigAttr "locale" "da-DK"
        /// Danish
        static member inline da = Interop.mkConfigAttr "locale" "da"
        /// Dutch (Belgium)
        static member inline nlBE = Interop.mkConfigAttr "locale" "nl-BE"
        /// Dutch (Netherlands)
        static member inline nlNL = Interop.mkConfigAttr "locale" "nl-NL"
        /// Dutch
        static member inline nl = Interop.mkConfigAttr "locale" "nl"
        /// Embu (Kenya)
        static member inline ebuKE = Interop.mkConfigAttr "locale" "ebu-KE"
        /// Embu
        static member inline ebu = Interop.mkConfigAttr "locale" "ebu"
        /// English (American Samoa)
        static member inline enAS = Interop.mkConfigAttr "locale" "en-AS"
        /// English (Australia)
        static member inline enAU = Interop.mkConfigAttr "locale" "en-AU"
        /// English (Belgium)
        static member inline enBE = Interop.mkConfigAttr "locale" "en-BE"
        /// English (Belize)
        static member inline enBZ = Interop.mkConfigAttr "locale" "en-BZ"
        /// English (Botswana)
        static member inline enBW = Interop.mkConfigAttr "locale" "en-BW"
        /// English (Canada)
        static member inline enCA = Interop.mkConfigAttr "locale" "en-CA"
        /// English (Guam)
        static member inline enGU = Interop.mkConfigAttr "locale" "en-GU"
        /// English (Hong Kong SAR China)
        static member inline enHK = Interop.mkConfigAttr "locale" "en-HK"
        /// English (India)
        static member inline enIN = Interop.mkConfigAttr "locale" "en-IN"
        /// English (Ireland)
        static member inline enIE = Interop.mkConfigAttr "locale" "en-IE"
        /// English (Israel)
        static member inline enIL = Interop.mkConfigAttr "locale" "en-IL"
        /// English (Jamaica)
        static member inline enJM = Interop.mkConfigAttr "locale" "en-JM"
        /// English (Malta)
        static member inline enMT = Interop.mkConfigAttr "locale" "en-MT"
        /// English (Marshall Islands)
        static member inline enMH = Interop.mkConfigAttr "locale" "en-MH"
        /// English (Mauritius)
        static member inline enMU = Interop.mkConfigAttr "locale" "en-MU"
        /// English (Namibia)
        static member inline enNA = Interop.mkConfigAttr "locale" "en-NA"
        /// English (New Zealand)
        static member inline enNZ = Interop.mkConfigAttr "locale" "en-NZ"
        /// English (Northern Mariana Islands)
        static member inline enMP = Interop.mkConfigAttr "locale" "en-MP"
        /// English (Pakistan)
        static member inline enPK = Interop.mkConfigAttr "locale" "en-PK"
        /// English (Philippines)
        static member inline enPH = Interop.mkConfigAttr "locale" "en-PH"
        /// English (Singapore)
        static member inline enSG = Interop.mkConfigAttr "locale" "en-SG"
        /// English (South Africa)
        static member inline enZA = Interop.mkConfigAttr "locale" "en-ZA"
        /// English (Trinidad and Tobago)
        static member inline enTT = Interop.mkConfigAttr "locale" "en-TT"
        /// English (U.S. Minor Outlying Islands)
        static member inline enUM = Interop.mkConfigAttr "locale" "en-UM"
        /// English (U.S. Virgin Islands)
        static member inline enVI = Interop.mkConfigAttr "locale" "en-VI"
        /// English (United Kingdom)
        static member inline enGB = Interop.mkConfigAttr "locale" "en-GB"
        /// English (United States)
        static member inline enUS = Interop.mkConfigAttr "locale" "en-US"
        /// English (Zimbabwe)
        static member inline enZW = Interop.mkConfigAttr "locale" "en-ZW"
        /// English
        static member inline en = Interop.mkConfigAttr "locale" "en"
        /// Esperanto
        static member inline eo = Interop.mkConfigAttr "locale" "eo"
        /// Estonian (Estonia)
        static member inline etEE = Interop.mkConfigAttr "locale" "et-EE"
        /// Estonian
        static member inline et = Interop.mkConfigAttr "locale" "et"
        /// Ewe (Ghana)
        static member inline eeGH = Interop.mkConfigAttr "locale" "ee-GH"
        /// Ewe (Togo)
        static member inline eeTG = Interop.mkConfigAttr "locale" "ee-TG"
        /// Ewe
        static member inline ee = Interop.mkConfigAttr "locale" "ee"
        /// Faroese (Faroe Islands)
        static member inline foFO = Interop.mkConfigAttr "locale" "fo-FO"
        /// Faroese
        static member inline fo = Interop.mkConfigAttr "locale" "fo"
        /// Filipino (Philippines)
        static member inline filPH = Interop.mkConfigAttr "locale" "fil-PH"
        /// Filipino
        static member inline fil = Interop.mkConfigAttr "locale" "fil"
        /// Finnish (Finland)
        static member inline fiFI = Interop.mkConfigAttr "locale" "fi-FI"
        /// Finnish
        static member inline fi = Interop.mkConfigAttr "locale" "fi"
        /// French (Belgium)
        static member inline frBE = Interop.mkConfigAttr "locale" "fr-BE"
        /// French (Benin)
        static member inline frBJ = Interop.mkConfigAttr "locale" "fr-BJ"
        /// French (Burkina Faso)
        static member inline frBF = Interop.mkConfigAttr "locale" "fr-BF"
        /// French (Burundi)
        static member inline frBI = Interop.mkConfigAttr "locale" "fr-BI"
        /// French (Cameroon)
        static member inline frCM = Interop.mkConfigAttr "locale" "fr-CM"
        /// French (Canada)
        static member inline frCA = Interop.mkConfigAttr "locale" "fr-CA"
        /// French (Central African Republic)
        static member inline frCF = Interop.mkConfigAttr "locale" "fr-CF"
        /// French (Chad)
        static member inline frTD = Interop.mkConfigAttr "locale" "fr-TD"
        /// French (Comoros)
        static member inline frKM = Interop.mkConfigAttr "locale" "fr-KM"
        /// French (Congo - Brazzaville)
        static member inline frCG = Interop.mkConfigAttr "locale" "fr-CG"
        /// French (Congo - Kinshasa)
        static member inline frCD = Interop.mkConfigAttr "locale" "fr-CD"
        /// French (C�te d�Ivoire)
        static member inline frCI = Interop.mkConfigAttr "locale" "fr-CI"
        /// French (Djibouti)
        static member inline frDJ = Interop.mkConfigAttr "locale" "fr-DJ"
        /// French (Equatorial Guinea)
        static member inline frGQ = Interop.mkConfigAttr "locale" "fr-GQ"
        /// French (France)
        static member inline frFR = Interop.mkConfigAttr "locale" "fr-FR"
        /// French (Gabon)
        static member inline frGA = Interop.mkConfigAttr "locale" "fr-GA"
        /// French (Guadeloupe)
        static member inline frGP = Interop.mkConfigAttr "locale" "fr-GP"
        /// French (Guinea)
        static member inline frGN = Interop.mkConfigAttr "locale" "fr-GN"
        /// French (Luxembourg)
        static member inline frLU = Interop.mkConfigAttr "locale" "fr-LU"
        /// French (Madagascar)
        static member inline frMG = Interop.mkConfigAttr "locale" "fr-MG"
        /// French (Mali)
        static member inline frML = Interop.mkConfigAttr "locale" "fr-ML"
        /// French (Martinique)
        static member inline frMQ = Interop.mkConfigAttr "locale" "fr-MQ"
        /// French (Monaco)
        static member inline frMC = Interop.mkConfigAttr "locale" "fr-MC"
        /// French (Niger)
        static member inline frNE = Interop.mkConfigAttr "locale" "fr-NE"
        /// French (Rwanda)
        static member inline frRW = Interop.mkConfigAttr "locale" "fr-RW"
        /// French (R�union)
        static member inline frRE = Interop.mkConfigAttr "locale" "fr-RE"
        /// French (Saint Barth�lemy)
        static member inline frBL = Interop.mkConfigAttr "locale" "fr-BL"
        /// French (Saint Martin)
        static member inline frMF = Interop.mkConfigAttr "locale" "fr-MF"
        /// French (Senegal)
        static member inline frSN = Interop.mkConfigAttr "locale" "fr-SN"
        /// French (Switzerland)
        static member inline frCH = Interop.mkConfigAttr "locale" "fr-CH"
        /// French (Togo)
        static member inline frTG = Interop.mkConfigAttr "locale" "fr-TG"
        /// French
        static member inline fr = Interop.mkConfigAttr "locale" "fr"
        /// Fulah (Senegal)
        static member inline ffSN = Interop.mkConfigAttr "locale" "ff-SN"
        /// Fulah
        static member inline ff = Interop.mkConfigAttr "locale" "ff"
        /// Galician (Spain)
        static member inline glES = Interop.mkConfigAttr "locale" "gl-ES"
        /// Galician
        static member inline gl = Interop.mkConfigAttr "locale" "gl"
        /// Ganda (Uganda)
        static member inline lgUG = Interop.mkConfigAttr "locale" "lg-UG"
        /// Ganda
        static member inline lg = Interop.mkConfigAttr "locale" "lg"
        /// Georgian (Georgia)
        static member inline kaGE = Interop.mkConfigAttr "locale" "ka-GE"
        /// Georgian
        static member inline ka = Interop.mkConfigAttr "locale" "ka"
        /// German (Austria)
        static member inline deAT = Interop.mkConfigAttr "locale" "de-AT"
        /// German (Belgium)
        static member inline deBE = Interop.mkConfigAttr "locale" "de-BE"
        /// German (Germany)
        static member inline deDE = Interop.mkConfigAttr "locale" "de-DE"
        /// German (Liechtenstein)
        static member inline deLI = Interop.mkConfigAttr "locale" "de-LI"
        /// German (Luxembourg)
        static member inline deLU = Interop.mkConfigAttr "locale" "de-LU"
        /// German (Switzerland)
        static member inline deCH = Interop.mkConfigAttr "locale" "de-CH"
        /// German
        static member inline de = Interop.mkConfigAttr "locale" "de"
        /// Greek (Cyprus)
        static member inline elCY = Interop.mkConfigAttr "locale" "el-CY"
        /// Greek (Greece)
        static member inline elGR = Interop.mkConfigAttr "locale" "el-GR"
        /// Greek
        static member inline el = Interop.mkConfigAttr "locale" "el"
        /// Gujarati (India)
        static member inline guIN = Interop.mkConfigAttr "locale" "gu-IN"
        /// Gujarati
        static member inline gu = Interop.mkConfigAttr "locale" "gu"
        /// Gusii (Kenya)
        static member inline guzKE = Interop.mkConfigAttr "locale" "guz-KE"
        /// Gusii
        static member inline guz = Interop.mkConfigAttr "locale" "guz"
        /// Hausa (Latin)
        static member inline haLatn = Interop.mkConfigAttr "locale" "ha-Latn"
        /// Hausa (Latin, Ghana)
        static member inline haLatnGH = Interop.mkConfigAttr "locale" "ha-Latn-GH"
        /// Hausa (Latin, Niger)
        static member inline haLatnNE = Interop.mkConfigAttr "locale" "ha-Latn-NE"
        /// Hausa (Latin, Nigeria)
        static member inline haLatnNG = Interop.mkConfigAttr "locale" "ha-Latn-NG"
        /// Hausa
        static member inline ha = Interop.mkConfigAttr "locale" "ha"
        /// Hawaiian (United States)
        static member inline hawUS = Interop.mkConfigAttr "locale" "haw-US"
        /// Hawaiian
        static member inline haw = Interop.mkConfigAttr "locale" "haw"
        /// Hebrew (Israel)
        static member inline heIL = Interop.mkConfigAttr "locale" "he-IL"
        /// Hebrew
        static member inline he = Interop.mkConfigAttr "locale" "he"
        /// Hindi (India)
        static member inline hiIN = Interop.mkConfigAttr "locale" "hi-IN"
        /// Hindi
        static member inline hi = Interop.mkConfigAttr "locale" "hi"
        /// Hungarian (Hungary)
        static member inline huHU = Interop.mkConfigAttr "locale" "hu-HU"
        /// Hungarian
        static member inline hu = Interop.mkConfigAttr "locale" "hu"
        /// Icelandic (Iceland)
        static member inline isIS = Interop.mkConfigAttr "locale" "is-IS"
        /// Icelandic
        static member inline is = Interop.mkConfigAttr "locale" "is"
        /// Igbo (Nigeria)
        static member inline igNG = Interop.mkConfigAttr "locale" "ig-NG"
        /// Igbo
        static member inline ig = Interop.mkConfigAttr "locale" "ig"
        /// Indonesian (Indonesia)
        static member inline idID = Interop.mkConfigAttr "locale" "id-ID"
        /// Indonesian
        static member inline id = Interop.mkConfigAttr "locale" "id"
        /// Irish (Ireland)
        static member inline gaIE = Interop.mkConfigAttr "locale" "ga-IE"
        /// Irish
        static member inline ga = Interop.mkConfigAttr "locale" "ga"
        /// Italian (Italy)
        static member inline itIT = Interop.mkConfigAttr "locale" "it-IT"
        /// Italian (Switzerland)
        static member inline itCH = Interop.mkConfigAttr "locale" "it-CH"
        /// Italian
        static member inline it = Interop.mkConfigAttr "locale" "it"
        /// Japanese (Japan)
        static member inline jaJP = Interop.mkConfigAttr "locale" "ja-JP"
        /// Japanese
        static member inline ja = Interop.mkConfigAttr "locale" "ja"
        /// Kabuverdianu (Cape Verde)
        static member inline keaCV = Interop.mkConfigAttr "locale" "kea-CV"
        /// Kabuverdianu
        static member inline kea = Interop.mkConfigAttr "locale" "kea"
        /// Kabyle (Algeria)
        static member inline kabDZ = Interop.mkConfigAttr "locale" "kab-DZ"
        /// Kabyle
        static member inline kab = Interop.mkConfigAttr "locale" "kab"
        /// Kalaallisut (Greenland)
        static member inline klGL = Interop.mkConfigAttr "locale" "kl-GL"
        /// Kalaallisut
        static member inline kl = Interop.mkConfigAttr "locale" "kl"
        /// Kalenjin (Kenya)
        static member inline klnKE = Interop.mkConfigAttr "locale" "kln-KE"
        /// Kalenjin
        static member inline kln = Interop.mkConfigAttr "locale" "kln"
        /// Kamba (Kenya)
        static member inline kamKE = Interop.mkConfigAttr "locale" "kam-KE"
        /// Kamba
        static member inline kam = Interop.mkConfigAttr "locale" "kam"
        /// Kannada (India)
        static member inline knIN = Interop.mkConfigAttr "locale" "kn-IN"
        /// Kannada
        static member inline kn = Interop.mkConfigAttr "locale" "kn"
        /// Kazakh (Cyrillic)
        static member inline kkCyrl = Interop.mkConfigAttr "locale" "kk-Cyrl"
        /// Kazakh (Cyrillic, Kazakhstan)
        static member inline kkCyrlKZ = Interop.mkConfigAttr "locale" "kk-Cyrl-KZ"
        /// Kazakh
        static member inline kk = Interop.mkConfigAttr "locale" "kk"
        /// Khmer (Cambodia)
        static member inline kmKH = Interop.mkConfigAttr "locale" "km-KH"
        /// Khmer
        static member inline km = Interop.mkConfigAttr "locale" "km"
        /// Kikuyu (Kenya)
        static member inline kiKE = Interop.mkConfigAttr "locale" "ki-KE"
        /// Kikuyu
        static member inline ki = Interop.mkConfigAttr "locale" "ki"
        /// Kinyarwanda (Rwanda)
        static member inline rwRW = Interop.mkConfigAttr "locale" "rw-RW"
        /// Kinyarwanda
        static member inline rw = Interop.mkConfigAttr "locale" "rw"
        /// Konkani (India)
        static member inline kokIN = Interop.mkConfigAttr "locale" "kok-IN"
        /// Konkani
        static member inline kok = Interop.mkConfigAttr "locale" "kok"
        /// Korean (South Korea)
        static member inline koKR = Interop.mkConfigAttr "locale" "ko-KR"
        /// Korean
        static member inline ko = Interop.mkConfigAttr "locale" "ko"
        /// Koyra Chiini (Mali)
        static member inline khqML = Interop.mkConfigAttr "locale" "khq-ML"
        /// Koyra Chiini
        static member inline khq = Interop.mkConfigAttr "locale" "khq"
        /// Koyraboro Senni (Mali)
        static member inline sesML = Interop.mkConfigAttr "locale" "ses-ML"
        /// Koyraboro Senni
        static member inline ses = Interop.mkConfigAttr "locale" "ses"
        /// Langi (Tanzania)
        static member inline lagTZ = Interop.mkConfigAttr "locale" "lag-TZ"
        /// Langi
        static member inline lag = Interop.mkConfigAttr "locale" "lag"
        /// Latvian (Latvia)
        static member inline lvLV = Interop.mkConfigAttr "locale" "lv-LV"
        /// Latvian
        static member inline lv = Interop.mkConfigAttr "locale" "lv"
        /// Lithuanian (Lithuania)
        static member inline ltLT = Interop.mkConfigAttr "locale" "lt-LT"
        /// Lithuanian
        static member inline lt = Interop.mkConfigAttr "locale" "lt"
        /// Luo (Kenya)
        static member inline luoKE = Interop.mkConfigAttr "locale" "luo-KE"
        /// Luo
        static member inline luo = Interop.mkConfigAttr "locale" "luo"
        /// Luyia (Kenya)
        static member inline luyKE = Interop.mkConfigAttr "locale" "luy-KE"
        /// Luyia
        static member inline luy = Interop.mkConfigAttr "locale" "luy"
        /// Macedonian (Macedonia)
        static member inline mkMK = Interop.mkConfigAttr "locale" "mk-MK"
        /// Macedonian
        static member inline mk = Interop.mkConfigAttr "locale" "mk"
        /// Machame (Tanzania)
        static member inline jmcTZ = Interop.mkConfigAttr "locale" "jmc-TZ"
        /// Machame
        static member inline jmc = Interop.mkConfigAttr "locale" "jmc"
        /// Makonde (Tanzania)
        static member inline kdeTZ = Interop.mkConfigAttr "locale" "kde-TZ"
        /// Makonde
        static member inline kde = Interop.mkConfigAttr "locale" "kde"
        /// Malagasy (Madagascar)
        static member inline mgMG = Interop.mkConfigAttr "locale" "mg-MG"
        /// Malagasy
        static member inline mg = Interop.mkConfigAttr "locale" "mg"
        /// Malay (Brunei)
        static member inline msBN = Interop.mkConfigAttr "locale" "ms-BN"
        /// Malay (Malaysia)
        static member inline msMY = Interop.mkConfigAttr "locale" "ms-MY"
        /// Malay
        static member inline ms = Interop.mkConfigAttr "locale" "ms"
        /// Malayalam (India)
        static member inline mlIN = Interop.mkConfigAttr "locale" "ml-IN"
        /// Malayalam
        static member inline ml = Interop.mkConfigAttr "locale" "ml"
        /// Maltese (Malta)
        static member inline mtMT = Interop.mkConfigAttr "locale" "mt-MT"
        /// Maltese
        static member inline mt = Interop.mkConfigAttr "locale" "mt"
        /// Manx (United Kingdom)
        static member inline gvGB = Interop.mkConfigAttr "locale" "gv-GB"
        /// Manx
        static member inline gv = Interop.mkConfigAttr "locale" "gv"
        /// Marathi (India)
        static member inline mrIN = Interop.mkConfigAttr "locale" "mr-IN"
        /// Marathi
        static member inline mr = Interop.mkConfigAttr "locale" "mr"
        /// Masai (Kenya)
        static member inline masKE = Interop.mkConfigAttr "locale" "mas-KE"
        /// Masai (Tanzania)
        static member inline masTZ = Interop.mkConfigAttr "locale" "mas-TZ"
        /// Masai
        static member inline mas = Interop.mkConfigAttr "locale" "mas"
        /// Meru (Kenya)
        static member inline merKE = Interop.mkConfigAttr "locale" "mer-KE"
        /// Meru
        static member inline mer = Interop.mkConfigAttr "locale" "mer"
        /// Morisyen (Mauritius)
        static member inline mfeMU = Interop.mkConfigAttr "locale" "mfe-MU"
        /// Morisyen
        static member inline mfe = Interop.mkConfigAttr "locale" "mfe"
        /// Nama (Namibia)
        static member inline naqNA = Interop.mkConfigAttr "locale" "naq-NA"
        /// Nama
        static member inline naq = Interop.mkConfigAttr "locale" "naq"
        /// Nepali (India)
        static member inline neIN = Interop.mkConfigAttr "locale" "ne-IN"
        /// Nepali (Nepal)
        static member inline neNP = Interop.mkConfigAttr "locale" "ne-NP"
        /// Nepali
        static member inline ne = Interop.mkConfigAttr "locale" "ne"
        /// North Ndebele (Zimbabwe)
        static member inline ndZW = Interop.mkConfigAttr "locale" "nd-ZW"
        /// North Ndebele
        static member inline nd = Interop.mkConfigAttr "locale" "nd"
        /// Norwegian Bokm�l (Norway)
        static member inline nbNO = Interop.mkConfigAttr "locale" "nb-NO"
        /// Norwegian Bokm�l
        static member inline nb = Interop.mkConfigAttr "locale" "nb"
        /// Norwegian Nynorsk (Norway)
        static member inline nnNO = Interop.mkConfigAttr "locale" "nn-NO"
        /// Norwegian Nynorsk
        static member inline nn = Interop.mkConfigAttr "locale" "nn"
        /// Nyankole (Uganda)
        static member inline nynUG = Interop.mkConfigAttr "locale" "nyn-UG"
        /// Nyankole
        static member inline nyn = Interop.mkConfigAttr "locale" "nyn"
        /// Oriya (India)
        static member inline orIN = Interop.mkConfigAttr "locale" "or-IN"
        /// Oriya
        static member inline or' = Interop.mkConfigAttr "locale" "or"
        /// Oromo (Ethiopia)
        static member inline omET = Interop.mkConfigAttr "locale" "om-ET"
        /// Oromo (Kenya)
        static member inline omKE = Interop.mkConfigAttr "locale" "om-KE"
        /// Oromo
        static member inline om = Interop.mkConfigAttr "locale" "om"
        /// Pashto (Afghanistan)
        static member inline psAF = Interop.mkConfigAttr "locale" "ps-AF"
        /// Pashto
        static member inline ps = Interop.mkConfigAttr "locale" "ps"
        /// Persian (Afghanistan)
        static member inline faAF = Interop.mkConfigAttr "locale" "fa-AF"
        /// Persian (Iran)
        static member inline faIR = Interop.mkConfigAttr "locale" "fa-IR"
        /// Persian
        static member inline fa = Interop.mkConfigAttr "locale" "fa"
        /// Polish (Poland)
        static member inline plPL = Interop.mkConfigAttr "locale" "pl-PL"
        /// Polish
        static member inline pl = Interop.mkConfigAttr "locale" "pl"
        /// Portuguese (Brazil)
        static member inline ptBR = Interop.mkConfigAttr "locale" "pt-BR"
        /// Portuguese (Guinea-Bissau)
        static member inline ptGW = Interop.mkConfigAttr "locale" "pt-GW"
        /// Portuguese (Mozambique)
        static member inline ptMZ = Interop.mkConfigAttr "locale" "pt-MZ"
        /// Portuguese (Portugal)
        static member inline ptPT = Interop.mkConfigAttr "locale" "pt-PT"
        /// Portuguese
        static member inline pt = Interop.mkConfigAttr "locale" "pt"
        /// Punjabi (Arabic)
        static member inline paArab = Interop.mkConfigAttr "locale" "pa-Arab"
        /// Punjabi (Arabic, Pakistan)
        static member inline paArabPK = Interop.mkConfigAttr "locale" "pa-Arab-PK"
        /// Punjabi (Gurmukhi)
        static member inline paGuru = Interop.mkConfigAttr "locale" "pa-Guru"
        /// Punjabi (Gurmukhi, India)
        static member inline paGuruIN = Interop.mkConfigAttr "locale" "pa-Guru-IN"
        /// Punjabi
        static member inline pa = Interop.mkConfigAttr "locale" "pa"
        /// Romanian (Moldova)
        static member inline roMD = Interop.mkConfigAttr "locale" "ro-MD"
        /// Romanian (Romania)
        static member inline roRO = Interop.mkConfigAttr "locale" "ro-RO"
        /// Romanian
        static member inline ro = Interop.mkConfigAttr "locale" "ro"
        /// Romansh (Switzerland)
        static member inline rmCH = Interop.mkConfigAttr "locale" "rm-CH"
        /// Romansh
        static member inline rm = Interop.mkConfigAttr "locale" "rm"
        /// Rombo (Tanzania)
        static member inline rofTZ = Interop.mkConfigAttr "locale" "rof-TZ"
        /// Rombo
        static member inline rof = Interop.mkConfigAttr "locale" "rof"
        /// Russian (Moldova)
        static member inline ruMD = Interop.mkConfigAttr "locale" "ru-MD"
        /// Russian (Russia)
        static member inline ruRU = Interop.mkConfigAttr "locale" "ru-RU"
        /// Russian (Ukraine)
        static member inline ruUA = Interop.mkConfigAttr "locale" "ru-UA"
        /// Russian
        static member inline ru = Interop.mkConfigAttr "locale" "ru"
        /// Rwa (Tanzania)
        static member inline rwkTZ = Interop.mkConfigAttr "locale" "rwk-TZ"
        /// Rwa
        static member inline rwk = Interop.mkConfigAttr "locale" "rwk"
        /// Samburu (Kenya)
        static member inline saqKE = Interop.mkConfigAttr "locale" "saq-KE"
        /// Samburu
        static member inline saq = Interop.mkConfigAttr "locale" "saq"
        /// Sango (Central African Republic)
        static member inline sgCF = Interop.mkConfigAttr "locale" "sg-CF"
        /// Sango
        static member inline sg = Interop.mkConfigAttr "locale" "sg"
        /// Sena (Mozambique)
        static member inline sehMZ = Interop.mkConfigAttr "locale" "seh-MZ"
        /// Sena
        static member inline seh = Interop.mkConfigAttr "locale" "seh"
        /// Serbian (Cyrillic)
        static member inline srCyrl = Interop.mkConfigAttr "locale" "sr-Cyrl"
        /// Serbian (Cyrillic, Bosnia and Herzegovina)
        static member inline srCyrlBA = Interop.mkConfigAttr "locale" "sr-Cyrl-BA"
        /// Serbian (Cyrillic, Montenegro)
        static member inline srCyrlME = Interop.mkConfigAttr "locale" "sr-Cyrl-ME"
        /// Serbian (Cyrillic, Serbia)
        static member inline srCyrlRS = Interop.mkConfigAttr "locale" "sr-Cyrl-RS"
        /// Serbian (Latin)
        static member inline srLatn = Interop.mkConfigAttr "locale" "sr-Latn"
        /// Serbian (Latin, Bosnia and Herzegovina)
        static member inline srLatnBA = Interop.mkConfigAttr "locale" "sr-Latn-BA"
        /// Serbian (Latin, Montenegro)
        static member inline srLatnME = Interop.mkConfigAttr "locale" "sr-Latn-ME"
        /// Serbian (Latin, Serbia)
        static member inline srLatnRS = Interop.mkConfigAttr "locale" "sr-Latn-RS"
        /// Serbian
        static member inline sr = Interop.mkConfigAttr "locale" "sr"
        /// Shona (Zimbabwe)
        static member inline snZW = Interop.mkConfigAttr "locale" "sn-ZW"
        /// Shona
        static member inline sn = Interop.mkConfigAttr "locale" "sn"
        /// Sichuan Yi (China)
        static member inline iiCN = Interop.mkConfigAttr "locale" "ii-CN"
        /// Sichuan Yi
        static member inline ii = Interop.mkConfigAttr "locale" "ii"
        /// Sinhala (Sri Lanka)
        static member inline siLK = Interop.mkConfigAttr "locale" "si-LK"
        /// Sinhala
        static member inline si = Interop.mkConfigAttr "locale" "si"
        /// Slovak (Slovakia)
        static member inline skSK = Interop.mkConfigAttr "locale" "sk-SK"
        /// Slovak
        static member inline sk = Interop.mkConfigAttr "locale" "sk"
        /// Slovenian (Slovenia)
        static member inline slSI = Interop.mkConfigAttr "locale" "sl-SI"
        /// Slovenian
        static member inline sl = Interop.mkConfigAttr "locale" "sl"
        /// Soga (Uganda)
        static member inline xogUG = Interop.mkConfigAttr "locale" "xog-UG"
        /// Soga
        static member inline xog = Interop.mkConfigAttr "locale" "xog"
        /// Somali (Djibouti)
        static member inline soDJ = Interop.mkConfigAttr "locale" "so-DJ"
        /// Somali (Ethiopia)
        static member inline soET = Interop.mkConfigAttr "locale" "so-ET"
        /// Somali (Kenya)
        static member inline soKE = Interop.mkConfigAttr "locale" "so-KE"
        /// Somali (Somalia)
        static member inline soSO = Interop.mkConfigAttr "locale" "so-SO"
        /// Somali
        static member inline so = Interop.mkConfigAttr "locale" "so"
        /// Spanish (Argentina)
        static member inline esAR = Interop.mkConfigAttr "locale" "es-AR"
        /// Spanish (Bolivia)
        static member inline esBO = Interop.mkConfigAttr "locale" "es-BO"
        /// Spanish (Chile)
        static member inline esCL = Interop.mkConfigAttr "locale" "es-CL"
        /// Spanish (Colombia)
        static member inline esCO = Interop.mkConfigAttr "locale" "es-CO"
        /// Spanish (Costa Rica)
        static member inline esCR = Interop.mkConfigAttr "locale" "es-CR"
        /// Spanish (Dominican Republic)
        static member inline esDO = Interop.mkConfigAttr "locale" "es-DO"
        /// Spanish (Ecuador)
        static member inline esEC = Interop.mkConfigAttr "locale" "es-EC"
        /// Spanish (El Salvador)
        static member inline esSV = Interop.mkConfigAttr "locale" "es-SV"
        /// Spanish (Equatorial Guinea)
        static member inline esGQ = Interop.mkConfigAttr "locale" "es-GQ"
        /// Spanish (Guatemala)
        static member inline esGT = Interop.mkConfigAttr "locale" "es-GT"
        /// Spanish (Honduras)
        static member inline esHN = Interop.mkConfigAttr "locale" "es-HN"
        /// Spanish (Latin America)
        static member inline es419 = Interop.mkConfigAttr "locale" "es-419"
        /// Spanish (Mexico)
        static member inline esMX = Interop.mkConfigAttr "locale" "es-MX"
        /// Spanish (Nicaragua)
        static member inline esNI = Interop.mkConfigAttr "locale" "es-NI"
        /// Spanish (Panama)
        static member inline esPA = Interop.mkConfigAttr "locale" "es-PA"
        /// Spanish (Paraguay)
        static member inline esPY = Interop.mkConfigAttr "locale" "es-PY"
        /// Spanish (Peru)
        static member inline esPE = Interop.mkConfigAttr "locale" "es-PE"
        /// Spanish (Puerto Rico)
        static member inline esPR = Interop.mkConfigAttr "locale" "es-PR"
        /// Spanish (Spain)
        static member inline esES = Interop.mkConfigAttr "locale" "es-ES"
        /// Spanish (United States)
        static member inline esUS = Interop.mkConfigAttr "locale" "es-US"
        /// Spanish (Uruguay)
        static member inline esUY = Interop.mkConfigAttr "locale" "es-UY"
        /// Spanish (Venezuela)
        static member inline esVE = Interop.mkConfigAttr "locale" "es-VE"
        /// Spanish
        static member inline es = Interop.mkConfigAttr "locale" "es"
        /// Swahili (Kenya)
        static member inline swKE = Interop.mkConfigAttr "locale" "sw-KE"
        /// Swahili (Tanzania)
        static member inline swTZ = Interop.mkConfigAttr "locale" "sw-TZ"
        /// Swahili
        static member inline sw = Interop.mkConfigAttr "locale" "sw"
        /// Swedish (Finland)
        static member inline svFI = Interop.mkConfigAttr "locale" "sv-FI"
        /// Swedish (Sweden)
        static member inline svSE = Interop.mkConfigAttr "locale" "sv-SE"
        /// Swedish
        static member inline sv = Interop.mkConfigAttr "locale" "sv"
        /// Swiss German (Switzerland)
        static member inline gswCH = Interop.mkConfigAttr "locale" "gsw-CH"
        /// Swiss German
        static member inline gsw = Interop.mkConfigAttr "locale" "gsw"
        /// Tachelhit (Latin)
        static member inline shiLatn = Interop.mkConfigAttr "locale" "shi-Latn"
        /// Tachelhit (Latin, Morocco)
        static member inline shiLatnMA = Interop.mkConfigAttr "locale" "shi-Latn-MA"
        /// Tachelhit (Tifinagh)
        static member inline shiTfng = Interop.mkConfigAttr "locale" "shi-Tfng"
        /// Tachelhit (Tifinagh, Morocco)
        static member inline shiTfngMA = Interop.mkConfigAttr "locale" "shi-Tfng-MA"
        /// Tachelhit
        static member inline shi = Interop.mkConfigAttr "locale" "shi"
        /// Taita (Kenya)
        static member inline davKE = Interop.mkConfigAttr "locale" "dav-KE"
        /// Taita
        static member inline dav = Interop.mkConfigAttr "locale" "dav"
        /// Tamil (India)
        static member inline taIN = Interop.mkConfigAttr "locale" "ta-IN"
        /// Tamil (Sri Lanka)
        static member inline taLK = Interop.mkConfigAttr "locale" "ta-LK"
        /// Tamil
        static member inline ta = Interop.mkConfigAttr "locale" "ta"
        /// Telugu (India)
        static member inline teIN = Interop.mkConfigAttr "locale" "te-IN"
        /// Telugu
        static member inline te = Interop.mkConfigAttr "locale" "te"
        /// Teso (Kenya)
        static member inline teoKE = Interop.mkConfigAttr "locale" "teo-KE"
        /// Teso (Uganda)
        static member inline teoUG = Interop.mkConfigAttr "locale" "teo-UG"
        /// Teso
        static member inline teo = Interop.mkConfigAttr "locale" "teo"
        /// Thai (Thailand)
        static member inline thTH = Interop.mkConfigAttr "locale" "th-TH"
        /// Thai
        static member inline th = Interop.mkConfigAttr "locale" "th"
        /// Tibetan (China)
        static member inline boCN = Interop.mkConfigAttr "locale" "bo-CN"
        /// Tibetan (India)
        static member inline boIN = Interop.mkConfigAttr "locale" "bo-IN"
        /// Tibetan
        static member inline bo = Interop.mkConfigAttr "locale" "bo"
        /// Tigrinya (Eritrea)
        static member inline tiER = Interop.mkConfigAttr "locale" "ti-ER"
        /// Tigrinya (Ethiopia)
        static member inline tiET = Interop.mkConfigAttr "locale" "ti-ET"
        /// Tigrinya
        static member inline ti = Interop.mkConfigAttr "locale" "ti"
        /// Tonga (Tonga)
        static member inline toTO = Interop.mkConfigAttr "locale" "to-TO"
        /// Tonga
        static member inline to' = Interop.mkConfigAttr "locale" "to"
        /// Turkish (Turkey)
        static member inline trTR = Interop.mkConfigAttr "locale" "tr-TR"
        /// Turkish
        static member inline tr = Interop.mkConfigAttr "locale" "tr"
        /// Ukrainian (Ukraine)
        static member inline ukUA = Interop.mkConfigAttr "locale" "uk-UA"
        /// Ukrainian
        static member inline uk = Interop.mkConfigAttr "locale" "uk"
        /// Urdu (India)
        static member inline urIN = Interop.mkConfigAttr "locale" "ur-IN"
        /// Urdu (Pakistan)
        static member inline urPK = Interop.mkConfigAttr "locale" "ur-PK"
        /// Urdu
        static member inline ur = Interop.mkConfigAttr "locale" "ur"
        /// Uzbek (Arabic)
        static member inline uzArab = Interop.mkConfigAttr "locale" "uz-Arab"
        /// Uzbek (Arabic, Afghanistan)
        static member inline uzArabAF = Interop.mkConfigAttr "locale" "uz-Arab-AF"
        /// Uzbek (Cyrillic)
        static member inline uzCyrl = Interop.mkConfigAttr "locale" "uz-Cyrl"
        /// Uzbek (Cyrillic, Uzbekistan)
        static member inline uzCyrlUZ = Interop.mkConfigAttr "locale" "uz-Cyrl-UZ"
        /// Uzbek (Latin)
        static member inline uzLatn = Interop.mkConfigAttr "locale" "uz-Latn"
        /// Uzbek (Latin, Uzbekistan)
        static member inline uzLatnUZ = Interop.mkConfigAttr "locale" "uz-Latn-UZ"
        /// Uzbek
        static member inline uz = Interop.mkConfigAttr "locale" "uz"
        /// Vietnamese (Vietnam)
        static member inline viVN = Interop.mkConfigAttr "locale" "vi-VN"
        /// Vietnamese
        static member inline vi = Interop.mkConfigAttr "locale" "vi"
        /// Vunjo (Tanzania)
        static member inline vunTZ = Interop.mkConfigAttr "locale" "vun-TZ"
        /// Vunjo
        static member inline vun = Interop.mkConfigAttr "locale" "vun"
        /// Welsh (United Kingdom)
        static member inline cyGB = Interop.mkConfigAttr "locale" "cy-GB"
        /// Welsh
        static member inline cy = Interop.mkConfigAttr "locale" "cy"
        /// Yoruba (Nigeria)
        static member inline yoNG = Interop.mkConfigAttr "locale" "yo-NG"
        /// Yoruba
        static member inline yo = Interop.mkConfigAttr "locale" "yo"
        /// Zulu (South Africa)
        static member inline zuZA = Interop.mkConfigAttr "locale" "zu-ZA"
        /// Zulu
        static member inline zu = Interop.mkConfigAttr "locale" "zu"

    /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
    [<Erase>]
    type scrollZoom =
        static member inline cartesian = Interop.mkConfigAttr "scrollZoom" "cartesian"
        static member inline false' = Interop.mkConfigAttr "scrollZoom" false
        static member inline geo = Interop.mkConfigAttr "scrollZoom" "geo"
        static member inline gl3d = Interop.mkConfigAttr "scrollZoom" "gl3d"
        static member inline mapbox = Interop.mkConfigAttr "scrollZoom" "mapbox"
        static member inline true' = Interop.mkConfigAttr "scrollZoom" true

