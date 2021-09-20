using System.Collections.Generic;

namespace FacadePattern
{
    public class BookerFacade: IBooker
    {
        private readonly Dictionary<string, IBooker> _bookers = new Dictionary<string, IBooker>();

        public void Register(string name, IBooker booker)
        {
            _bookers[name] = booker;
        }

        public void Book(string name, IDictionary<string, object> args)
        {
            if (_bookers.TryGetValue(name, out IBooker booker))
            {
                booker.Book(name, args);
            }
            else
            {
                throw new KeyNotFoundException($"There is no booker registered for {name}");
            }
        }
    }
}
