namespace Fable.Plotly.Generator

[<AutoOpen>]
module Common =
    /// Trims outer white space and " characters
    let trimJson (s: string) = s.Trim().Trim('"')

    let spaceCaseTokebabCase (s: string) = s.Replace(' ', '-')

    /// Returns "dash" when the string is "-"
    let dashStringToDash (s: string) =
        if s = "-" then "dash"
        else s

    /// Returns "none" when the input string is `""`
    let emptStringToNone (s: string) =
        if s = "\"\"" then "none"
        else s

    let snakeCaseToCamelCase (s: string) =
        let pieces =
            s.Split('_')
            |> Seq.trimEmptyLines
            |> Array.ofSeq
        if pieces.Length > 1 then
            pieces
            |> Array.iteri (fun i piece ->
                if i > 0 then pieces.[i] <- piece.Substring(0, 1).ToUpper() + piece.Substring(1))
            pieces |> String.concat ""
        else
            s

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

    /// Prefixes an underscore to position numbers or "neg" to negative numbers
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

    /// Converts operators to text
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

    /// Converts Plotly shape operators to text
    let private transformShape (s: string) =
        match s with
        | ">" -> "pointedRight"
        | "<" -> "pointedLeft"
        | "|" -> "straight"
        | "/" -> "rightSlant"
        | @"\\" -> "leftSlant"
        | _ -> s

    /// Converts Plotly marker pattern shape operators to text
    let private transformMarkerPatternShape (s: string) =
        match s with
        | ""
        | "none" -> "blank"
        | "/" -> "rightDiagonalLine"
        | @"\\" -> "leftDiagonalLine"
        | "x" -> "diagonalCross"
        | "-" -> "horizontalLine"
        | "|" -> "verticalLine"
        | "+" -> "cross"
        | "." -> "dot"
        | _ -> s

    /// Adjusts names with operators in them
    let fixMethodNameOperators methodName (s: string) =
        match methodName with
        | "edgeshape" -> transformShape s
        | "operation" -> transformOperations s
        | "shape" -> transformMarkerPatternShape s
        | _ -> s

    /// Replace + symbols with "And"
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
