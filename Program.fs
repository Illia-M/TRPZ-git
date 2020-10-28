// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    let student = from "#1 FirstName LastName" // Call the function
    printfn "Hello world %s" message
    printfn "Hello %s" student
    printfn "Savina Olga"
    printfn "Anton Novak"
    0 // return an integer exit code
