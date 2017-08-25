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
        private static string GetKey<T>(Func<string, string> keyBuilder)
        {
            var tableName = typeof(T).Name.Replace("DTO", "").Replace("Info", "");
            return keyBuilder.Invoke(tableName);
        }

        private static string GetKey<T>(T value, Func<T, string> keyBuilder)
        {
            return keyBuilder.Invoke(value);
        }

        #region Add Tags
        public static void AddTagsToHashField<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            var tags = tagsBuilder.Invoke(value);

            provider.AddTagsToHashField(key, field, tags);
        }

        public static void AddTagsToKey<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var tags = tagsBuilder.Invoke(value);
            provider.AddTagsToKey(key, tags);
        }

        public static void AddTagsToKey<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>(value, keyBuilder);
            var tags = tagsBuilder.Invoke(value);
            provider.AddTagsToKey(key, tags);
        }

        public static void AddTagsToSetMember<T>(this ICacheProvider provider, T member, string[] tags)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Add to Set
        public static void AddToSet<T>(this ICacheProvider provider, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }

        public static void AddToSortedSet<T>(this ICacheProvider provider, double score, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region FetchHashed
        public static T FetchHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, Func<T> func, TimeSpan? expiry = null)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            return provider.FetchHashed(key, field, func, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            return provider.FetchHashed(key, field, func, tagsBuilder, expiry);
        }        
        #endregion

        #region FetchObject
        public static T FetchObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, Func<T> func, TimeSpan? expiry = null)
        {
            var key = keyBuilder.Invoke(value);
            return provider.FetchObject(key, func, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var key = keyBuilder.Invoke(value);
            return provider.FetchObject(key, func, tagsBuilder, expiry);
        }
        #endregion

        //void FlushAll();        

        //IEnumerable<string> GetAllTags();

        #region GetHashed
        public static T GetHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            return provider.GetHashed<T>(key, field);
        }

        public static TV GetHashed<TK, TV>(this ICacheProvider provider, long key, TK field)
        {
            throw new NotImplementedException();
        }

        public static IDictionary<string, T> GetHashedAll<T>(this ICacheProvider provider, Func<string> keyBuilder)
        {
            var key = keyBuilder.Invoke();
            return provider.GetHashedAll<T>(key);
        }
        #endregion

        //IEnumerable<string> GetKeysByPattern(string pattern);

        //IEnumerable<string> GetKeysByTag(string[] tags, bool cleanUp = false);

        public static IList<string> GetRawKeysByTag(this ICacheProvider provider, string[] tags, CacheType cacheType = CacheType.Hash,  bool cleanUp = false)
        {
            var keys = new List<string>();
            var result = provider.GetKeysByTag(tags, cleanUp).ToList();
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

        public static T GetObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder)
        {
            return provider.GetObject<T>(keyBuilder.Invoke(value));
        }

        //IEnumerable<T> GetObjectsByTag<T>(params string[] tags);

        //public static T GetSetObject<T>(this ICacheProvider provider, object key, T value)
        //{
        //    var redisKey = GetRedisKey<T>(CacheType.Object, key);
        //    return provider.GetSetObject(redisKey, value);
        //}

        //bool HyperLogLogAdd<T>(string key, T item);

        //bool HyperLogLogAdd<T>(string key, T[] items);

        //long HyperLogLogCount(string key);

        //void InvalidateKeysByTag(params string[] tags);

        public static bool KeyExists<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder)
        {
            var key = keyBuilder.Invoke(value);
            return provider.KeyExists(key);
        }

        public static bool KeyExists<T>(this ICacheProvider provider, Func<string, string> keyBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.KeyExists(key);
        }

        public static bool KeyExpire<T>(this ICacheProvider provider, Func<string, string> keyBuilder, DateTime expiration)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.KeyExpire(key, expiration);
        }

        public static bool KeyExpire<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, DateTime expiration)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.KeyExpire(key, expiration);
        }        

        public static bool KeyPersist<T>(this ICacheProvider provider, Func<string, string> keyBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.KeyPersist(key);
        }

        public static bool KeyPersist<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.KeyPersist(key);
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider provider, Func<string, string> keyBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.KeyTimeToLive(key);
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.KeyTimeToLive(key);
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, TimeSpan ttl)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.KeyTimeToLive(key, ttl);
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider provider, Func<string, string> keyBuilder, TimeSpan ttl)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.KeyTimeToLive(key, ttl);
        }

        public static bool RemoveKey<T>(this ICacheProvider provider, Func<string, string> keyBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            return provider.Remove(key);
        }

        public static bool RemoveKey<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.Remove(key);
        }

        //public static void RemoveKey<T>(this ICacheProvider provider, object[] keys)
        //{
        //    string[] redisKeys = new string[keys.Length];
        //    for (int i = 0; i < keys.Length; i++)
        //    {
        //        redisKeys[i] = GetRedisKey<T>(CacheType.Object, keys[i]);
        //    }

        //    provider.Remove(redisKeys);
        //}

        public static void RemoveKey<T>(this ICacheProvider provider, T[] values, Func<T[], string[]> keysBuilder)
        {
            var keys = keysBuilder.Invoke(values);
            //string[] redisKeys = new string[keys.Length];
            //for (int i = 0; i < keys.Length; i++)
            //{
            //    redisKeys[i] = GetRedisKey<T>(CacheType.Object, keys[i]);
            //}

            provider.Remove(keys);
        }

        //bool RemoveFromSet<T>(string key, T value);

        //bool RemoveFromSortedSet<T>(string key, T value);

        public static bool RemoveHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> hashFieldBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var field = hashFieldBuilder.Invoke(value);
            return provider.RemoveHashed(key, field);
        }

        public static void RemoveTagsFromHashField<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, Func<T, string[]> tagsBuilder) 
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            var tags = tagsBuilder.Invoke(value);
            provider.RemoveTagsFromHashField(key, field, tags);
        }

        public static void RemoveTagsFromKey<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var tags = tagsBuilder.Invoke(value);
            provider.RemoveTagsFromKey(key, tags);
        }        

        public static void RemoveTagsFromKey<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, string[] tags)
        {
            var key = GetKey<T>(keyBuilder);
            provider.RemoveTagsFromKey(key, tags);
        }

        public static void RemoveTagsFromKey<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = keyBuilder.Invoke(value);
            var tags = tagsBuilder.Invoke(value);
            provider.RemoveTagsFromKey(key, tags);
        }

        //void RemoveTagsFromSetMember<T>(string key, T member, string[] tags) { throw new NotImplementedException(); }

        public static void RenameTagForHashField<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> hashFieldBuilder, string currentTag, string newTag) 
        {
            var key = GetKey<T>(keyBuilder);
            var field = hashFieldBuilder.Invoke(value);
            provider.RenameTagForHashField(key, field, currentTag, newTag);
        }

        //void RenameTagForKey(string key, string currentTag, string newTag) { throw new NotImplementedException(); }

        //void RenameTagForSetMember<T>(string key, T member, string currentTag, string newTag) { throw new NotImplementedException(); }

        //IEnumerable<KeyValuePair<string, T>> ScanHashed<T>(string key, string pattern) { throw new NotImplementedException(); }

        public static void SetHashed<T>(this ICacheProvider provider, T[] values, Func<string, string> keyBuilder, Func<T[], IDictionary<string, T>> fieldsBuilder)
        {
            var key = GetKey<T>(keyBuilder);
            var fieldValues = fieldsBuilder.Invoke(values);
            provider.SetHashed<T>(key, fieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            provider.SetHashed<T>(key, field, value, ttl, when);
        }

        //public static void SetHashed<TK, TV>(this ICacheProvider provider, string key, TK field, TV value, TimeSpan? ttl = null, When when = When.Always);

        public static void SetHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> fieldBuilder, Func<T, string[]> tagsBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(keyBuilder);
            var field = fieldBuilder.Invoke(value);
            var tags = tagsBuilder.Invoke(value);
            provider.SetHashed<T>(key, field, value, tags, ttl, when);
        }

        //public static void SetHashed<TK, TV>(string key, TK field, TV value, string[] tags, TimeSpan? ttl = null, When when = When.Always) { }

        public static void SetObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(value, keyBuilder);
            provider.SetObject<T>(key, value, ttl, when);
        }

        public static void SetObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, Func<T, string[]> tagsBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(value, keyBuilder);
            provider.SetObject<T>(key, value, tagsBuilder.Invoke(value), ttl, when);
        }

        public static bool TryGetHashed<T>(this ICacheProvider provider, T value, Func<string, string> keyBuilder, Func<T, string> hashFieldBuilder, out T result)
        {
            var key = GetKey<T>(keyBuilder);
            var field = hashFieldBuilder.Invoke(value);
            return provider.TryGetHashed<T>(key, field, out result);
        }

        public static bool TryGetObject<T>(this ICacheProvider provider, T value, Func<T, string> keyBuilder, out T result)
        {
            var key = GetKey<T>(value, keyBuilder);
            return provider.TryGetObject<T>(key, out result);
        }              
    }
}
