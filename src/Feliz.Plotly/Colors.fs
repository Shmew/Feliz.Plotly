namespace Feliz.Plotly

[<RequireQualifiedAccess>]
module color =
    module colorscale =
        open Feliz.color

        let private getScaled len n = n / (len - 1 |> float)

        let sequential (colors: string list) =
            colors |> List.mapi (fun i color -> [ (i |> float |> (getScaled colors.Length) |> string); color ])

        let sequentialMinus (colors: string list) =
            colors |> List.mapi (fun i color -> [ (i |> float |> (getScaled colors.Length) |> string); color ])

        let diverging (mid: float) (threshold: float) (colors: string list) =
            let colorListSize = colors.Length |> float

            let exceededMin, newMin =
                match mid - threshold with
                | min when min >= 0. -> false, min
                | _ -> true, 0.

            let exceededMax, newMax = 
                match mid + threshold with
                | max when max <= 1. -> false, max
                | _ -> true, 1.

            let diverge n = newMin + n * (newMax - newMin) / (colorListSize - 2.)

            match exceededMin, exceededMax with
            | true, false -> 
                [ 0. .. (colorListSize - 2.) ]
                |> List.map (diverge >> string)
                |> fun res -> [ yield! res; "1." ]
            | false, true ->
                [ 0. .. (colorListSize - 2.) ]
                |> List.map (diverge >> string)
                |> fun res -> [ "0."; yield! res ]
            | _ ->
                [ 0. .. (colorListSize - 3.) ]
                |> List.map (diverge >> string)
                |> fun res -> [ "0."; yield! res; "1." ]
            |> List.map2 (fun color i ->
                [ i; color ]
            ) colors

        let custom (scales: float list) (colors: string list) =
            scales |> List.map2 (fun color scale -> [ (scale |> string); color ]) colors

        let greys =
            [ rgb (0, 0, 0)
              rgb (255, 255, 255) ]
            |> sequential

        let ylGnBu =
            [ rgb (8, 29, 88)
              rgb (37, 52, 148)
              rgb (34, 94, 168)
              rgb (29, 145, 192)
              rgb (65, 182, 196)
              rgb (127, 205, 187)
              rgb (199, 233, 180)
              rgb (237, 248, 217)
              rgb (255, 255, 217) ]
            |> sequential

        let greens =
            [ rgb (0, 68, 27)
              rgb (0, 109, 44)
              rgb (35, 139, 69)
              rgb (65, 171, 93)
              rgb (116, 196, 118)
              rgb (161, 217, 155)
              rgb (199, 233, 192)
              rgb (229, 245, 224)
              rgb (247, 252, 245) ]
            |> sequential

        let ylOrRd =
            [ rgb (128, 0, 38)
              rgb (189, 0, 38)
              rgb (227, 26, 28)
              rgb (252, 78, 42)
              rgb (253, 141, 60)
              rgb (254, 178, 76)
              rgb (254, 217, 118)
              rgb (255, 237, 160)
              rgb (255, 255, 204) ]
            |> sequential

        let bluered =
            [ rgb (0, 0, 255)
              rgb (255, 0, 0) ]
            |> sequential

        /// modified RdBu based on
        ///
        /// http://www.kennethmoreland.com/color-maps/
        let rdBu =
            [ [ "0"; rgb (5, 10, 172) ]
              [ "0.35"; rgb (106, 137, 247) ]
              [ "0.5"; rgb (190, 190, 190) ]
              [ "0.6"; rgb (220, 170, 132) ]
              [ "0.7"; rgb (230, 145, 90) ]
              [ "1"; rgb (178, 10, 28) ] ]

        /// Scale for non-negative numeric values
        let reds =
            [ rgb (220, 220, 220)
              rgb (245, 195, 157)
              rgb (245, 160, 105)
              rgb (178, 10, 28) ]
            |> diverging 0. 0.4

        /// Scale for non-positive numeric values
        let blues =
            [ [ "0"; rgb (5, 10, 172) ]
              [ "0.35"; rgb (40, 60, 190) ]
              [ "0.5"; rgb (70, 100, 245) ]
              [ "0.6"; rgb (90, 120, 245) ]
              [ "0.7"; rgb (106, 137, 247) ]
              [ "1"; rgb (220, 220, 220) ] ]

        let picnic =
            [ rgb (0, 0, 255)
              rgb (51, 153, 255)
              rgb (102, 204, 255)
              rgb (153, 204, 255)
              rgb (204, 204, 255)
              rgb (255, 255, 255)
              rgb (255, 204, 255)
              rgb (255, 153, 255)
              rgb (255, 102, 204)
              rgb (255, 102, 102)
              rgb (255, 0, 0) ]
            |> sequential

        let rainbow =
            [ rgb (150, 0, 90)
              rgb (0, 0, 200)
              rgb (0, 25, 255)
              rgb (0, 152, 255)
              rgb (44, 255, 150)
              rgb (151, 255, 0)
              rgb (255, 234, 0)
              rgb (255, 111, 0)
              rgb (255, 0, 0) ]
            |> sequential

        let portland =
            [ rgb (12, 51, 131)
              rgb (10, 136, 186)
              rgb (242, 211, 56)
              rgb (242, 143, 56)
              rgb (217, 30, 30) ]
            |> sequential

        let jet =
            [ rgb (0, 0, 131)
              rgb (0, 60, 170)
              rgb (5, 255, 255)
              rgb (255, 255, 0)
              rgb (250, 0, 0)
              rgb (128, 0, 0) ]
            |> sequential

        let hot =
            [ [ "0"; rgb (0, 0, 0) ]
              [ "0.3"; rgb (230, 0, 0) ]
              [ "0.6"; rgb (255, 210, 0) ]
              [ "1."; rgb (255, 255, 255) ] ]

        let blackbody =
            [ [ "0"; rgb (0, 0, 0) ]
              [ "0.2"; rgb (230, 0, 0) ]
              [ "0.4"; rgb (230, 210, 0) ]
              [ "0.7"; rgb (255, 255, 255) ]
              [ "1"; rgb (160, 200, 255) ] ]

        let earth =
            [ [ "0"; rgb (0, 0, 130) ]
              [ "0.1"; rgb (0, 180, 180) ]
              [ "0.2"; rgb (40, 210, 40) ]
              [ "0.4"; rgb (230, 230, 50) ]
              [ "0.6"; rgb (120, 70, 20) ]
              [ "1"; rgb (255, 255, 255) ] ]

        let electric =
            [ [ "0"; rgb (0, 0, 0) ]
              [ "0.15"; rgb (30, 0, 100) ]
              [ "0.4"; rgb (120, 0, 100) ]
              [ "0.6"; rgb (160, 90, 0) ]
              [ "0.8"; rgb (230, 200, 0) ]
              [ "1"; rgb (255, 250, 220) ] ]

        let viridis =
            [ "#440154"
              "#48186a"
              "#472d7b"
              "#424086"
              "#3b528b"
              "#33638d"
              "#2c728e"
              "#26828e"
              "#21918c"
              "#1fa088"
              "#28ae80"
              "#3fbc73"
              "#5ec962"
              "#84d44b"
              "#addc30"
              "#d8e219"
              "#fde725" ]
            |> sequential

        let cividis =
            [ rgb (0, 32, 76)
              rgb (0, 42, 102)
              rgb (0, 52, 110)
              rgb (39, 63, 108)
              rgb (60, 74, 107)
              rgb (76, 85, 107)
              rgb (91, 95, 109)
              rgb (104, 106, 112)
              rgb (117, 117, 117)
              rgb (131, 129, 120)
              rgb (146, 140, 120)
              rgb (161, 152, 118)
              rgb (176, 165, 114)
              rgb (192, 177, 109)
              rgb (209, 191, 102)
              rgb (225, 204, 92)
              rgb (243, 219, 79)
              rgb (255, 233, 69) ]
            |> sequential
