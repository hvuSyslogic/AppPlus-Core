using CachingFramework.Redis.Contracts;
using CachingFramework.Redis.Contracts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Redis
{
    public static partial class CacheProviderEx
    {
        #region Private method(s)
        public static string GetKey<T>()
        {
            return string.Format("{0}:{1}", GetTableName<T>(), "HASH");
        }

        public static string GetKey<T>(T value = default(T), Func<T, object> keyBuilder = null)
        {
            if (EqualityComparer<T>.Default.Equals(value, default(T)) || keyBuilder == null)            
            {
                return GetKey<T>();
            }

            return string.Format("{0}:{1}", GetTableName<T>(), keyBuilder.Invoke(value));
        }

        public static string GetTableName<T>()
        {
            return typeof(T).Name.Replace("DTO", "").Replace("Info", "");
        }

        public static string GetHashField<T>(T value, Func<T, object> hashFieldBuilder)
        {
            return string.Format("{0}:{1}", GetTableName<T>(), hashFieldBuilder.Invoke(value));
        }

        public static string[] GetTags<T>(T value, Func<T, string[]> tagsBuilder)
        {
            return tagsBuilder.Invoke(value).Select(x => string.Format("{0}:{1}", GetTableName<T>(), x)).ToArray();            
        }
        #endregion
        
        public static void AddTagsToKey<T>(this ICacheProvider cache, T value, Func<T, string[]> tagsBuilder, Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            cache.AddTagsToKey(key, tags);
        }

        public static void AddTagsToSetMember<T>(this ICacheProvider cache, T member, string[] tags)
        {
            throw new NotImplementedException();
        }

        public static void AddToSet<T>(this ICacheProvider cache, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }

        public static void AddToSortedSet<T>(this ICacheProvider cache, double score, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }        
       
        //void FlushAll();

        //IEnumerable<string> GetAllTags();

        //IEnumerable<string> GetKeysByPattern(string pattern);

        public static List<string> GetKeysByTag<T>(this ICacheProvider cache, T value, Func<T, string[]> tagsBuilder, bool cleanUp = false)
        {            
            var tags = GetTags<T>(value, tagsBuilder);
            var result = cache.GetKeysByTag(tags, cleanUp);
            var keys = result.Select(x => 
            {
                var key = "";
                
                if (x.IndexOf('$') > 0)
                {
                    key = x.Split('$').FirstOrDefault().TrimEnd(':');
                }else if (x.IndexOf(":HASH") > 0)
                {
                    key = x;
                }
                else
                {
                    key = x.Split(':').LastOrDefault().Trim();
                }

                return key;
            });

            return keys.Distinct().ToList();
        }

        //public static List<string> GetKeysByTag<T>(this ICacheProvider cache, T[] values, Func<T, string[]> tagsBuilder, bool cleanUp = false)
        //{
        //    List<string> keys = new List<string>() { };
        //    var result = values.Select(x =>
        //    {
        //        return cache.GetKeysByTag<T>(x, tagsBuilder, cleanUp);
        //    }).ToList();

        //    foreach (var item in result)
        //    {
        //        keys.Union(item);
        //    }

        //    return keys.Distinct().ToList();
        //}

        public static List<T> GetObjectsByTag<T>(this ICacheProvider cache, T value, Func<T, string[]> tagsBuilder)
        {
            var tags = GetTags<T>(value, tagsBuilder);
            return cache.GetObjectsByTag<T>(tags).Distinct().ToList();
        }

        //public static T GetSetObject<T>(this ICacheProvider cache, object key, T value);      

        //bool HyperLogLogAdd<T>(string key, T item);

        //bool HyperLogLogAdd<T>(string key, T[] items);

        //long HyperLogLogCount(string key);

        //void InvalidateKeysByTag(params string[] tags);

        public static bool KeyExists<T>(this ICacheProvider cache, T value = default(T), Func<T, object> keyBuilder = null)
        {            
            var key = GetKey<T>(value, keyBuilder);
            return cache.KeyExists(key);
        }

        public static bool KeyExpire<T>(this ICacheProvider cache, DateTime expiration, T value = default(T), Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.KeyExpire(key, expiration);
        }

        public static bool KeyPersist<T>(this ICacheProvider cache, T value = default(T), Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.KeyPersist(key);
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider cache, T value = default(T), Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.KeyTimeToLive(key);
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider cache, TimeSpan ttl, T value = default(T), Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.KeyTimeToLive(key, ttl);
        }

        public static bool RemoveKey<T>(this ICacheProvider cache, T value = default(T), Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.Remove(key);
        }        

        public static void RemoveKey<T>(this ICacheProvider cache, T[] values, Func<T, object> keyBuilder)
        {            
            var keys = values.Select(x => GetKey<T>(x, keyBuilder)).ToArray();
            cache.Remove(keys);
        }

        //bool RemoveFromSet<T>(string key, T value);

        //bool RemoveFromSortedSet<T>(string key, T value);

        public static void RemoveTagsFromKey<T>(this ICacheProvider cache, string[] tags)
        {
            var key = GetKey<T>();
            cache.RemoveTagsFromKey(key, tags);
        }

        public static void RemoveTagsFromKey<T>(this ICacheProvider cache, T value, Func<T, string[]> tagsBuilder, Func<T, object> keyBuilder = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            cache.RemoveTagsFromKey(key, tags);
        }

        //void RemoveTagsFromSetMember<T>(string key, T member, string[] tags) { throw new NotImplementedException(); }

        //void RenameTagForKey(string key, string currentTag, string newTag) { throw new NotImplementedException(); }

        //void RenameTagForSetMember<T>(string key, T member, string currentTag, string newTag) { throw new NotImplementedException(); }

        //IEnumerable<KeyValuePair<string, T>> ScanHashed<T>(string key, string pattern) { throw new NotImplementedException(); }
        
        #region Object
        public static void SetObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(value, keyBuilder);
            cache.SetObject<T>(key, value, ttl, when);
        }

        public static void SetObject<T>(this ICacheProvider cache, T[] values, Func<T, object> keyBuilder, TimeSpan? ttl = null, When when = When.Always)
        {            
            values.ToList().ForEach(x => 
            {
                var key = GetKey<T>(x, keyBuilder);
                cache.SetObject<T>(key, x, ttl, when);
            });
        }

        public static void SetObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder, Func<T, string[]> tagsBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>(value, keyBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            cache.SetObject<T>(key, value, tags, ttl, when);
        }

        public static bool TryGetObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder, out T result)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.TryGetObject<T>(key, out result);
        }

        public static T GetObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.GetObject<T>(key);
        }

        public static T FetchObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder, Func<T> func, TimeSpan? expiry = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            return cache.FetchObject(key, func, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cache, T value, Func<T, object> keyBuilder, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var key = GetKey<T>(value, keyBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            return cache.FetchObject(key, func, tags, expiry);
        }   
        #endregion

        #region Hash
        public static void AddTagsToHashField<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            var tags = GetTags<T>(value, tagsBuilder);

            cache.AddTagsToHashField(key, field, tags);
        }

        public static void SetHashed<T>(this ICacheProvider cache, T[] values, Func<T, object> hashFieldBuilder)
        {
            var key = GetKey<T>();
            var fieldValues = values.ToDictionary(x => GetHashField<T>(x, hashFieldBuilder));
            cache.SetHashed<T>(key, fieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            cache.SetHashed<T>(key, field, value, ttl, when);
        }

        //public static void SetHashed<TK, TV>(this ICacheProvider cache, string key, TK field, TV value, TimeSpan? ttl = null, When when = When.Always);

        public static void SetHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, Func<T, string[]> tagsBuilder, TimeSpan? ttl = null, When when = When.Always)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            cache.SetHashed<T>(key, field, value, tags, ttl, when);
        }

        //public static void SetHashed<TK, TV>(string key, TK field, TV value, string[] tags, TimeSpan? ttl = null, When when = When.Always);

        public static bool TryGetHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, out T result)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            return cache.TryGetHashed<T>(key, field, out result);
        }

        public static T GetHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            return cache.GetHashed<T>(key, field);
        }

        public static TV GetHashed<TK, TV>(this ICacheProvider cache, long key, TK field)
        {
            throw new NotImplementedException();
        }

        public static IDictionary<string, T> GetHashedAll<T>(this ICacheProvider cache)
        {
            var key = GetKey<T>();
            return cache.GetHashedAll<T>(key);
        }

        public static T FetchHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, Func<T> func, TimeSpan? expiry = null)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            return cache.FetchHashed(key, field, func, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cache, T value, Func<T, object> fieldBuilder, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, fieldBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            return cache.FetchHashed(key, field, func, tags, expiry);
        }        

        public static bool RemoveHashed<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            return cache.RemoveHashed(key, field);
        }

        public static void RemoveTagsFromHashField<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, Func<T, string[]> tagsBuilder)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            var tags = GetTags<T>(value, tagsBuilder);
            cache.RemoveTagsFromHashField(key, field, tags);
        }

        public static void RenameTagForHashField<T>(this ICacheProvider cache, T value, Func<T, object> hashFieldBuilder, string currentTag, string newTag)
        {
            var key = GetKey<T>();
            var field = GetHashField<T>(value, hashFieldBuilder);
            cache.RenameTagForHashField(key, field, currentTag, newTag);
        }

        #endregion
    }
}
