namespace Feliz.Plotly

open System.ComponentModel

[<AutoOpen; EditorBrowsable(EditorBrowsableState.Never)>]
module Utils =
    open Fable.Core

    module U4 =
        let mapArrayToResize (input: U4<'a [],'b [],'c [], 'd []>) =
            match input with
            | U4.Case1 a -> a |> ResizeArray |> U4.Case1
            | U4.Case2 b -> b |> ResizeArray |> U4.Case2
            | U4.Case3 c -> c |> ResizeArray |> U4.Case3
            | U4.Case4 d -> d |> ResizeArray |> U4.Case4

        let mapListToResize (input: U4<'a list,'b list,'c list, 'd list>) =
            match input with
            | U4.Case1 a -> a |> ResizeArray |> U4.Case1
            | U4.Case2 b -> b |> ResizeArray |> U4.Case2
            | U4.Case3 c -> c |> ResizeArray |> U4.Case3
            | U4.Case4 d -> d |> ResizeArray |> U4.Case4
