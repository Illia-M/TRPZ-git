// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
<<<<<<< HEAD
    let name1 = from "Daniil Shramko!" // Call the function
=======
    let name1 = from "Polina Sopoleva!" // Call the function
>>>>>>> e6e7a743a8a84c6857afb6dc4ed6603692760b23
    printfn "Hello world %s" name1
    0 // return an integer exit code
Oleh Yermak