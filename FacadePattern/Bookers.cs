using System;
using System.Collections.Generic;

namespace FacadePattern
{
    public class RoomBooker: IBooker
    {
        public void Book(string hotel, string room, DateTime start, DateTime end)
        {
            Console.WriteLine($"Booking a room {room} in a hotel {hotel} from {start} to {end}.");
        }

        public void Book(string name, IDictionary<string, object> args)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a valid name.");
            }

            if (!args.ContainsKey("Room") || !args.ContainsKey("Start") ||
                !args.ContainsKey("End"))
            {
                throw new ArgumentException("You must provide arguments Room, Start, End.");
            }

            Book(name, (string)args["Room"], (DateTime)args["Start"],
                        (DateTime)args["End"]);
        }
    }

    public class EventBooker: IBooker
    {
        public void Book(string eventName, DateTime date)
        {
            Console.WriteLine($"Registering for an event {eventName} on {date}.");
        }

        public void Book(string name, IDictionary<string, object> args)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a valid name.");
            }

            if (!args.ContainsKey("Date"))
            {
                throw new ArgumentException("You must provide Date.");
            }

            Book(name, (DateTime)args["Date"]);
        }
    }

    public class ActivityBooker: IBooker
    {
        public void Book(string activity, DateTime date)
        {
            Console.WriteLine($"Applying to activity {activity} on {date}");
        }

        public void Book(string name, IDictionary<string, object> args)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("You must provide a valid name.");
            }

            if (!args.ContainsKey("Date"))
            {
                throw new ArgumentException("You must provide Date.");
            }

            Book(name, (DateTime)args["Date"]);
        }
    }
}
