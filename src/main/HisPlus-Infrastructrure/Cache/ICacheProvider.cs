using StackExchange.Redis;
using System;

namespace HisPlus.Infrastructure.Cache
{
    public interface ICacheProvider : ICacheProviderBase
    {
        ICacheManager CacheManager { get; set; }        
    }
}