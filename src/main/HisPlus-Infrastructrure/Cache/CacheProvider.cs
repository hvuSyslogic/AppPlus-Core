using HisPlus.Infrastructure.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public abstract class CacheProvider : CacheProviderBase, ICacheProvider
    {
        private int _db;
        private string _keyFormat;

        #region Constructor(s)

        public CacheProvider(int db, string keyFormat)
        {
            this._db = db;
            this._keyFormat = keyFormat;
        }

        #endregion

        #region Properties

        public ICacheManager CacheManager { get; set; }

        public override IDatabase CurrentDB 
        {
            get { return CacheManager.Connection.GetDatabase(this._db); } 
        }
        #endregion
    }
}