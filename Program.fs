// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let name4 = from "Andrew Chikrii!" // Call the function
    printfn "Hello world %s" name4
    0 // return an integer exit code
