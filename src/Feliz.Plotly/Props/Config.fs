namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open System
open Browser.Types
open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type config =
    /// Determines whether the graphs are interactive or not. If *false*, no interactivity, for export or image generation.
    static member inline staticPlot (value: bool) = Interop.mkPlotAttr "staticPlot" value
    /// Sets base URL for the 'Edit in Chart Studio' (aka sendDataToCloud) mode bar button and the showLink/sendData on-graph link
    static member inline plotlyServerURL (value: string) = Interop.mkPlotAttr "plotlyServerURL" value
    /// Determines whether the graph is editable or not. Sets all pieces of `edits` unless a separate `edits` config item overrides individual parts.
    static member inline editable (value: bool) = Interop.mkPlotAttr "editable" value
    /// Determines whether the graphs are plotted with respect to layout.autosize:true and infer its container size.
    static member inline autosizable (value: bool) = Interop.mkPlotAttr "autosizable" value
    /// Determines whether to change the layout size when window is resized. In v2, this option will be removed and will always be true.
    static member inline responsive (value: bool) = Interop.mkPlotAttr "responsive" value
    /// When `layout.autosize` is turned on, determines whether the graph fills the container (the default) or the screen (if set to *true*).
    static member inline fillFrame (value: bool) = Interop.mkPlotAttr "fillFrame" value
    /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
    static member inline frameMargins (value: int) = Interop.mkPlotAttr "frameMargins" value
    /// When `layout.autosize` is turned on, set the frame margins in fraction of the graph size.
    static member inline frameMargins (value: float) = Interop.mkPlotAttr "frameMargins" value
    /// Determines whether mouse wheel or two-finger scroll zooms is enable. Turned on by default for gl3d, geo and mapbox subplots (as these subplot types do not have zoombox via pan), but turned off by default for cartesian subplots. Set `scrollZoom` to *false* to disable scrolling for all subplots.
    static member inline scrollZoom (values: seq<string>) = Interop.mkPlotAttr "scrollZoom" values
    /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
    static member inline doubleClickDelay (value: int) = Interop.mkPlotAttr "doubleClickDelay" value
    /// Sets the delay for registering a double-click in ms. This is the time interval (in ms) between first mousedown and 2nd mouseup to constitute a double-click. This setting propagates to all on-subplot double clicks (except for geo and mapbox) and on-legend double clicks.
    static member inline doubleClickDelay (value: float) = Interop.mkPlotAttr "doubleClickDelay" value
    /// Set to *false* to omit cartesian axis pan/zoom drag handles.
    static member inline showAxisDragHandles (value: bool) = Interop.mkPlotAttr "showAxisDragHandles" value
    /// Set to *false* to omit direct range entry at the pan/zoom drag points, note that `showAxisDragHandles` must be enabled to have an effect.
    static member inline showAxisRangeEntryBoxes (value: bool) = Interop.mkPlotAttr "showAxisRangeEntryBoxes" value
    /// Determines whether or not tips are shown while interacting with the resulting graphs.
    static member inline showTips (value: bool) = Interop.mkPlotAttr "showTips" value
    /// Determines whether a link to plot.ly is displayed at the bottom right corner of resulting graphs. Use with `sendData` and `linkText`.
    static member inline showLink (value: bool) = Interop.mkPlotAttr "showLink" value
    /// Sets the text appearing in the `showLink` link.
    static member inline linkText (value: string) = Interop.mkPlotAttr "linkText" value
    /// If *showLink* is true, does it contain data just link to a plot.ly file?
    static member inline sendData (value: bool) = Interop.mkPlotAttr "sendData" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: bool) = Interop.mkPlotAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<bool>) = Interop.mkPlotAttr "showSources" values
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: string) = Interop.mkPlotAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<string>) = Interop.mkPlotAttr "showSources" values
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: int) = Interop.mkPlotAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<int>) = Interop.mkPlotAttr "showSources" values
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (value: float) = Interop.mkPlotAttr "showSources" value
    /// Adds a source-displaying function to show sources on the resulting graphs.
    static member inline showSources (values: seq<float>) = Interop.mkPlotAttr "showSources" values
    /// Should we include a ModeBar button, labeled \"Edit in Chart Studio\", that sends this chart to plot.ly or another plotly server as specified by `plotlyServerURL` for editing, export, etc? Prior to version 1.43.0 this button was included by default, now it is opt-in using this flag. Note that this button can (depending on `plotlyServerURL`) send your data to an external server. However that server does not persist your data until you arrive at the Chart Studio and explicitly click \"Save\".
    static member inline showSendToCloud (value: bool) = Interop.mkPlotAttr "showSendToCloud" value
    /// Same as `showSendToCloud`, but use a pencil icon instead of a floppy-disk. Note that if both `showSendToCloud` and `showEditInChartStudio` are turned, only `showEditInChartStudio` will be honored.
    static member inline showEditInChartStudio (value: bool) = Interop.mkPlotAttr "showEditInChartStudio" value
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: bool) = Interop.mkPlotAttr "modeBarButtonsToRemove" value
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: seq<bool>) = Interop.mkPlotAttr "modeBarButtonsToRemove" values
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: string) = Interop.mkPlotAttr "modeBarButtonsToRemove" value
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: seq<string>) = Interop.mkPlotAttr "modeBarButtonsToRemove" values
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: int) = Interop.mkPlotAttr "modeBarButtonsToRemove" value
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: seq<int>) = Interop.mkPlotAttr "modeBarButtonsToRemove" values
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (value: float) = Interop.mkPlotAttr "modeBarButtonsToRemove" value
    /// Remove mode bar buttons by name. See ./components/modebar/buttons.js for the list of names.
    static member inline modeBarButtonsToRemove (values: seq<float>) = Interop.mkPlotAttr "modeBarButtonsToRemove" values
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: bool) = Interop.mkPlotAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<bool>) = Interop.mkPlotAttr "modeBarButtonsToAdd" values
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: string) = Interop.mkPlotAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<string>) = Interop.mkPlotAttr "modeBarButtonsToAdd" values
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: int) = Interop.mkPlotAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<int>) = Interop.mkPlotAttr "modeBarButtonsToAdd" values
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (value: float) = Interop.mkPlotAttr "modeBarButtonsToAdd" value
    /// Add mode bar button using config objects See ./components/modebar/buttons.js for list of arguments.
    static member inline modeBarButtonsToAdd (values: seq<float>) = Interop.mkPlotAttr "modeBarButtonsToAdd" values
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: bool) = Interop.mkPlotAttr "modeBarButtons" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<bool>) = Interop.mkPlotAttr "modeBarButtons" values
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: string) = Interop.mkPlotAttr "modeBarButtons" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<string>) = Interop.mkPlotAttr "modeBarButtons" values
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: int) = Interop.mkPlotAttr "modeBarButtons" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<int>) = Interop.mkPlotAttr "modeBarButtons" values
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (value: float) = Interop.mkPlotAttr "modeBarButtons" value
    /// Define fully custom mode bar buttons as nested array, where the outer arrays represents button groups, and the inner arrays have buttons config objects or names of default buttons See ./components/modebar/buttons.js for more info.
    static member inline modeBarButtons (values: seq<float>) = Interop.mkPlotAttr "modeBarButtons" values
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: bool) = Interop.mkPlotAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<bool>) = Interop.mkPlotAttr "toImageButtonOptions" values
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: string) = Interop.mkPlotAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<string>) = Interop.mkPlotAttr "toImageButtonOptions" values
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: int) = Interop.mkPlotAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<int>) = Interop.mkPlotAttr "toImageButtonOptions" values
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (value: float) = Interop.mkPlotAttr "toImageButtonOptions" value
    /// Statically override options for toImage modebar button allowed keys are format, filename, width, height, scale see ../components/modebar/buttons.js
    static member inline toImageButtonOptions (values: seq<float>) = Interop.mkPlotAttr "toImageButtonOptions" values
    /// Determines whether or not the plotly logo is displayed on the end of the mode bar.
    static member inline displaylogo (value: bool) = Interop.mkPlotAttr "displaylogo" value
    /// watermark the images with the company's logo
    static member inline watermark (value: bool) = Interop.mkPlotAttr "watermark" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: int) = Interop.mkPlotAttr "plotGlPixelRatio" value
    /// Set the pixel ratio during WebGL image export. This config option was formerly named `plot3dPixelRatio` which is now deprecated.
    static member inline plotGlPixelRatio (value: float) = Interop.mkPlotAttr "plotGlPixelRatio" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: bool) = Interop.mkPlotAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<bool>) = Interop.mkPlotAttr "setBackground" values
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: string) = Interop.mkPlotAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<string>) = Interop.mkPlotAttr "setBackground" values
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: int) = Interop.mkPlotAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<int>) = Interop.mkPlotAttr "setBackground" values
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (value: float) = Interop.mkPlotAttr "setBackground" value
    /// Set function to add the background color (i.e. `layout.paper_color`) to a different container. This function take the graph div as first argument and the current background color as second argument. Alternatively, set to string *opaque* to ensure there is white behind it.
    static member inline setBackground (values: seq<float>) = Interop.mkPlotAttr "setBackground" values
    /// Set the URL to topojson used in geo charts. By default, the topojson files are fetched from cdn.plot.ly. For example, set this option to: <path-to-plotly.js>/dist/topojson/ to render geographical feature using the topojson files that ship with the plotly.js module.
    static member inline topojsonURL (value: string) = Interop.mkPlotAttr "topojsonURL" value
    /// Mapbox access token (required to plot mapbox trace types) If using an Mapbox Atlas server, set this option to '' so that plotly.js won't attempt to authenticate to the public Mapbox server.
    static member inline mapboxAccessToken (value: string) = Interop.mkPlotAttr "mapboxAccessToken" value
    /// Turn all console logging on or off (errors will be thrown) This should ONLY be set via Plotly.setPlotConfig Available levels: 0: no logs 1: warnings and errors, but not informational messages 2: verbose logs
    static member inline logging (value: bool) = Interop.mkPlotAttr "logging" value
    /// Sets the length of the undo/redo queue.
    static member inline queueLength (value: int) = Interop.mkPlotAttr "queueLength" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (value: bool) = Interop.mkPlotAttr "globalTransforms" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (values: seq<bool>) = Interop.mkPlotAttr "globalTransforms" values
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (value: string) = Interop.mkPlotAttr "globalTransforms" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (values: seq<string>) = Interop.mkPlotAttr "globalTransforms" values
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (value: int) = Interop.mkPlotAttr "globalTransforms" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (values: seq<int>) = Interop.mkPlotAttr "globalTransforms" values
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (value: float) = Interop.mkPlotAttr "globalTransforms" value
    /// Set global transform to be applied to all traces with no specification needed
    static member inline globalTransforms (values: seq<float>) = Interop.mkPlotAttr "globalTransforms" values
    /// Which localization should we use? Should be a string like 'en' or 'en-US'.
    static member inline locale (value: string) = Interop.mkPlotAttr "locale" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: bool) = Interop.mkPlotAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<bool>) = Interop.mkPlotAttr "locales" values
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: string) = Interop.mkPlotAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<string>) = Interop.mkPlotAttr "locales" values
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: int) = Interop.mkPlotAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<int>) = Interop.mkPlotAttr "locales" values
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (value: float) = Interop.mkPlotAttr "locales" value
    /// Localization definitions Locales can be provided either here (specific to one chart) or globally by registering them as modules. Should be an object of objects {locale: {dictionary: {...}, format: {...}}} {   da: {       dictionary: {'Reset axes': 'Nulstil aksler', ...},       format: {months: [...], shortMonths: [...]}   },   ... } All parts are optional. When looking for translation or format fields, we look first for an exact match in a config locale, then in a registered module. If those fail, we strip off any regionalization ('en-US' -> 'en') and try each (config, registry) again. The final fallback for translation is untranslated (which is US English) and for formats is the base English (the only consequence being the last fallback date format %x is DD/MM/YYYY instead of MM/DD/YYYY). Currently `grouping` and `currency` are ignored for our automatic number formatting, but can be used in custom formats.
    static member inline locales (values: seq<float>) = Interop.mkPlotAttr "locales" values

module config =
    /// Sets the double click interaction mode. Has an effect only in cartesian plots. If *false*, double click is disable. If *reset*, double click resets the axis ranges to their initial values. If *autosize*, double click set the axis ranges to their autorange values. If *reset+autosize*, the odd double clicks resets the axis ranges to their initial values and even double clicks set the axis ranges to their autorange values.
    [<Erase>]
    type doubleClick =
        static member inline false' = Interop.mkPlotAttr "doubleClick" false
        static member inline reset = Interop.mkPlotAttr "doubleClick" "reset"
        static member inline autosize = Interop.mkPlotAttr "doubleClick" "autosize"
        static member inline resetAndAutosize = Interop.mkPlotAttr "doubleClick" "reset+autosize"

    /// Determines the mode bar display mode. If *true*, the mode bar is always visible. If *false*, the mode bar is always hidden. If *hover*, the mode bar is visible while the mouse cursor is on the graph container.
    [<Erase>]
    type displayModeBar =
        static member inline hover = Interop.mkPlotAttr "displayModeBar" "hover"
        static member inline true' = Interop.mkPlotAttr "displayModeBar" true
        static member inline false' = Interop.mkPlotAttr "displayModeBar" false

    [<Erase>]
    type edits =
        /// Determines if the main anchor of the annotation is editable. The main anchor corresponds to the text (if no arrow) or the arrow (which drags the whole thing leaving the arrow length & direction unchanged).
        static member inline annotationPosition (value: bool) = Interop.mkPlotAttr "annotationPosition" value
        /// Has only an effect for annotations with arrows. Enables changing the length and direction of the arrow.
        static member inline annotationTail (value: bool) = Interop.mkPlotAttr "annotationTail" value
        /// Enables editing annotation text.
        static member inline annotationText (value: bool) = Interop.mkPlotAttr "annotationText" value
        /// Enables editing axis title text.
        static member inline axisTitleText (value: bool) = Interop.mkPlotAttr "axisTitleText" value
        /// Enables moving colorbars.
        static member inline colorbarPosition (value: bool) = Interop.mkPlotAttr "colorbarPosition" value
        /// Enables editing colorbar title text.
        static member inline colorbarTitleText (value: bool) = Interop.mkPlotAttr "colorbarTitleText" value
        /// Enables moving the legend.
        static member inline legendPosition (value: bool) = Interop.mkPlotAttr "legendPosition" value
        /// Enables editing the trace name fields from the legend
        static member inline legendText (value: bool) = Interop.mkPlotAttr "legendText" value
        /// Enables moving shapes.
        static member inline shapePosition (value: bool) = Interop.mkPlotAttr "shapePosition" value
        /// Enables editing the global layout title.
        static member inline titleText (value: bool) = Interop.mkPlotAttr "titleText" value

