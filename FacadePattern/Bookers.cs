using System;

namespace FacadePattern
{
    public class RoomBooker
    {
        public void Book(string hotel, string room, DateTime start, DateTime end)
        {
            Console.WriteLine($"Booking a room {room} in a hotel {hotel} from {start} to {end}.");
        }
    }

    public class EventBooker
    {
        public void Book(string eventName, DateTime date)
        {
            Console.WriteLine($"Registering for an event {eventName} on {date}.");
        }
    }

    public class ActivityBooker
    {
        public void Book(string activity, DateTime date)
        {
            Console.WriteLine($"Applying to activity {activity} on {date}");
        }
    }
}
