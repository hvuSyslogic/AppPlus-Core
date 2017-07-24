using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class Db1CacheProvider : CacheProvider, ICacheProvider
    {
        public Db1CacheProvider(string keyFormat)
            : base(1, keyFormat)
        {
        }
    }
}
