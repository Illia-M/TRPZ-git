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
            "2. Oleksandr Yudakov"
            "3. Max Vavryniuk"
            "4. Andrii Andreiev"
            "6. Bohdan Huz"
			"10. Andrey Kolomoets"
			"20. Stanislav Palamar"
            "13. Kulbanevych Mykyta"
			"16. Maksym Mazko"
			"19. Olexandr Opalatenko"
			"17. Dmytro Brahar1"
			
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
