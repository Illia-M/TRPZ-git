// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function

    let student = from "#1 FirstName LastName" 
// Call the function
 let studentK = from "#23 Karyna Sobkovska"
    let student25 = from "#1 Egor Titov" // Call the function
    printfn "Hello world %s" message
    printfn "Hello %s" student

    let student2 = from "#2 Oleksandra Davydova"
    printfn "Hello %s" student2

    let student3 = from "#3 Dmytro Brahar"
    printfn "Hello %s" student3
    0 // return an integer exit code