namespace Pluralsight.Fsharp.BookingApi.HttpApi

open System.Net
open System.Net.Http
open System.Web.Http
open Pluralsight.Fsharp.BookingApi.Renditions

type HomeController() =
    inherit ApiController()
    member this.Get() = new HttpResponseMessage()

type ReservationController() =
    inherit ApiController()
    member this.Post (rendition : MakeReservationRendition ) = 
        new HttpResponseMessage(HttpStatusCode.Accepted)
