namespace Tools.Linting

open System
open FSharpLint.Application.ConfigurationManager

module FSharpLinter =
    open FSharpLint.Application
    open FSharpLint.Framework

    let private writeLine (str : string) (color : ConsoleColor) (writer : IO.TextWriter) =
        let originalColour = Console.ForegroundColor
        Console.ForegroundColor <- color
        writer.WriteLine str
        Console.ForegroundColor <- originalColour

    let private writeInfoLine (str : string) = writeLine str ConsoleColor.White Console.Out
    let private writeWarningLine (str : string) = writeLine str ConsoleColor.Yellow Console.Out
    let private writeErrorLine (str : string) = writeLine str ConsoleColor.Red Console.Error

    let private parserProgress =
        function
        | Starting(file) -> String.Format(Resources.GetString("ConsoleStartingFile"), file) |> writeInfoLine
        | ReachedEnd(_, warnings) ->
            String.Format(Resources.GetString("ConsoleFinishedFile"), List.length warnings) |> writeInfoLine
        | Failed(file, parseException) ->
            String.Format(Resources.GetString("ConsoleFailedToParseFile"), file) |> writeErrorLine
            "Exception Message:" + Environment.NewLine + parseException.Message + Environment.NewLine
            + "Exception Stack Trace:" + Environment.NewLine + parseException.StackTrace + Environment.NewLine
            |> writeErrorLine

    let mutable private collectWarning = List.empty<string>

    let private getWarnings() =
        match collectWarning.Length = 0 with
        | true -> None
        | false ->
            let warns = collectWarning
            collectWarning <- List.empty<string>
            Some(warns)

    let private writeLintWarning (warn : LintWarning.Warning) =
        let warnMsg = warn.Info + Environment.NewLine + LintWarning.getWarningWithLocation warn.Range warn.Input
        collectWarning <- ((if collectWarning.Length > 0 then Environment.NewLine + warnMsg
                            else warnMsg)
                           :: collectWarning)
        warnMsg |> writeWarningLine
        String.replicate 80 "*" |> writeInfoLine

    let private handleError (str : string) = writeErrorLine str

    let private handleLintResult =
        function
        | LintResult.Failure(failure) -> handleError failure.Description
        | _ -> ()

    let private parseInfo (webFile : bool) =
        let config =
            if webFile then
                Some { Configuration.formatting = None
                       Configuration.conventions =
                           Some { recursiveAsyncFunction = None
                                  redundantNewKeyword = None
                                  nestedStatements = None
                                  reimplementsFunction = None
                                  canBeReplacedWithComposition = None
                                  raiseWithTooManyArgs = None
                                  sourceLength = None
                                  naming =
                                      Some { interfaceNames =
                                                 Some { RuleConfig.enabled = false
                                                        config = None }
                                             exceptionNames = None
                                             typeNames = None
                                             recordFieldNames = None
                                             enumCasesNames = None
                                             unionCasesNames = None
                                             moduleNames = None
                                             literalNames = None
                                             namespaceNames = None
                                             memberNames =
                                                 Some { RuleConfig.enabled = false
                                                        config = None }
                                             parameterNames = None
                                             measureTypeNames = None
                                             activePatternNames = None
                                             publicValuesNames = None
                                             nonPublicValuesNames = None }
                                  numberOfItems = None
                                  binding = None }
                       Configuration.typography = None
                       ignoreFiles = None
                       hints = None }
            else None

        { CancellationToken = None
          ReceivedWarning = Some writeLintWarning
          Configuration = config
          ReportLinterProgress = Some parserProgress }

    let lintFiles (fileList : (bool * string list) list) =
        let lintFile (webFile : bool) (file : string) =
            let sw = Diagnostics.Stopwatch.StartNew()
            try
                Lint.lintFile (parseInfo webFile) file |> handleLintResult
                sw.Stop()
            with e ->
                sw.Stop()
                let error =
                    "Lint failed while analysing " + file + "." + Environment.NewLine + "Failed with: " + e.Message
                    + Environment.NewLine + "Stack trace:" + e.StackTrace
                error |> handleError
        fileList
        |> List.iter (fun (webFile, fList) -> fList |> List.iter (lintFile webFile))
