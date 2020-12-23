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
            "2. Valeriy Makarov"
            "1. Vlad Ulizko"		
            "2. Vlad Shapkin"
            "3. Afonin Artem"
            "4. Vlad Melaschenko"
            "5. FirstName LastName"
            "3. FirstName LastName"
            "4. FirstName LastName"
            "5. Vlad Melaschenko"
            "6. Andrey Luzhanskiy"
            "7. Liashenko Polina"
            "8. Lanko Vladimir"
            "9. Vitaliy Berezovskiy"
	    	"10. Kostia Bazelyuk"
	    	"11. Alexandr Teplyuk"
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
