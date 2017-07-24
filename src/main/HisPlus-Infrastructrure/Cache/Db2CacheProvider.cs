using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class Db2CacheProvider : CacheProvider, ICacheProvider
    {
        public Db2CacheProvider(string keyFormat)
            : base(2, keyFormat)
        {
        }
    }
}
