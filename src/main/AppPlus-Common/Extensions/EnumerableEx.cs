using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Common.Extensions
{
    public static class EnumerableEx
    {
        public static void ForEach<T>(this IEnumerable<T> list, Action<T> action)
        {
            foreach (T item in list) action(item);
        }
    }
}
