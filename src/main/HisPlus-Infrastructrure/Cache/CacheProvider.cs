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
    public class CacheProvider : CacheBase, ICacheProvider
    {
        private int _db;

        #region Constructor(s)

        public CacheProvider(int db)
        {
            this._db = db;
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