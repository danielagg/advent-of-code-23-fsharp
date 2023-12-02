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
        // let inputFilePath = Path.Combine(__SOURCE_DIRECTORY__, "input.txt")
        // let rawInput = File.ReadAllLines(inputFilePath)

        // Array.map extractValues rawInput |> Array.sum
        1

module Part2 =
    let extractValues (rawInput: string) =
        let parsedInput = rawInput.Replace("one", "1").Replace("two", "2").Replace("three", "3").Replace("four", "4").Replace("five", "5").Replace("six", "6").Replace("seven", "7").Replace("eight", "8").Replace("nine", "9")

        // let indexOf1 = rawInput.IndexOf("one")
        // let indexOf2 = rawInput.IndexOf("two")
        // let indexOf3 = rawInput.IndexOf("three")
        // let indexOf4 = rawInput.IndexOf("four")
        // let indexOf5 = rawInput.IndexOf("five")
        // let indexOf6 = rawInput.IndexOf("six")
        // let indexOf7 = rawInput.IndexOf("seven")
        // let indexOf8 = rawInput.IndexOf("eight")
        // let indexOf9 = rawInput.IndexOf("nine")

        // let test = List.min [indexOf1, indexOf2, indexOf3, indexOf4, indexOf5, indexOf6, indexOf7, indexOf8, indexOf9]

        // if test > -1 then
        //     let parsedInput = rawInput.Replace("one", "1").Replace("two", "2").Replace("three", "3").Replace("four", "4").Replace("five", "5").Replace("six", "6").Replace("seven", "7").Replace("eight", "8").Replace("nine", "9")
        //     let firstDigit = parsedInput |> Seq.find Char.IsDigit
        //     let lastDigit = parsedInput |> Seq.findBack Char.IsDigit
        //     let combinedString = string firstDigit + string lastDigit

        //     // printfn "%s -> %s -> %s" rawInput parsedInput combinedString
        //     printfn "%s -> %s" rawInput combinedString



        // let wordNumberMap =
        //     [|
        //         "one", "1"
        //         "two", "2"
        //         "three", "3"
        //         "four", "4"
        //         "five", "5"
        //         "six", "6"
        //         "seven", "7"
        //         "eight", "8"
        //         "nine", "9"
        //     |]

        // let rec replaceWords str =
        //     match wordNumberMap |> Array.tryFind (fun (word, _) -> rawInput.StartsWith(word)) with
        //     | Some (word, num) ->
        //         let rest = rawInput.Substring(word.Length)
        //         num + replaceWords rest
        //     | None -> str

        // let parsedInput = replaceWords rawInput

        let firstDigit = parsedInput |> Seq.find Char.IsDigit
        let lastDigit = parsedInput |> Seq.findBack Char.IsDigit
        let combinedString = string firstDigit + string lastDigit

        // printfn "%s -> %s -> %s" rawInput parsedInput combinedString
        printfn "%s -> %s" rawInput combinedString


        int combinedString



    let run () =
        // let result = replaceWordsWithNumbers "eightwothree"
        // printfn "%s" result
        1
        // let inputFilePath = Path.Combine(__SOURCE_DIRECTORY__, "input.txt")
        // let rawInput = File.ReadAllLines(inputFilePath)

        // Array.map extractValues rawInput |> Array.sum
