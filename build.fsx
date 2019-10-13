// --------------------------------------------------------------------------------------
// FAKE build script
// --------------------------------------------------------------------------------------
#nowarn "0213"
#r "paket: groupref FakeBuild //"
#load "./tools/FSharpLint.fs"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.Core.TargetOperators
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Tools
open Fantomas.FakeHelpers
open Fantomas.FormatConfig
open Tools.Linting
open System
open System.IO

// The name of the project
// (used by attributes in AssemblyInfo, name of a NuGet package and directory in 'src')
let project = "Feliz.Plotly"

// Short summary of the project
// (used as description in AssemblyInfo and as a short summary for NuGet package)
let summary = "Fable bindings written in the Feliz-style for plotly.js"

// File system information
let solutionFile = "Feliz.Plotly.sln"

// Github repo
let repo = "https://github.com/Shmew/Feliz.Plotly"

// Files to skip Fantomas formatting
let excludeFantomas =
    [ __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/Props/*.fs"
      __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/Types.fs"
      __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/Interop.fs"
      __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/Plotly.fs" ]

// Files that have bindings to other languages where name linting needs to be more relaxed.
let relaxedNameLinting = 
    [ __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/**/*.fs"
      __SOURCE_DIRECTORY__ @@ "src/Feliz.Plotly/*.fs" ]

// Read additional information from the release notes document
let release = ReleaseNotes.load (__SOURCE_DIRECTORY__ @@ "RELEASE_NOTES.md")

// Helper active pattern for project types
let (|Fsproj|Csproj|Vbproj|Shproj|) (projFileName:string) =
    match projFileName with
    | f when f.EndsWith("fsproj") -> Fsproj
    | f when f.EndsWith("csproj") -> Csproj
    | f when f.EndsWith("vbproj") -> Vbproj
    | f when f.EndsWith("shproj") -> Shproj
    | _                           -> failwith (sprintf "Project file %s not supported. Unknown project type." projFileName)

let srcGlob    = __SOURCE_DIRECTORY__ @@ "src/**/*.??proj"
let fsSrcGlob  = __SOURCE_DIRECTORY__ @@ "src/**/*.fs"
let fsTestGlob = __SOURCE_DIRECTORY__ @@ "tests/**/*.fs"
let bin        = __SOURCE_DIRECTORY__ @@ "bin"
let temp       = __SOURCE_DIRECTORY__ @@ "temp"
let objFolder  = __SOURCE_DIRECTORY__ @@ "obj"
let dist       = __SOURCE_DIRECTORY__ @@ "dist"

let foldExcludeGlobs (g: IGlobbingPattern) (d: string) = g -- d
let foldIncludeGlobs (g: IGlobbingPattern) (d: string) = g ++ d

let fsSrcAndTest =
    !! fsSrcGlob
    ++ fsTestGlob
    -- (__SOURCE_DIRECTORY__  @@ "src/**/obj/**")
    -- (__SOURCE_DIRECTORY__  @@ "tests/**/obj/**")
    -- (__SOURCE_DIRECTORY__  @@ "src/**/AssemblyInfo.*")
    -- (__SOURCE_DIRECTORY__  @@ "src/**/**/AssemblyInfo.*")

let fsRelaxedNameLinting =
    let baseGlob s =
        !! s
        -- (__SOURCE_DIRECTORY__  @@ "src/**/AssemblyInfo.*")
        -- (__SOURCE_DIRECTORY__  @@ "src/**/obj/**")
        -- (__SOURCE_DIRECTORY__  @@ "tests/**/obj/**")
    match relaxedNameLinting with
    | [h] when relaxedNameLinting.Length = 1 -> baseGlob h |> Some
    | h::t -> List.fold foldIncludeGlobs (baseGlob h) t |> Some
    | _ -> None

let setCmd f args =
    match Environment.isWindows with
    | true -> Command.RawCommand(f, Arguments.OfArgs args)
    | false -> Command.RawCommand("mono", Arguments.OfArgs (f::args))

let configuration() =
    FakeVar.getOrDefault "configuration" "Release"

// --------------------------------------------------------------------------------------
// Set configuration mode based on target

Target.create "ConfigDebug" <| fun _ ->
    FakeVar.set "configuration" "Debug"

Target.create "ConfigRelease" <| fun _ ->
    FakeVar.set "configuration" "Release"

// --------------------------------------------------------------------------------------
// Generate assembly info files with the right version & up-to-date information

Target.create "AssemblyInfo" <| fun _ ->
    let getAssemblyInfoAttributes projectName =
        [ AssemblyInfo.Title (projectName)
          AssemblyInfo.Product project
          AssemblyInfo.Description summary
          AssemblyInfo.Version release.AssemblyVersion
          AssemblyInfo.FileVersion release.AssemblyVersion
          AssemblyInfo.Configuration <| configuration()
          AssemblyInfo.InternalsVisibleTo (sprintf "%s.Tests" projectName) ]

    let getProjectDetails projectPath =
        let projectName = Path.GetFileNameWithoutExtension(projectPath)
        ( projectPath,
          projectName,
          Path.GetDirectoryName(projectPath),
          (getAssemblyInfoAttributes projectName)
        )

    !! srcGlob
    |> Seq.map getProjectDetails
    |> Seq.iter (fun (projFileName, _, folderName, attributes) ->
        match projFileName with
        | Fsproj -> AssemblyInfoFile.createFSharp (folderName </> "AssemblyInfo.fs") attributes
        | Csproj -> AssemblyInfoFile.createCSharp ((folderName </> "Properties") </> "AssemblyInfo.cs") attributes
        | Vbproj -> AssemblyInfoFile.createVisualBasic ((folderName </> "My Project") </> "AssemblyInfo.vb") attributes
        | Shproj -> () )

// --------------------------------------------------------------------------------------
// Copies binaries from default VS location to expected bin folder
// But keeps a subdirectory structure for each project in the
// src folder to support multiple project outputs

Target.create "CopyBinaries" <| fun _ ->
    !! srcGlob
    -- (__SOURCE_DIRECTORY__ @@ "src/**/*.shproj")
    |> Seq.map (fun f -> ((Path.getDirectory f) @@ "bin" @@ configuration(), "bin" @@ (Path.GetFileNameWithoutExtension f)))
    |> Seq.iter (fun (fromDir, toDir) -> Shell.copyDir toDir fromDir (fun _ -> true))

// --------------------------------------------------------------------------------------
// Clean tasks

Target.create "Clean" <| fun _ ->
    let clean() =
        !! (__SOURCE_DIRECTORY__  @@ "tests/**/bin")
        ++ (__SOURCE_DIRECTORY__  @@ "tests/**/obj")
        ++ (__SOURCE_DIRECTORY__  @@ "tools/bin")
        ++ (__SOURCE_DIRECTORY__  @@ "tools/obj")
        ++ (__SOURCE_DIRECTORY__  @@ "src/**/bin")
        ++ (__SOURCE_DIRECTORY__  @@ "src/**/obj")
        |> Seq.toList
        |> List.append [bin; temp; objFolder; dist]
        |> Shell.cleanDirs
    TaskRunner.runWithRetries clean 99

Target.create "CleanDocs" <| fun _ ->
    let clean() =
        Shell.cleanDirs ["docs"]
    TaskRunner.runWithRetries clean 99

Target.create "PostBuildClean" <| fun _ ->
    let clean() =
        !! srcGlob
        -- (__SOURCE_DIRECTORY__ @@ "src/**/*.shproj")
        |> Seq.map (
            (fun f -> (Path.getDirectory f) @@ "bin" @@ configuration()) 
            >> (fun f -> Directory.EnumerateDirectories(f) |> Seq.toList )
            >> (fun fL -> fL |> List.map (fun f -> Directory.EnumerateDirectories(f) |> Seq.toList)))
        |> (Seq.concat >> Seq.concat)
        |> Seq.iter Directory.delete
    TaskRunner.runWithRetries clean 99

Target.create "PostPublishClean" <| fun _ ->
    let clean() =
        !! (__SOURCE_DIRECTORY__ @@ "src/**/bin" @@ configuration() @@ "/**/publish")
        |> Seq.iter Directory.delete
    TaskRunner.runWithRetries clean 99

// --------------------------------------------------------------------------------------
// Restore tasks

let restoreSolution () =
    solutionFile
    |> DotNet.restore id

Target.create "Restore" <| fun _ ->
    TaskRunner.runWithRetries restoreSolution 5

// --------------------------------------------------------------------------------------
// Build tasks

Target.create "Build" <| fun _ ->
    let setParams (defaults:MSBuildParams) =
        { defaults with
            Verbosity = Some(Quiet)
            Targets = ["Build"]
            Properties =
                [
                    "Optimize", "True"
                    "DebugSymbols", "True"
                    "Configuration", configuration()
                    "Version", release.AssemblyVersion
                    "GenerateDocumentationFile", "true"
                    "DependsOnNETStandard", "true"
                ]
         }
    restoreSolution()
    MSBuild.build setParams solutionFile

// --------------------------------------------------------------------------------------
// Publish net core applications

Target.create "PublishDotNet" <| fun _ ->
    let runPublish (project: string) (framework: string) =
        let setParams (defaults:MSBuildParams) =
            { defaults with
                Verbosity = Some(Quiet)
                Targets = ["Publish"]
                Properties =
                    [
                        "Optimize", "True"
                        "DebugSymbols", "True"
                        "Configuration", configuration()
                        "Version", release.AssemblyVersion
                        "GenerateDocumentationFile", "true"
                        "TargetFramework", framework
                    ]
            }
        MSBuild.build setParams project

    !! srcGlob
    -- (__SOURCE_DIRECTORY__ @@ "src/**/*.shproj")
    -- (__SOURCE_DIRECTORY__ @@ "src/**/*.vbproj")
    |> Seq.map
        ((fun f -> (((Path.getDirectory f) @@ "bin" @@ configuration()), f) )
        >>
        (fun f ->
            Directory.EnumerateDirectories(fst f) 
            |> Seq.filter (fun frFolder -> frFolder.Contains("netcoreapp"))
            |> Seq.map (fun frFolder -> DirectoryInfo(frFolder).Name), snd f))
    |> Seq.iter (fun (l,p) -> l |> Seq.iter (runPublish p))

// --------------------------------------------------------------------------------------
// Lint and format source code to ensure consistency

Target.create "Format" <| fun _ ->
     let config =
         { FormatConfig.Default with
             PageWidth = 120
             SpaceBeforeColon = false }
 
     fsSrcAndTest
     |> (fun src -> List.fold foldExcludeGlobs src excludeFantomas)
     |> List.ofSeq
     |> formatCode config
     |> Async.RunSynchronously
     |> printfn "Formatted files: %A"

Target.create "Lint" <| fun _ ->
    fsSrcAndTest
    -- (__SOURCE_DIRECTORY__  @@ "src/**/AssemblyInfo.*")
    |> (fun src -> List.fold foldExcludeGlobs src relaxedNameLinting)
    |> (fun fGlob ->
        match fsRelaxedNameLinting with
        | Some(glob) ->
            [(false, fGlob); (true, glob)]
        | None -> [(false, fGlob)])
    |> Seq.map (fun (b,glob) -> (b,glob |> List.ofSeq))
    |> List.ofSeq
    |> FSharpLinter.lintFiles

// --------------------------------------------------------------------------------------
// Run the unit test binaries

Target.create "RunTests" <| fun _ ->
    !! ("tests/**/bin" @@ configuration() @@ "**" @@ "*Tests.exe")
    |> Seq.iter (fun f ->
        CreateProcess.fromCommand(setCmd f [])
        |> CreateProcess.withTimeout (TimeSpan.MaxValue)
        |> CreateProcess.ensureExitCodeWithMessage "Tests failed."
        |> Proc.run
        |> ignore)

// --------------------------------------------------------------------------------------
// Generate Paket load scripts
Target.create "LoadScripts" <| fun _ ->
    let frameworks =
        __SOURCE_DIRECTORY__ @@ "bin"
        |> Directory.EnumerateDirectories
        |> Seq.map (fun d ->
            Directory.EnumerateDirectories d
            |> Seq.map (fun f -> DirectoryInfo(f).Name)
            |> List.ofSeq)
        |> List.ofSeq
        |> List.reduce List.append
        |> List.distinct
        |> List.reduce (fun acc elem -> sprintf "%s --framework %s" elem acc)
        |> function
        | e when e.Length > 0 ->
            Some (sprintf "--framework %s" e)
        | _ -> None

    let arguments =
        [Some("generate-load-scripts"); frameworks]
        |> List.choose id
        |> List.reduce (fun acc elem -> sprintf "%s %s" acc elem)

    arguments
    |> CreateProcess.fromRawCommandLine ((__SOURCE_DIRECTORY__ @@ ".paket") @@ "paket.exe")
    |> CreateProcess.withTimeout (TimeSpan.MaxValue)
    |> CreateProcess.ensureExitCodeWithMessage "Failed to generate paket load scripts."
    |> Proc.run
    |> ignore

// --------------------------------------------------------------------------------------
// Build NuGet package

Target.create "NuGet" <| fun _ ->
    Paket.pack(fun p ->
        { p with
            OutputPath = bin
            Version = release.NugetVersion
            ReleaseNotes = Fake.Core.String.toLines release.Notes
            ProjectUrl = repo
            MinimumFromLockFile = true
            IncludeReferencedProjects = true })

// --------------------------------------------------------------------------------------
// Release Scripts

Target.create "GitPush" <| fun p ->
    let msg =
        p.Context.Arguments
        |> List.choose (fun s ->
            match s.StartsWith("--Msg=") with
            | true -> Some(s.Substring 6)
            | false -> None)
        |> List.tryHead
        |> function
        | Some(s) -> s
        | None -> (sprintf "Bump version to %s" release.NugetVersion)

    Git.Staging.stageAll ""
    Git.Commit.exec "" msg
    Git.Branches.push ""

Target.create "GitTag" <| fun _ ->
    Git.Branches.tag "" release.NugetVersion
    Git.Branches.pushTag "" "origin" release.NugetVersion

// --------------------------------------------------------------------------------------
// Run all targets by default. Invoke 'build -t <Target>' to override

Target.create "All" ignore
Target.create "Dev" ignore
Target.create "Release" ignore

"Clean"
  ==> "AssemblyInfo"
  ==> "Restore"
  ==> "Build"
  ==> "PostBuildClean" 
  ==> "CopyBinaries"

"Build" ==> "RunTests"

"Build"
  ==> "PostBuildClean"
  ==> "PublishDotNet"
  ==> "PostPublishClean"
  ==> "CopyBinaries"

"Restore" ==> "Lint"
"Restore" ==> "Format"

"Format"
  ?=> "Lint" 
  ?=> "Build"
  ?=> "RunTests"
  ?=> "CleanDocs"

"Restore" ==> "LoadScripts"

"Clean" 
  ==> "GitPush"
  ?=> "GitTag"

"All" <== ["Lint"; "Format"; "RunTests"; "CopyBinaries" ]

"All"
 ==> "NuGet"

"ConfigDebug" ?=> "Clean"
"ConfigRelease" ?=> "Clean"

"Dev" <== ["All"; "ConfigDebug"]

"Release" <== ["All"; "NuGet"; "ConfigRelease"]

Target.runOrDefaultWithArguments "Dev"
