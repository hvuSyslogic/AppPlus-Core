using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public static class CacheEx
    {
        public static List<string> CustomizedKey(this List<string> keys, string keyFormat = "")
        {
            return keys.Select(x => x.CustomizeKey(keyFormat)).ToList();
        }

        public static RedisKey[] ToRedisKey(this List<string> keys)
        {
            return keys.Select(x => (RedisKey)x).ToArray();
        }

        public static string CustomizeKey(this string key, string keyFormat)
        {
            return string.Format(keyFormat, key);
        }
    }
}
