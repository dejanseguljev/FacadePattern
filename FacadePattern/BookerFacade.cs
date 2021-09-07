using System;
using System.Collections.Generic;

namespace FacadePattern
{
    public enum BookingType
    {
        Hotel,
        Event,
        Activity
    }

    public class BookerFacade
    {
        private Dictionary<string, BookingType> _bookingTypes =
            new Dictionary<string, BookingType>();

        public void AddBooking(string name, BookingType type)
        {
            _bookingTypes[name] = type;
        }

        public void Book(string name, IDictionary<string, object> args)
        {
            var type = _bookingTypes[name];

            switch (type)
            {
                case BookingType.Hotel:
                    new RoomBooker().Book(name, (string)args["Room"], (DateTime)args["Start"],
                        (DateTime)args["End"]);
                    break;
                case BookingType.Event:
                    new EventBooker().Book(name, (DateTime)args["Date"]);
                    break;
                case BookingType.Activity:
                    new ActivityBooker().Book(name, (DateTime)args["Date"]);
                    break;
                default:
                    break;
            }
        }
    }
}
