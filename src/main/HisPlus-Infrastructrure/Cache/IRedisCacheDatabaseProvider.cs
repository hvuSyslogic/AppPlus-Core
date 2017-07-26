using StackExchange.Redis;
using System;

namespace HisPlus.Infrastructure.Cache
{
    public interface IRedisCacheDatabaseProvider
    {
        IDatabase GetDatabase();

        RedisCacheOptions Options { get; }
    }
}
