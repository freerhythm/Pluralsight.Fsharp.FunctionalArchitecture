module Pluralsight.Fsharp.BookingApi.HttpApi.Infastructure

open System.Web.Http

type HttpRouteDefaults = { Controller : string; Id : obj }

let ConfigureRoutes(config : HttpConfiguration) = 
    GlobalConfiguration.Configuration.Routes.MapHttpRoute(
        "DefaultAPI",
        "{controller}/{id}",
        { Controller = "Home"; Id = RouteParameter.Optional }) |> ignore

let Configure = ConfigureRoutes