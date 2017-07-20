using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Core.Redis
{
    public class MetaDataCacheProvider : CacheProvider, ICacheProvider
    {
        private const int Db = 0;

        public MetaDataCacheProvider()
            : base(Db)
        {

        }
    }
}