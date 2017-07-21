using Castle.Core.Logging;
using StackExchange.Redis;
using System;

namespace HisPlus.Infrastructure.Cache
{
    public interface ICacheManager
    {
        ConnectionMultiplexer Connection { get; }
        
        ILogger Logger { get; set; }
    }
}
