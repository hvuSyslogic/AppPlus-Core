using Castle.Core.Logging;
using HisPlus.Core.Infrastructure.CodeContracts;
using HisPlus.Infrastructure;
using HisPlus.Infrastructure.Configuration;
using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class RedisCacheDatabaseProvider : IRedisCacheDatabaseProvider
    {
        private readonly ILogger _logger;
        private readonly RedisCacheOptions _options;
        private readonly Lazy<ConnectionMultiplexer> _connectionMultiplexer;

        public RedisCacheDatabaseProvider(RedisCacheOptions options, ILogger logger)
        {
            Requires.NotNull(options, "options");
            this._logger = logger;
            this._options = options;
            this._connectionMultiplexer = new Lazy<ConnectionMultiplexer>(CreateConnectionMultiplexer);            
        }

        #region GetDatabase()

        public IDatabase GetDatabase()
        {
            return _connectionMultiplexer.Value.GetDatabase(_options.DatabaseId);
        }

        public RedisCacheOptions Options
        {
            get { return this._options; }
        }

        #endregion

        #region CreateConnectionMultiplexer

        private ConnectionMultiplexer CreateConnectionMultiplexer()
        {
            _logger.DebugFormat("Connect to database {0} with connectionstring '{1}'.", this._options.DatabaseId, this._options.ConnectionString);
            return ConnectionMultiplexer.Connect(_options.ConnectionString);
        }

        #endregion
    } 
}
