using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Client
{
    public class CacheHandler
    {
        #region Properties

        private static IRedisCache CacheProvider 
        {
            get { return IoCManager.Container.Resolve<IRedisCache>(); } 
        }

        #endregion

        #region GetResultFromCache
        public static TResult GetResultFromCache<TResult>(string key)
        {
            TResult result = default(TResult);
            if (CacheProvider.KeyExists(key))
            {
                var value = CacheProvider.ListRange<TResult>(key);
                return (TResult)Convert.ChangeType(value, typeof(TResult));
            }

            return result;
        }

        public static async void SetResultToCache<TResult>(string key, TResult result)
        {            
           await CacheProvider.ListLeftPushAsync<TResult>(key, result);
        }
        #endregion
    }
}
