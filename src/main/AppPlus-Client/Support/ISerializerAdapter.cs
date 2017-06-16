using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPlus.Client.Support
{
    public interface ISerializerAdapter
    {
        string Serialize(object obj);

        T Deserialize<T>(string input);
    }
}
