using CachingFramework.Redis.Contracts;
using CachingFramework.Redis.Contracts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Redis
{
    public static partial class ICacheProviderEx
    {
        #region constant(s)
        private const string HashedKeyFormat = "{0}:hash";        
        private const string HashedFieldFormat = "{0}:ID:{1}";
        private const string ObjectKeyFormat = "{0}:{1}";
        #endregion        

        #region Add Tags
        public static void AddTagsToHashField<T>(this ICacheProvider cacheProvider, object key, string[] tags)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            var field = GetHashField<T>(key);

            cacheProvider.AddTagsToHashField(redisKey, field, tags);
        }

        public static void AddTagsToKey<T>(this ICacheProvider cacheProvider, string[] tags, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            cacheProvider.AddTagsToKey(redisKey, tags);
        }

        public static void AddTagsToSetMember<T>(this ICacheProvider cacheProvider, T member, string[] tags)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Add to Set
        public static void AddToSet<T>(this ICacheProvider cacheProvider, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }

        public static void AddToSortedSet<T>(this ICacheProvider cacheProvider, double score, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region FetchHashed
        public static T FetchHashed<T>(this ICacheProvider cacheProvider, T value, Func<string> keyBuilder, Func<T, string> fieldBuilder, Func<T> func, TimeSpan? expiry = null)
        {
            var key = keyBuilder();
            var field = fieldBuilder.Invoke(value);
            return cacheProvider.FetchHashed(key, field, func, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, T value, Func<string> keyBuilder, Func<T, string> fieldBuilder, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var key = keyBuilder();
            var field = fieldBuilder.Invoke(value);
            return cacheProvider.FetchHashed(key, field, func, tagsBuilder, expiry);
        }        
        #endregion

        #region FetchObject
        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, TimeSpan? expiry = null)
        {
            var redisKey = GetRedisKey<T>(CacheType.Object, key);
            return cacheProvider.FetchObject(redisKey, func, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var redisKey = GetRedisKey<T>(CacheType.Object, key);
            return cacheProvider.FetchObject(redisKey, func, tagsBuilder, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, string[] tags, TimeSpan? expiry = null)
        {
            var redisKey = GetRedisKey<T>(CacheType.Object, key);
            return cacheProvider.FetchObject(redisKey, func, tags, expiry);
        }
        #endregion

        //void FlushAll();        

        //IEnumerable<string> GetAllTags();

        #region GetHashed
        public static T GetHashed<T>(this ICacheProvider cacheProvider, object key)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            var field = GetHashField<T>(key);
            return cacheProvider.GetHashed<T>(redisKey, field);
        }

        public static TV GetHashed<TK, TV>(this ICacheProvider cacheProvider, long key, TK field)
        {
            throw new NotImplementedException();
        }
        
        public static IDictionary<string, T> GetHashedAll<T>(this ICacheProvider cacheProvider)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            return cacheProvider.GetHashedAll<T>(redisKey);
        }
        #endregion

        //IEnumerable<string> GetKeysByPattern(string pattern);

        //IEnumerable<string> GetKeysByTag(string[] tags, bool cleanUp = false);

        public static IList<string> GetRawKeysByTag(this ICacheProvider cacheProvider, string[] tags, CacheType cacheType = CacheType.Hash,  bool cleanUp = false)
        {
            var keys = new List<string>();
            var result = cacheProvider.GetKeysByTag(tags, cleanUp).ToList();
            result.ForEach(x => 
            {
                var key = "";
                if (cacheType == CacheType.Hash)
                {
                    key = x.Split('$').FirstOrDefault().TrimEnd(':');
                }
                else
                {                                            
                    key = x.Split(':').LastOrDefault().Trim();                    
                }

                if (!string.IsNullOrWhiteSpace(key))
                {
                    keys.Add(key);
                }               
            });

            return keys.Distinct().ToList();
        }

        public static T GetObject<T>(this ICacheProvider cacheProvider, Func<T, string> keyBuilder, T value)
        {
            return cacheProvider.GetObject<T>(keyBuilder.Invoke(value));
        }

        //IEnumerable<T> GetObjectsByTag<T>(params string[] tags);

        public static T GetSetObject<T>(this ICacheProvider cacheProvider, object key, T value)
        {
            var redisKey = GetRedisKey<T>(CacheType.Object, key);
            return cacheProvider.GetSetObject(redisKey, value);
        }

        //bool HyperLogLogAdd<T>(string key, T item);

        //bool HyperLogLogAdd<T>(string key, T[] items);

        //long HyperLogLogCount(string key);

        //void InvalidateKeysByTag(params string[] tags);

        public static bool KeyExists<T>(this ICacheProvider cacheProvider, Func<T, string> keyBuilder, T value)
        {
            return cacheProvider.KeyExists(keyBuilder.Invoke(value));
        }

        public static bool KeyExists<T>(this ICacheProvider cacheProvider, Func<string> keyBuilder)
        {
            return cacheProvider.KeyExists(keyBuilder.Invoke());
        }

        public static bool KeyExpire<T>(this ICacheProvider cacheProvider, DateTime expiration, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            return cacheProvider.KeyExpire(redisKey, expiration);
        }

        public static bool KeyPersist<T>(this ICacheProvider cacheProvider, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            return cacheProvider.KeyPersist(redisKey);
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider cacheProvider, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            return cacheProvider.KeyTimeToLive(redisKey);
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider cacheProvider, TimeSpan ttl, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            return cacheProvider.KeyTimeToLive(redisKey, ttl);
        }

        public static bool RemoveKey<T>(this ICacheProvider cacheProvider, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            return cacheProvider.Remove(redisKey);
        }

        public static void RemoveKey<T>(this ICacheProvider cacheProvider, object[] keys)
        {
            string[] redisKeys = new string[keys.Length];
            for (int i = 0; i < keys.Length; i++)
            {
                redisKeys[i] = GetRedisKey<T>(CacheType.Object, keys[i]);
            }

            cacheProvider.Remove(redisKeys);
        }

        //bool RemoveFromSet<T>(string key, T value);

        //bool RemoveFromSortedSet<T>(string key, T value);

        public static bool RemoveHashed<T>(this ICacheProvider cacheProvider, object key)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            var field = GetHashField<T>(key);
            return cacheProvider.RemoveHashed(redisKey, field);
        }

        public static void RemoveTagsFromHashField<T>(this ICacheProvider cacheProvider, object field, string[] tags) 
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            if (field == null)
            {
                throw new ArgumentNullException("field");
            }
                
            cacheProvider.RemoveTagsFromHashField(redisKey, GetHashField<T>(field), tags);
        }

        public static void RemoveTagsFromKey<T>(this ICacheProvider cacheProvider, string[] tags, CacheType cacheType = CacheType.Hash, object key = null)
        {
            var redisKey = GetRedisKey<T>(cacheType, key);
            cacheProvider.RemoveTagsFromKey(redisKey, tags);
        }

        //void RemoveTagsFromSetMember<T>(string key, T member, string[] tags) { throw new NotImplementedException(); }

        public static void RenameTagForHashField<T>(this ICacheProvider cacheProvider, string field, string currentTag, string newTag) 
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            cacheProvider.RenameTagForHashField(redisKey, field, currentTag, newTag);
        }

        //void RenameTagForKey(string key, string currentTag, string newTag) { throw new NotImplementedException(); }

        //void RenameTagForSetMember<T>(string key, T member, string currentTag, string newTag) { throw new NotImplementedException(); }

        //IEnumerable<KeyValuePair<string, T>> ScanHashed<T>(string key, string pattern) { throw new NotImplementedException(); }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, IDictionary<string, T> fieldValues)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            cacheProvider.SetHashed<T>(redisKey, fieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, IDictionary<object, T> fieldValues)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            IDictionary<string, T> redisFieldValues = new Dictionary<string, T>();
            
            foreach(var fldValue in fieldValues)
            {
                var key = GetHashField<T>(fldValue.Key);
                redisFieldValues.Add(key, fldValue.Value);
            };
            cacheProvider.SetHashed<T>(redisKey, redisFieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, object key, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            var field = GetHashField<T>(key);
            cacheProvider.SetHashed<T>(redisKey, field, value, ttl, when);
        }

        //public static void SetHashed<TK, TV>(this ICacheProvider cacheProvider, string key, TK field, TV value, TimeSpan? ttl = null, When when = When.Always);

        public static void SetHashed<T>(this ICacheProvider cacheProvider, object key, T value, string[] tags, TimeSpan? ttl = null, When when = When.Always)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            var field = GetHashField<T>(key);
            cacheProvider.SetHashed<T>(redisKey, field, value, tags, ttl, when);
        }

        //public static void SetHashed<TK, TV>(string key, TK field, TV value, string[] tags, TimeSpan? ttl = null, When when = When.Always) { }

        public static void SetObject<T>(this ICacheProvider cacheProvider, Func<T, string> keyBuilder, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject<T>(keyBuilder.Invoke(value), value, ttl, when);
        }

        public static void SetObject<T>(this ICacheProvider cacheProvider, Func<T, string> keyBuilder, T value, Func<T, string[]> tagsBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject<T>(keyBuilder.Invoke(value), value, tagsBuilder.Invoke(value), ttl, when);
        }

        public static bool TryGetHashed<T>(this ICacheProvider cacheProvider, object key, out T value)
        {
            var redisKey = GetRedisKey<T>(CacheType.Hash);
            return cacheProvider.TryGetHashed<T>(redisKey, GetHashField<T>(key), out value);
        }

        public static bool TryGetObject<T>(this ICacheProvider cacheProvider, object key, out T value)
        {
            var redisKey = GetRedisKey<T>(CacheType.Object, key);
            return cacheProvider.TryGetObject<T>(redisKey, out value);
        }
       
        #region private method(s)

        private static string GetTableName<T>()
        {
            return typeof(T).Name.Replace("DTO", "").Replace("Info", "");
        }

        //private static string GetHashedKey<T>()
        //{
        //    return string.Format(HashedKeyFormat, GetTableName<T>());
        //}

        private static string GetHashField<T>(object key)
        {
            return string.Format(HashedFieldFormat, GetTableName<T>(), key);
        }

        //private static string GetObjectKey<T>(object key)
        //{
        //    return string.Format(ObjectKeyFormat, GetTableName<T>(), key);
        //}

        private static string GetRedisKey<T>(CacheType cacheType, object key = null) 
        {
            string redisKey = "";
            if (cacheType == CacheType.Hash)
            {
                redisKey = string.Format(HashedKeyFormat, GetTableName<T>());
            }
            else
            {
                redisKey = string.Format(ObjectKeyFormat, GetTableName<T>(), key);
            }

            return redisKey;
        }
        #endregion
    }
}
