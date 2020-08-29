namespace Feliz.Plotly

(*////////////////////////////////
/// THIS FILE IS AUTO-GENERATED //
////////////////////////////////*)

open Fable.Core
open Fable.Core.JsInterop
open Feliz

[<Erase>]
type candlestick =
    /// Sets the close values.
    static member inline close (value: bool) = Interop.mkCandlestickAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<bool>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (value: System.DateTime) = Interop.mkCandlestickAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (value: float) = Interop.mkCandlestickAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<float>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (value: int) = Interop.mkCandlestickAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<int>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (value: string) = Interop.mkCandlestickAttr "close" (value |> Array.singleton)
    /// Sets the close values.
    static member inline close (values: seq<string>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<bool list>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<bool []>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<seq<string>>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<string list>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<string []>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<seq<int>>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<int list>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<int []>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<seq<float>>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<float list>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<float []>) = Interop.mkCandlestickAttr "close" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<PlotData>) = Interop.mkCandlestickAttr "close" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<bool option>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<int option>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<float option>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the close values.
    static member inline close (values: seq<string option>) = Interop.mkCandlestickAttr "close" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  close .
    static member inline closesrc (value: string) = Interop.mkCandlestickAttr "closesrc" value
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: bool) = Interop.mkCandlestickAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: System.DateTime) = Interop.mkCandlestickAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: float) = Interop.mkCandlestickAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: int) = Interop.mkCandlestickAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (value: string) = Interop.mkCandlestickAttr "customdata" (value |> Array.singleton)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool list>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool []>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<string>>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string list>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string []>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<int>>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int list>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int []>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<seq<float>>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float list>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float []>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<PlotData>) = Interop.mkCandlestickAttr "customdata" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<bool option>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<int option>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<float option>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Assigns extra data each datum. This may be useful when listening to hover, click and selection events. Note that, *scatter* traces also appends customdata items in the markers DOM elements
    static member inline customdata (values: seq<string option>) = Interop.mkCandlestickAttr "customdata" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  customdata .
    static member inline customdatasrc (value: string) = Interop.mkCandlestickAttr "customdatasrc" value
    static member inline decreasing (properties: #IDecreasingProperty list) = Interop.mkCandlestickAttr "decreasing" (createObj !!properties)
    /// Sets the high values.
    static member inline high (value: bool) = Interop.mkCandlestickAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<bool>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (value: System.DateTime) = Interop.mkCandlestickAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (value: float) = Interop.mkCandlestickAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<float>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (value: int) = Interop.mkCandlestickAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<int>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (value: string) = Interop.mkCandlestickAttr "high" (value |> Array.singleton)
    /// Sets the high values.
    static member inline high (values: seq<string>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<bool list>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<bool []>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<seq<string>>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<string list>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<string []>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<seq<int>>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<int list>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<int []>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<seq<float>>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<float list>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<float []>) = Interop.mkCandlestickAttr "high" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<PlotData>) = Interop.mkCandlestickAttr "high" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<bool option>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<int option>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<float option>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the high values.
    static member inline high (values: seq<string option>) = Interop.mkCandlestickAttr "high" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  high .
    static member inline highsrc (value: string) = Interop.mkCandlestickAttr "highsrc" value
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    static member inline hoverinfo (properties: #ICandlestickProperty list) = Interop.mkCandlestickAttr "hoverinfo" (properties |> List.map (Bindings.getKV >> snd >> unbox) |> String.concat "+")
    /// Sets the source reference on Chart Studio Cloud for  hoverinfo .
    static member inline hoverinfosrc (value: string) = Interop.mkCandlestickAttr "hoverinfosrc" value
    static member inline hoverlabel (properties: #IHoverlabelProperty list) = Interop.mkCandlestickAttr "hoverlabel" (createObj !!properties)
    /// Same as `text`.
    static member inline hovertext (value: string) = Interop.mkCandlestickAttr "hovertext" value
    /// Same as `text`.
    static member inline hovertext (values: seq<string>) = Interop.mkCandlestickAttr "hovertext" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  hovertext .
    static member inline hovertextsrc (value: string) = Interop.mkCandlestickAttr "hovertextsrc" value
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: bool) = Interop.mkCandlestickAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: System.DateTime) = Interop.mkCandlestickAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: float) = Interop.mkCandlestickAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: int) = Interop.mkCandlestickAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (value: string) = Interop.mkCandlestickAttr "ids" (value |> Array.singleton)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool list>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool []>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<string>>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string list>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string []>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<int>>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int list>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int []>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<seq<float>>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float list>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float []>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<PlotData>) = Interop.mkCandlestickAttr "ids" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<bool option>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<int option>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<float option>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Assigns id labels to each datum. These ids for object constancy of data points during animation. Should be an array of strings, not numbers or any other type.
    static member inline ids (values: seq<string option>) = Interop.mkCandlestickAttr "ids" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  ids .
    static member inline idssrc (value: string) = Interop.mkCandlestickAttr "idssrc" value
    static member inline increasing (properties: #IIncreasingProperty list) = Interop.mkCandlestickAttr "increasing" (createObj !!properties)
    /// Sets the legend group for this trace. Traces part of the same legend group hide/show at the same time when toggling legend items.
    static member inline legendgroup (value: string) = Interop.mkCandlestickAttr "legendgroup" value
    static member inline line (properties: #ILineProperty list) = Interop.mkCandlestickAttr "line" (createObj !!properties)
    /// Sets the low values.
    static member inline low (value: bool) = Interop.mkCandlestickAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<bool>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (value: System.DateTime) = Interop.mkCandlestickAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (value: float) = Interop.mkCandlestickAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<float>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (value: int) = Interop.mkCandlestickAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<int>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (value: string) = Interop.mkCandlestickAttr "low" (value |> Array.singleton)
    /// Sets the low values.
    static member inline low (values: seq<string>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<bool list>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<bool []>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<seq<string>>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<string list>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<string []>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<seq<int>>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<int list>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<int []>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<seq<float>>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<float list>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<float []>) = Interop.mkCandlestickAttr "low" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<PlotData>) = Interop.mkCandlestickAttr "low" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<bool option>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<int option>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<float option>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the low values.
    static member inline low (values: seq<string option>) = Interop.mkCandlestickAttr "low" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  low .
    static member inline lowsrc (value: string) = Interop.mkCandlestickAttr "lowsrc" value
    /// Sets the source reference on Chart Studio Cloud for  meta .
    static member inline metasrc (value: string) = Interop.mkCandlestickAttr "metasrc" value
    /// Sets the trace name. The trace name appear as the legend item and on hover.
    static member inline name (value: string) = Interop.mkCandlestickAttr "name" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: int) = Interop.mkCandlestickAttr "opacity" value
    /// Sets the opacity of the trace.
    static member inline opacity (value: float) = Interop.mkCandlestickAttr "opacity" value
    /// Sets the open values.
    static member inline open' (value: bool) = Interop.mkCandlestickAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<bool>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (value: System.DateTime) = Interop.mkCandlestickAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (value: float) = Interop.mkCandlestickAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<float>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (value: int) = Interop.mkCandlestickAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<int>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (value: string) = Interop.mkCandlestickAttr "open" (value |> Array.singleton)
    /// Sets the open values.
    static member inline open' (values: seq<string>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<bool list>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<bool []>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<seq<string>>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<string list>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<string []>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<seq<int>>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<int list>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<int []>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<seq<float>>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<float list>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<float []>) = Interop.mkCandlestickAttr "open" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<PlotData>) = Interop.mkCandlestickAttr "open" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<bool option>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<int option>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<float option>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the open values.
    static member inline open' (values: seq<string option>) = Interop.mkCandlestickAttr "open" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  open .
    static member inline opensrc (value: string) = Interop.mkCandlestickAttr "opensrc" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: bool) = Interop.mkCandlestickAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<bool>) = Interop.mkCandlestickAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: System.DateTime) = Interop.mkCandlestickAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: int) = Interop.mkCandlestickAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<int>) = Interop.mkCandlestickAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: float) = Interop.mkCandlestickAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<float>) = Interop.mkCandlestickAttr "selectedpoints" (values |> ResizeArray)
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (value: string) = Interop.mkCandlestickAttr "selectedpoints" value
    /// Array containing integer indices of selected points. Has an effect only for traces that support selections. Note that an empty array means an empty selection where the `unselected` are turned on for all points, whereas, any other non-array values means no selection all where the `selected` and `unselected` styles have no effect.
    static member inline selectedpoints (values: seq<string>) = Interop.mkCandlestickAttr "selectedpoints" (values |> ResizeArray)
    /// Determines whether or not an item corresponding to this trace is shown in the legend.
    static member inline showlegend (value: bool) = Interop.mkCandlestickAttr "showlegend" value
    static member inline stream (properties: #IStreamProperty list) = Interop.mkCandlestickAttr "stream" (createObj !!properties)
    /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
    static member inline text (value: string) = Interop.mkCandlestickAttr "text" value
    /// Sets hover text elements associated with each sample point. If a single string, the same string appears over all the data points. If an array of string, the items are mapped in order to this trace's sample points.
    static member inline text (values: seq<string>) = Interop.mkCandlestickAttr "text" (values |> ResizeArray)
    /// Sets the source reference on Chart Studio Cloud for  text .
    static member inline textsrc (value: string) = Interop.mkCandlestickAttr "textsrc" value
    static member inline transforms (properties: #ITransformsProperty list) = Interop.mkCandlestickAttr "transforms" (properties |> List.map (Bindings.getKV >> snd) |> Array.ofList)
    /// Assign an id to this trace, Use this to provide object constancy between traces during animations and transitions.
    static member inline uid (value: string) = Interop.mkCandlestickAttr "uid" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: bool) = Interop.mkCandlestickAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<bool>) = Interop.mkCandlestickAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: System.DateTime) = Interop.mkCandlestickAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: int) = Interop.mkCandlestickAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<int>) = Interop.mkCandlestickAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: float) = Interop.mkCandlestickAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<float>) = Interop.mkCandlestickAttr "uirevision" (values |> ResizeArray)
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (value: string) = Interop.mkCandlestickAttr "uirevision" value
    /// Controls persistence of some user-driven changes to the trace: `constraintrange` in `parcoords` traces, as well as some `editable: true` modifications such as `name` and `colorbar.title`. Defaults to `layout.uirevision`. Note that other user-driven trace attribute changes are controlled by `layout` attributes: `trace.visible` is controlled by `layout.legend.uirevision`, `selectedpoints` is controlled by `layout.selectionrevision`, and `colorbar.(x|y)` (accessible with `config: {editable: true}`) is controlled by `layout.editrevision`. Trace changes are tracked by `uid`, which only falls back on trace index if no `uid` is provided. So if your app can add/remove traces before the end of the `data` array, such that the same trace has a different index, you can still preserve user-driven changes if you give each trace a `uid` that stays with it as it moves.
    static member inline uirevision (values: seq<string>) = Interop.mkCandlestickAttr "uirevision" (values |> ResizeArray)
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: int) = Interop.mkCandlestickAttr "whiskerwidth" value
    /// Sets the width of the whiskers relative to the box' width. For example, with 1, the whiskers are as wide as the box(es).
    static member inline whiskerwidth (value: float) = Interop.mkCandlestickAttr "whiskerwidth" value
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: bool) = Interop.mkCandlestickAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<bool>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: System.DateTime) = Interop.mkCandlestickAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<System.DateTime>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: float) = Interop.mkCandlestickAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<float>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: int) = Interop.mkCandlestickAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<int>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (value: string) = Interop.mkCandlestickAttr "x" (value |> Array.singleton)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<string>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<seq<bool>>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<bool list>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<bool []>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<seq<string>>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<string list>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<string []>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<seq<int>>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<int list>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<int []>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<seq<float>>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<float list>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<float []>) = Interop.mkCandlestickAttr "x" (values |> Seq.map ResizeArray |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<PlotData>) = Interop.mkCandlestickAttr "x" (values |> Seq.map PlotData.asDataResize |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<bool option>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<System.DateTime option>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<int option>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<float option>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets the x coordinates. If absent, linear coordinate will be generated.
    static member inline x (values: seq<string option>) = Interop.mkCandlestickAttr "x" (values |> ResizeArray)
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (anchorId: int) = Interop.mkCandlestickAttr "xaxis" (sprintf "x%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's x coordinates and a 2D cartesian x axis. If *x* (the default value), the x coordinates refer to `layout.xaxis`. If *x2*, the x coordinates refer to `layout.xaxis2`, and so on.
    static member inline xaxis (value: string) = Interop.mkCandlestickAttr "xaxis" value
    /// Sets the source reference on Chart Studio Cloud for  x .
    static member inline xsrc (value: string) = Interop.mkCandlestickAttr "xsrc" value
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (anchorId: int) = Interop.mkCandlestickAttr "yaxis" (sprintf "y%s" (if anchorId > 1 then (anchorId |> string) else ""))
    /// Sets a reference between this trace's y coordinates and a 2D cartesian y axis. If *y* (the default value), the y coordinates refer to `layout.yaxis`. If *y2*, the y coordinates refer to `layout.yaxis2`, and so on.
    static member inline yaxis (value: string) = Interop.mkCandlestickAttr "yaxis" value

[<Erase;RequireQualifiedAccess>]
module candlestick =
    /// Determines which trace information appear on hover. If `none` or `skip` are set, no information is displayed upon hovering. But, if `none` is set, click and hover events are still fired.
    [<Erase>]
    type hoverinfo =
        static member inline all = Interop.mkCandlestickAttr "hoverinfo" "all"
        static member inline none = Interop.mkCandlestickAttr "hoverinfo" "none"
        static member inline skip = Interop.mkCandlestickAttr "hoverinfo" "skip"
        static member inline name = Interop.mkCandlestickAttr "hoverinfo" "name"
        static member inline text = Interop.mkCandlestickAttr "hoverinfo" "text"
        static member inline x = Interop.mkCandlestickAttr "hoverinfo" "x"
        static member inline y = Interop.mkCandlestickAttr "hoverinfo" "y"
        static member inline z = Interop.mkCandlestickAttr "hoverinfo" "z"

    /// Determines whether or not this trace is visible. If *legendonly*, the trace is not drawn, but can appear as a legend item (provided that the legend itself is visible).
    [<Erase>]
    type visible =
        static member inline legendonly = Interop.mkCandlestickAttr "visible" "legendonly"
        static member inline false' = Interop.mkCandlestickAttr "visible" false
        static member inline true' = Interop.mkCandlestickAttr "visible" true

    /// Sets the calendar system to use with `x` date data.
    [<Erase>]
    type xcalendar =
        static member inline chinese = Interop.mkCandlestickAttr "xcalendar" "chinese"
        static member inline coptic = Interop.mkCandlestickAttr "xcalendar" "coptic"
        static member inline discworld = Interop.mkCandlestickAttr "xcalendar" "discworld"
        static member inline ethiopian = Interop.mkCandlestickAttr "xcalendar" "ethiopian"
        static member inline gregorian = Interop.mkCandlestickAttr "xcalendar" "gregorian"
        static member inline hebrew = Interop.mkCandlestickAttr "xcalendar" "hebrew"
        static member inline islamic = Interop.mkCandlestickAttr "xcalendar" "islamic"
        static member inline jalali = Interop.mkCandlestickAttr "xcalendar" "jalali"
        static member inline julian = Interop.mkCandlestickAttr "xcalendar" "julian"
        static member inline mayan = Interop.mkCandlestickAttr "xcalendar" "mayan"
        static member inline nanakshahi = Interop.mkCandlestickAttr "xcalendar" "nanakshahi"
        static member inline nepali = Interop.mkCandlestickAttr "xcalendar" "nepali"
        static member inline persian = Interop.mkCandlestickAttr "xcalendar" "persian"
        static member inline taiwan = Interop.mkCandlestickAttr "xcalendar" "taiwan"
        static member inline thai = Interop.mkCandlestickAttr "xcalendar" "thai"
        static member inline ummalqura = Interop.mkCandlestickAttr "xcalendar" "ummalqura"

