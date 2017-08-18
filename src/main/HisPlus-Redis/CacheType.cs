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
        Hash = 1,
        Set = 2,
        SortedSet = 4,
        String = 5,
    }
}
