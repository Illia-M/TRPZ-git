namespace TRPZ2.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open TRPZ2

[<ApiController>]
[<Route("[controller]")>]
type WeatherForecastController (logger : ILogger<WeatherForecastController>) =
    inherit ControllerBase()

    let summaries =
        [|
            "1. FirstName LastName"
		Vlad Ulizko
            "1. FirstName LastName"
            "2. FirstName LastName"
            "1. Vlad Ulizko"		
            "2. Vlad Shapkin"
            "3. FirstName LastName"
            "4. Vlad Melaschenko"
            "5. FirstName LastName"
            "6. FirstName LastName"
            "7. Liashenko Polina"
            "8. Lanko Vladimir"
            "9. Vitaliy Berezovskiy"
        |]

    [<HttpGet>]
    member _.Get() =
        let rng = System.Random()
        [|
            for index in 0..4 ->
                { Date = DateTime.Now.AddDays(float index)
                  TemperatureC = rng.Next(-20,55)
                  Summary = summaries.[rng.Next(summaries.Length)] }
        |]
