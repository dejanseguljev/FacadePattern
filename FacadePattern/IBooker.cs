using System.Collections.Generic;

namespace FacadePattern
{
    public interface IBooker
    {
        void Book(string name, IDictionary<string, object> args);
    }
}
