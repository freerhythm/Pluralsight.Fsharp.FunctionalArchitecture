namespace Pluralsight.Fsharp.BookingApi.Renditions

[<CLIMutable>]
type public MakeReservationRendition = {
    Date : string
    Name : string
    Email : string
    Quantity : int } 