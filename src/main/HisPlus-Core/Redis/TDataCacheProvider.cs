using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Core.Redis
{
    public class TDataCacheProvider : CacheProvider, ICacheProvider
    {
        private const int Db = 1;

        public TDataCacheProvider()
            : base(Db)
        {

        }
    }
}
