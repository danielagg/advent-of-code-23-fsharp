namespace Day02

open System.IO
open System

module Part1 =
    let extractGameId (input: string) =
        input.Substring("Game ".Length)
            |> Seq.takeWhile (fun x -> Char.IsDigit(x))
            |> Seq.toArray
            |> String

    let getValidityResult (game: string) =
        let cubes = game.Split(',')

        let red = cubes |> Array.filter (fun x -> x.Contains("red")) |> Array.map (fun x -> x.Replace("red", "").Trim()) |> Array.sumBy int
        let green = cubes |> Array.filter (fun x -> x.Contains("green")) |> Array.map (fun x -> x.Replace("green", "").Trim()) |> Array.sumBy int
        let blue = cubes |> Array.filter (fun x -> x.Contains("blue")) |> Array.map (fun x -> x.Replace("blue", "").Trim()) |> Array.sumBy int

        let isValid = red <= 12 && green <= 13 && blue <= 14
        if isValid then 1 else 0

    let calculateResults (rawInput: string) =
        let gameId = extractGameId rawInput
        let inputWithGame = rawInput.Substring(rawInput.IndexOf(':') + 2).Trim()
        let games = inputWithGame.Split(';', StringSplitOptions.RemoveEmptyEntries)
        games |> Array.map getValidityResult |> Array.forall (fun x -> x = 1) |> fun x -> if x then int gameId else 0

    let run () =
        let inputFilePath = Path.Combine(__SOURCE_DIRECTORY__, "input.txt")
        let rawInput = File.ReadAllLines(inputFilePath)

        Array.map calculateResults rawInput |> Array.sum

module Part2 =
    let run () =
        1
