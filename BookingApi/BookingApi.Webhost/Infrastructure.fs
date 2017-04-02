namespace Pluralsight.Fsharp.BookingApi.Webhost

open System
open System.Web.Http
open Pluralsight.Fsharp.BookingApi.HttpApi.Infastructure

type HttpRouteDefaults = { Controller : string; Id : obj }

type Global() =
    inherit System.Web.HttpApplication()
    member this.Application_Start (sender : obj) (e : EventArgs) = 
        Configure GlobalConfiguration.Configuration