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
    public class CacheManager : ICacheManager
    {
        private static ConnectionMultiplexer _connection;
        private static readonly object _locker = new object();     
        private static readonly Lazy<ConnectionMultiplexer> _lazyConnection;

        static CacheManager()
        {
            var connectionStringName = HisConfigurationManager.Configuration.ClientCacheProvider.ConnectionString.Name;
            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
            
            Requires.NotNullOrEmpty(connectionString, "connectionString");

            _lazyConnection = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(connectionString));
        }        

        #region properties

        public ILogger Logger { get; set; }

        public ConnectionMultiplexer Connection
        {
            get
            {
                if (_connection == null)
                {
                    lock (_locker)
                    {
                        if (_connection == null || !_connection.IsConnected)
                        {
                            _connection = _lazyConnection.Value;
                            RegisterEvents(_connection);
                        }
                    }
                }

                return _connection;
            }
        }

        #endregion

        #region RegisterEvents

        private void RegisterEvents(ConnectionMultiplexer connection)
        {
            if (connection != null)
            {
                connection.ConnectionFailed += MuxerConnectionFailed;
                connection.ConnectionRestored += MuxerConnectionRestored;
                connection.ErrorMessage += MuxerErrorMessage;
                connection.ConfigurationChanged += MuxerConfigurationChanged;
                connection.HashSlotMoved += MuxerHashSlotMoved;
                connection.InternalError += MuxerInternalError;
            }
        }

        #endregion

        #region Events

        private  void MuxerConfigurationChanged(object sender, EndPointEventArgs e)
        {
            Logger.ErrorFormat("Configuration changed to: {0}", e.EndPoint);
        }

        private void MuxerErrorMessage(object sender, RedisErrorEventArgs e)
        {
            Logger.ErrorFormat("ConnectionMultiplexer has error: {0}", e.Message);
        }

        private void MuxerConnectionRestored(object sender, ConnectionFailedEventArgs e)
        {
            Logger.ErrorFormat("ConnectionMultiplexer restored to: {0}", e.EndPoint);
        }

        private void MuxerConnectionFailed(object sender, ConnectionFailedEventArgs e)
        {
            Logger.ErrorFormat("ConnectionMultiplexer connection failed to: {0}, Error Message: {1}", e.EndPoint, e.FailureType + (e.Exception == null ? "" : (", " + e.Exception.Message)));
        }

        private void MuxerHashSlotMoved(object sender, HashSlotMovedEventArgs e)
        {
            Logger.ErrorFormat("ConnectionMultiplexer HashSlot has moved from {0} endpoint to {1} endpoint.", e.OldEndPoint, e.NewEndPoint);
        }
    
        private void MuxerInternalError(object sender, InternalErrorEventArgs e)
        {
            Logger.ErrorFormat("ConnectionMultiplexer Internal Error: Message ==> {0}", e.Exception.Message);
        }

        #endregion
    } 
}
