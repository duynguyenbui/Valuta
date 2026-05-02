namespace Valuta.Api

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http

module Program =
    [<EntryPoint>]
    let main args =
        let builder = WebApplication.CreateBuilder(args)
        let app = builder.Build()

        app.MapGet("/", Func<_>(fun () -> "Valuta API is running.")) |> ignore

        app.Run()

        0
