﻿namespace TRPZ2.Controllers

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
            "2. Oleksandr Yudakov"
            "3. Max Vavryniuk"
            "4. Andrii Andreiev"
            "2. FirstName LastName"
            "3. FirstName LastName"
            "3. Maximka Vavryniuk"
            "4. FirstName LastName"
            "5. FirstName LastName"
            "6. FirstName LastName"
			"20. Stanislav Palamar"
            "13. Kulbanevych Mykyta"
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
