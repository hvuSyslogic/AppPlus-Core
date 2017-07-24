﻿using HisPlus.Infrastructure.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public abstract class CacheProviderBase : ICacheProviderBase
    {
        #region Abstract Properties

        public abstract IDatabase CurrentDB { get; }

        #endregion

        public string KeyFormat { get; set; }

        #region StringSet
       
        public bool StringSet(string key, string value, TimeSpan? expiry = default(TimeSpan?))
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.StringSet(key, value, expiry));
        }
      
        public bool StringSet(List<KeyValuePair<RedisKey, RedisValue>> kvps)
        {
            var customizedKeyKvps = kvps.Select(p => new KeyValuePair<RedisKey, RedisValue>(p.Key.ToString().CustomizeKey(KeyFormat), p.Value)).ToList();
            return Do(db => db.StringSet(customizedKeyKvps.ToArray()));
        }
       
        public bool StringSet<T>(string key, T o, TimeSpan? expiry = default(TimeSpan?))
        {
            key = key.CustomizeKey(KeyFormat);
            string json = ConvertToJson(o);
            return Do(db => db.StringSet(key, json, expiry));
        }

        #endregion StringSet

        #region StringGet
        
        public string StringGet(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.StringGet(key));
        }
       
        public RedisValue[] StringGet(List<string> keys)
        {
            var redisKey = keys.CustomizedKey(KeyFormat).ToRedisKey();
            
            return Do(db => db.StringGet(redisKey));
        }
    
        public T StringGet<T>(string key)
        {
            return Do(db => ConvertToObject<T>(db.StringGet(key.CustomizeKey(KeyFormat))));
        }
       
        public double StringIncrement(string key, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.StringIncrement(key, val));
        }

        public double StringDecrement(string key, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.StringDecrement(key, val));
        }

        #endregion StringGet

        #region StringSetAsync
       
        public async Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = default(TimeSpan?))
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.StringSetAsync(key, value, expiry));
        }

        public async Task<bool> StringSetAsync(List<KeyValuePair<RedisKey, RedisValue>> keyValues)
        {
            List<KeyValuePair<RedisKey, RedisValue>> newkeyValues =
                keyValues.Select(p => new KeyValuePair<RedisKey, RedisValue>(p.Key.ToString().CustomizeKey(KeyFormat), p.Value)).ToList();
            return await Do(db => db.StringSetAsync(newkeyValues.ToArray()));
        }

        public async Task<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?))
        {
            key = key.CustomizeKey(KeyFormat);
            string json = ConvertToJson(obj);
            return await Do(db => db.StringSetAsync(key, json, expiry));
        }

        #endregion StringSetAsync

        #region StringGetAsync
        public async Task<string> StringGetAsync(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.StringGetAsync(key));
        }

        public async Task<RedisValue[]> StringGetAsync(List<string> keys)
        {
            var redisKey = keys.CustomizedKey().ToRedisKey();
            return await Do(db => db.StringGetAsync(redisKey));
        }

        public async Task<T> StringGetAsync<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            string result = await Do(db => db.StringGetAsync(key));
            return ConvertToObject<T>(result);
        }

        public async Task<double> StringIncrementAsync(string key, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.StringIncrementAsync(key, val));
        }

        public async Task<double> StringDecrementAsync(string key, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.StringDecrementAsync(key, val));
        }

        #endregion StringGetAsync

        #region Hash

        public bool HashExists(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.HashExists(key, hashField));
        }

        public bool HashSet<T>(string key, string hashField, T o)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db =>
            {
                string json = ConvertToJson(o);
                return db.HashSet(key, hashField, json);
            });
        }

        public bool HashDelete(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.HashDelete(key, hashField));
        }

        public long HashDelete(string key, List<RedisValue> hashFields)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.HashDelete(key, hashFields.ToArray()));
        }

        public T HashGet<T>(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db =>
            {
                string value = db.HashGet(key, hashField);
                return ConvertToObject<T>(value);
            });
        }

        public double HashIncrement(string key, string hashField, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.HashIncrement(key, hashField, val));
        }

        public double HashDecrement(string key, string hashField, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db => db.HashDecrement(key, hashField, val));
        }

        public List<T> HashKeys<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db =>
            {
                RedisValue[] values = db.HashKeys(key);
                return ConvertToList<T>(values);
            });
        }

        public async Task<bool> HashExistsAsync(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.HashExistsAsync(key, hashField));
        }

        public async Task<bool> HashSetAsync<T>(string key, string hashField, T o)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db =>
            {
                string json = ConvertToJson(o);
                return db.HashSetAsync(key, hashField, json);
            });
        }

        public async Task<bool> HashDeleteAsync(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.HashDeleteAsync(key, hashField));
        }

        public async Task<long> HashDeleteAsync(string key, List<RedisValue> hashFields)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.HashDeleteAsync(key, hashFields.ToArray()));
        }

        public async Task<T> HashGeAsync<T>(string key, string hashField)
        {
            key = key.CustomizeKey(KeyFormat);
            string value = await Do(db => db.HashGetAsync(key, hashField));
            return ConvertToObject<T>(value);
        }

        public async Task<double> HashIncrementAsync(string key, string hashField, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.HashIncrementAsync(key, hashField, val));
        }

        public async Task<double> HashDecrementAsync(string key, string hashField, double val = 1)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.HashDecrementAsync(key, hashField, val));
        }

        public async Task<List<T>> HashKeysAsync<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            RedisValue[] redisValue = await Do(db => db.HashKeysAsync(key));
            
            return ConvertToList<T>(redisValue);
        }

        #endregion Hash

        #region List
       
        public void ListRemove<T>(string key, T value)
        {
            key = key.CustomizeKey(KeyFormat);
            Do(db => db.ListRemove(key, ConvertToJson(value)));
        }

        public List<T> ListRange<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(redis =>
            {
                var values = redis.ListRange(key);
                return ConvertToList<T>(values);
            });
        }

        public void ListRightPush<T>(string key, T value)
        {
            key = key.CustomizeKey(KeyFormat);
            Do(db => db.ListRightPush(key, ConvertToJson(value)));
        }

        public T ListRightPop<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db =>
            {
                var value = db.ListRightPop(key);
                return ConvertToObject<T>(value);
            });
        }

        public void ListLeftPush<T>(string key, T value)
        {
            key = key.CustomizeKey(KeyFormat);
            Do(db => db.ListLeftPush(key, ConvertToJson(value)));
        }

        public T ListLeftPop<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(db =>
            {
                var value = db.ListLeftPop(key);
                return ConvertToObject<T>(value);
            });
        }

        public long ListLength(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            return Do(redis => redis.ListLength(key));
        }

        public async Task<long> ListRemoveAsync<T>(string key, T value)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.ListRemoveAsync(key, ConvertToJson(value)));
        }

        public async Task<List<T>> ListRangeAsync<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            var values = await Do(redis => redis.ListRangeAsync(key));
            return ConvertToList<T>(values);
        }

        public async Task<long> ListRightPushAsync<T>(string key, T value)
        {
            return await Do(db => db.ListRightPushAsync(key.CustomizeKey(key), ConvertToJson(value)));
        }

        public async Task<T> ListRightPopAsync<T>(string key)
        {
            key = key.CustomizeKey(KeyFormat);
            var value = await Do(db => db.ListRightPopAsync(key));
            return ConvertToObject<T>(value);
        }

        public async Task<long> ListLeftPushAsync<T>(string key, T value)
        {
            key = key.CustomizeKey(KeyFormat);
            return await Do(db => db.ListLeftPushAsync(key, ConvertToJson(value)));
        }

        public async Task<T> ListLeftPopAsync<T>(string key)
        {         
            var value = await Do(db => db.ListLeftPopAsync(key.CustomizeKey(KeyFormat)));
            return ConvertToObject<T>(value);
        }

        public async Task<long> ListLengthAsync(string key)
        {
            return await Do(redis => redis.ListLengthAsync(key.CustomizeKey(KeyFormat)));
        }

        #endregion List

        #region SortedSet
  
        public bool SortedSetAdd<T>(string key, T value, double score)
        {
            return Do(redis => redis.SortedSetAdd(key.CustomizeKey(KeyFormat), ConvertToJson<T>(value), score));
        }

        public bool SortedSetRemove<T>(string key, T value)
        {         
            return Do(redis => redis.SortedSetRemove(key.CustomizeKey(KeyFormat), ConvertToJson(value)));
        }
     
        public List<T> SortedSetRangeByRank<T>(string key)
        {
            return Do(redis =>
            {
                var values = redis.SortedSetRangeByRank(key.CustomizeKey(KeyFormat));
                return ConvertToList<T>(values);
            });
        }
       
        public long SortedSetLength(string key)
        {
            return Do(redis => redis.SortedSetLength(key.CustomizeKey(KeyFormat)));
        }
    
        public async Task<bool> SortedSetAddAsync<T>(string key, T value, double score)
        {
            return await Do(redis => redis.SortedSetAddAsync(key.CustomizeKey(KeyFormat), ConvertToJson<T>(value), score));
        }
      
        public async Task<bool> SortedSetRemoveAsync<T>(string key, T value)
        {         
            return await Do(redis => redis.SortedSetRemoveAsync(key.CustomizeKey(KeyFormat), ConvertToJson(value)));
        }

        public async Task<List<T>> SortedSetRangeByRankAsync<T>(string key)
        {         
            var values = await Do(redis => redis.SortedSetRangeByRankAsync(key.CustomizeKey(KeyFormat)));

            return ConvertToList<T>(values);
        }

        public async Task<long> SortedSetLengthAsync(string key)
        {
            return await Do(redis => redis.SortedSetLengthAsync(key.CustomizeKey(KeyFormat)));
        }

        #endregion SortedSet

        #region key
       
        public bool KeyDelete(string key)
        {
            return Do(db => db.KeyDelete(key.CustomizeKey(KeyFormat)));
        }
   
        public long KeyDelete(List<string> keys)
        {
            var redisKey = keys.CustomizedKey().ToRedisKey();
            return Do(db => db.KeyDelete(redisKey));
        }
     
        public bool KeyExists(string key)
        {
            return Do(db => db.KeyExists(key.CustomizeKey(KeyFormat)));
        }
    
        public bool KeyRename(string key, string newKey)
        {
            return Do(db => db.KeyRename(key.CustomizeKey(KeyFormat), newKey));
        }
     
        public bool KeyExpire(string key, TimeSpan? expiry = default(TimeSpan?))
        {
            return Do(db => db.KeyExpire(key.CustomizeKey(KeyFormat), expiry));
        }

        #endregion key

        #region

        public ITransaction CreateTransaction()
        {
            return CurrentDB.CreateTransaction();
        }

        public IDatabase GetDatabase()
        {
            return CurrentDB;
        }
       
        #endregion

        #region Utils Method      

        private T Do<T>(Func<IDatabase, T> func)
        {
            return func(CurrentDB);
        }

        private string ConvertToJson<T>(T value)
        {
            string result = value is string ? value.ToString() : JsonConvert.SerializeObject(value);
            return result;
        }

        private T ConvertToObject<T>(RedisValue value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        private List<T> ConvertToList<T>(RedisValue[] values)
        {
            List<T> result = new List<T>();
            foreach (var item in values)
            {
                var model = ConvertToObject<T>(item);
                result.Add(model);
            }
            return result;
        }

        #endregion
    }
}


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