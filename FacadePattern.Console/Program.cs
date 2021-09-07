using System;
using System.Collections.Generic;

namespace FacadePattern.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code is hard to use.
            var roomBooker = new RoomBooker();
            roomBooker.Book("Salto Chico", "35", DateTime.Today.AddDays(3), 
                DateTime.Today.AddDays(5));

            var eventBooker = new EventBooker();
            eventBooker.Book("Olympic Games", DateTime.Today.AddDays(20));

            var activityBooker = new ActivityBooker();
            activityBooker.Book("Swimming", DateTime.Today.AddDays(5));

            System.Console.WriteLine();

            // We create a facade.
            var facade = new BookerFacade();

            // We need to register our bookings. This is done only once and can be retrieved from the database.
            facade.AddBooking("Salto Chico", BookingType.Hotel);
            facade.AddBooking("Olympic Games", BookingType.Event);
            facade.AddBooking("Swimming", BookingType.Activity);

            // Make bookings
            facade.Book("Salto Chico", new Dictionary<string, object> {
                { "Room", "35"},
                { "Start", DateTime.Today.AddDays(3)},
                { "End", DateTime.Today.AddDays(5)}
            });
            facade.Book("Olympic Games", new Dictionary<string, object> {
                { "Date", DateTime.Today.AddDays(20)}
            });
            facade.Book("Swimming", new Dictionary<string, object> {
                { "Date", DateTime.Today.AddDays(5)}
            });

            System.Console.ReadLine();
        }
    }
}
