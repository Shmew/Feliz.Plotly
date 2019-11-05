namespace Feliz.Plotly

open Fable.Core
open System.ComponentModel

[<RequireQualifiedAccess>]
type PlotData =
    | Bool of bool seq
    | BoolOption of bool option seq
    | Float of float seq
    | FloatOption of float option seq
    | Int of int seq
    | IntOption of int option seq
    | String of string seq
    | StringOption of string option seq

[<EditorBrowsable(EditorBrowsableState.Never)>]
module PlotData =

    let asDataResize data =
        match data with
        | PlotData.Bool b -> b |> ResizeArray |> U8.Case1
        | PlotData.BoolOption b -> b |> ResizeArray |> U8.Case2
        | PlotData.Float f -> f |> ResizeArray |> U8.Case3
        | PlotData.FloatOption f -> f |> ResizeArray |> U8.Case4
        | PlotData.Int i -> i |> ResizeArray |> U8.Case5
        | PlotData.IntOption i -> i |> ResizeArray |> U8.Case6
        | PlotData.String s -> s |> ResizeArray |> U8.Case7
        | PlotData.StringOption s -> s |> ResizeArray |> U8.Case8
