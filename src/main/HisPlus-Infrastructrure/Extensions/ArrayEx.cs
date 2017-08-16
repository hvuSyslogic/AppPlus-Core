using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Extensions
{
    public static class ArrayEx
    {
        public static T[] ForEach<T>(this T[] list, Action<T> action)
        {
            foreach (T item in list)
            {
                action(item);
            }

            return list;
        }
    }

}
