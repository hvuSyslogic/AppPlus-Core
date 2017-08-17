using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Redis
{
    public enum CacheType
    {
        Object = 0,
        Hashed = 1,
        Sorted = 2,
    }
}
