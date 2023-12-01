namespace Day01

open System.IO
open System


module Part1 =
    let extractValues (rawInput: string) =
        let firstDigit = rawInput |> Seq.find Char.IsDigit
        let lastDigit = rawInput |> Seq.findBack Char.IsDigit
        let combinedString = string firstDigit + string lastDigit

        int combinedString

    let run () =
        let inputFilePath = Path.Combine(__SOURCE_DIRECTORY__, "input.txt")
        let rawInput = File.ReadAllLines(inputFilePath)

        Array.map extractValues rawInput |> Array.sum

module Part2 =
    let run () =
        1
