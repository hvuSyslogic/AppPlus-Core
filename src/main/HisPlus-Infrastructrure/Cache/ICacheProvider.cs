using StackExchange.Redis;
using System;

namespace HisPlus.Infrastructure.Cache
{
    public interface ICacheProvider : ICacheBase
    {
        ICacheManager CacheManager { get; set; }
        
        IDatabase CurrentDB { get; }    
    }
}
