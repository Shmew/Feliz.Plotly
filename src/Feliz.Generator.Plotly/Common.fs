namespace Fable.Plotly.Generator









[<AutoOpen>]
module Common =
    let trimJson (s: string) = s.Trim().Trim('"')

    let spaceCaseTokebabCase (s: string) = s.Replace(' ', '-')

    let dashStringToDash (s: string) =
        if s = "-" then "dash"
        else s

    let emptStringToNone (s: string) =
        if s = "\"\"" then "none"
        else s

    let kebabCaseToCamelCase (s: string) =
        let pieces =
            s.Split('-')
            |> Seq.trimEmptyLines
            |> Array.ofSeq
        if pieces.Length > 1 then
            pieces
            |> Array.iteri (fun i piece ->
                if i > 0 then pieces.[i] <- piece.Substring(0, 1).ToUpper() + piece.Substring(1))
            pieces |> String.concat ""
        else
            s

    let prefixUnderscoreOrNegativeToNumbers (s: string) =
        let isNegative (s: string) = (s |> Seq.head) = '-' && (s.Substring(1) |> Seq.forall System.Char.IsNumber)
        match s.Length > 0,
              s
              |> Seq.head
              |> System.Char.IsNumber, isNegative s with
        | true, true, _ -> "_" + s
        | true, false, true -> "neg" + (s.Substring(1))
        | _ -> s

    let appendApostropheToReservedKeywords (s: string) =
        let reserved =
            [ "checked"
              "static"
              "fixed"
              "inline"
              "default"
              "component"
              "inherit"
              "open"
              "type"
              "true"
              "false"
              "in"
              "end"
              "match"
              "base"
              "include"
              "constraint" ] |> Set.ofList
        if reserved.Contains s then s + "'"
        else s

    let private transformOperations (s: string) =
        match s with
        | "=" -> "eq"
        | "!=" -> "notEq"
        | "<" -> "lt"
        | ">=" -> "gtEq"
        | ">" -> "gt"
        | "<=" -> "ltEq"
        | "[]" -> "inclusiveRange"
        | "()" -> "exclusiveRange"
        | "[)" -> "leftIncLRightExcRange"
        | "(]" -> "rightIncLeftExcRange"
        | "][" -> "inclusiveBounds"
        | ")(" -> "exclusiveBounds"
        | "](" -> "rightExcLeftIncBounds"
        | ")[" -> "leftExcRightIncBounds"
        | "{}" -> "keepPresent"
        | "}{" -> "filterPresent"
        | _ -> s

    let private transformShape (s: string) =
        match s with
        | ">" -> "pointedRight"
        | "<" -> "pointedLeft"
        | "|" -> "straight"
        | "/" -> "rightSlant"
        | @"\\" -> "leftSlant"
        | _ -> s

    let fixMethodNameOperators methodName (s: string) =
        match methodName with
        | "edgeshape" -> transformShape s
        | "operation" -> transformOperations s
        | _ -> s

    let replaceAddSymbol (s: string) =
        let trimOuter = s.Trim('+')
        if trimOuter.Contains "+" then
            let head, tail = trimOuter.Split('+') |> Array.splitAt 1
            [ head |> Array.map String.lowerFirst
              [| "And" |]
              tail |> Array.map String.upperFirst ]
            |> Array.concat
            |> Array.reduce (sprintf "%s%s")
        else
            trimOuter
