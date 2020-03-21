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
    static member inline locales (value: bool) = Interop.mkConfigAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<bool>) = Interop.mkConfigAttr "locales" (values |> ResizeArray)
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: System.DateTime) = Interop.mkConfigAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<System.DateTime>) = Interop.mkConfigAttr "locales" (values |> ResizeArray)
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: int) = Interop.mkConfigAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<int>) = Interop.mkConfigAttr "locales" (values |> ResizeArray)
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: float) = Interop.mkConfigAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<float>) = Interop.mkConfigAttr "locales" (values |> ResizeArray)
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: string) = Interop.mkConfigAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<string>) = Interop.mkConfigAttr "locales" (values |> ResizeArray)
    /// Turn all console logging on or off (errors will be thrown) This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings and errors, but not informational messages 2: verbose logs
    static member inline logging (value: int) = Interop.mkConfigAttr "logging" value
    /// Mapbox access token (required to plot mapbox trace types) If using an Mapbox Atlas server, set this option to '' so that plotly.js won't attempt to authenticate to the public Mapbox server.
    static member inline mapboxAccessToken (value: string) = Interop.mkConfigAttr "mapboxAccessToken" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: IButtonsProperty) = Interop.mkConfigAttr "modeBarButtons" (unbox<IModeBarButtonsProperty> value |> Array.singleton |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: IModeBarButtonsProperty) = Interop.mkConfigAttr "modeBarButtons" (value |> Array.singleton |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<IModeBarButtonsProperty>) = Interop.mkConfigAttr "modeBarButtons" (values |> ResizeArray |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<IButtonsProperty>) = Interop.mkConfigAttr "modeBarButtons" (values |> Seq.map unbox<IModeBarButtonsProperty> |> ResizeArray |> Array.singleton)
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<seq<#IModeBarButtonsProperty>>) = Interop.mkConfigAttr "modeBarButtons" (values |> Seq.map unbox<IModeBarButtonsProperty> |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: bool) = Interop.mkConfigAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<bool>) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: System.DateTime) = Interop.mkConfigAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<System.DateTime>) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: int) = Interop.mkConfigAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<int>) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: float) = Interop.mkConfigAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<float>) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: string) = Interop.mkConfigAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<string>) = Interop.mkConfigAttr "modeBarButtonsToAdd" (values |> ResizeArray)
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: #IModeBarButtonsProperty) = Interop.mkConfigAttr "modeBarButtonsToRemove" (value |> Array.singleton)
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: seq<#IModeBarButtonsProperty>) = Interop.mkConfigAttr "modeBarButtonsToRemove" (values |> ResizeArray)
    /// Set on-graph logging (notifier) level This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no on-graph logs 1: warnings and errors, but not informational messages 2: verbose logs
    static member inline notifyOnLogging (value: int) = Interop.mkConfigAttr "notifyOnLogging" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: int) = Interop.mkConfigAttr "plotGlPixelRatio" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: float) = Interop.mkConfigAttr "plotGlPixelRatio" value
    /// Sets base URL for the 'Edit in Chart Studio' (aka sendDataToCloud) mode bar button and the showLink/sendData on-graph link
    static member inline plotlyServerURL (value: string) = Interop.mkConfigAttr "plotlyServerURL" value
    /// Sets the length of the undo/redo queue.
    static member inline queueLength (value: int) = Interop.mkConfigAttr "queueLength" value
    /// Determines whether to change the layout size when window is resized. In v2, this option will be removed and will always be true.
    static member inline responsive (value: bool) = Interop.mkConfigAttr "responsive" value
    /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
    static member inline scrollZoom (properties: #IConfigProperty list) = Interop.mkConfigAttr "scrollZoom" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// If *showLink* is true, does it contain data just link to a plot.ly file?
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
    /// Determines whether a link to plot.ly is displayed at the bottom right corner of resulting graphs. Use with `sendData` and `linkText`.
    static member inline showLink (value: bool) = Interop.mkConfigAttr "showLink" value
    /// Should we include a ModeBar button, labeled \"Edit in Chart Studio\", that sends this chart to plot.ly or another plotly server as specified by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0 this button was included by default, now it is opt-in using this flag. Note that this button can (depending on `plotlyServerURL`) send your data to an external server. However that server does not persist your data until you arrive at the Chart Studio and explicitly click \"Save\".
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
    static member inline toImageButtonOptions (value: bool) = Interop.mkConfigAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<bool>) = Interop.mkConfigAttr "toImageButtonOptions" (values |> ResizeArray)
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: System.DateTime) = Interop.mkConfigAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<System.DateTime>) = Interop.mkConfigAttr "toImageButtonOptions" (values |> ResizeArray)
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: int) = Interop.mkConfigAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<int>) = Interop.mkConfigAttr "toImageButtonOptions" (values |> ResizeArray)
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: float) = Interop.mkConfigAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<float>) = Interop.mkConfigAttr "toImageButtonOptions" (values |> ResizeArray)
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: string) = Interop.mkConfigAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<string>) = Interop.mkConfigAttr "toImageButtonOptions" (values |> ResizeArray)
    /// Set the URL to topojson used in geo charts. By default, the topojson files are fetched from cdn.plot.ly. For example, set this option to: <path-to-plotly.js>/dist/topojson/ to render geographical feature using the topojson files that ship with the plotly.js module.
    static member inline topojsonURL (value: string) = Interop.mkConfigAttr "topojsonURL" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkConfigAttr "globalTransforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// watermark the images with the company's logo
    static member inline watermark (value: bool) = Interop.mkConfigAttr "watermark" value

[<RequireQualifiedAccess>]
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

    /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
    [<Erase>]
    type scrollZoom =
        static member inline cartesian = Interop.mkConfigAttr "scrollZoom" "cartesian"
        static member inline false' = Interop.mkConfigAttr "scrollZoom" false
        static member inline geo = Interop.mkConfigAttr "scrollZoom" "geo"
        static member inline gl3d = Interop.mkConfigAttr "scrollZoom" "gl3d"
        static member inline mapbox = Interop.mkConfigAttr "scrollZoom" "mapbox"
        static member inline true' = Interop.mkConfigAttr "scrollZoom" true

