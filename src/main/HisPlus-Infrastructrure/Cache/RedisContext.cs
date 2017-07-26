using CachingFramework.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class RedisContext : Context, IRedisContext
    {
        public RedisContext(string connectionString)
            : base(connectionString)
        {

        }
    }
}
