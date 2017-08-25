using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Redis
{
    public static class TypeEx
    {
        public static string GetKey(this object obj)
        {
            return obj.GetType().Name.Replace("DTO", "").Replace("Info", "");
        }
    }
}
