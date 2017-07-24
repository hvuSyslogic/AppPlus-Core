using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class Db0CacheProvider : CacheProvider, ICacheProvider
    {
        public Db0CacheProvider(string keyFormat) 
            : base(0, keyFormat)
        {
        }
    }
}
