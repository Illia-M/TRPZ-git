// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =

    let name1 = from "Anatolii Dudik!" // Call the function

    let name2 = from "Daniil Shramko!" // Call the function

    let name3 = from "Andrew Chikrii!" // Call the function

    let name4 = from "Vitaliy Smorodinov" // Call the function

    printfn "Hello world %s" name1
    printfn "Hello world %s" name2
    printfn "Hello world %s" name3
    printfn "Hello world %s" name4


    0 // return an integer exit code
