namespace CodeRetreate.FSharp.Tests

open System
open NUnit.Framework
open FsUnit

module _Extensions =

    type System.String with
        member this.NormalizeLineEndings() = this.Replace(@"\r\n","\n")

type ``When running a test``() =

    let input = true

    [<Test>] member x.
     ``can run a test``() =
        input |> should equal true
