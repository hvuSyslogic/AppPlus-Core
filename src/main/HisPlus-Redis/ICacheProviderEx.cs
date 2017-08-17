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

        public static void AddTagsToHashField<T>(this ICacheProvider cacheProvider, object key, string[] tags)
        {
            cacheProvider.AddTagsToHashField(GetHashedKey<T>(), GetHashedField<T>(key), tags);
        }

        public static void AddTagsToKey<T>(this ICacheProvider cacheProvider, object key, string[] tags)
        {
            cacheProvider.AddTagsToKey(GetObjectKey<T>(key), tags);
        }

        public static void AddTagsToSetMember<T>(this ICacheProvider cacheProvider, T member, string[] tags)
        {
            throw new NotImplementedException();
        }

        public static void AddToSet<T>(this ICacheProvider cacheProvider, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }

        public static void AddToSortedSet<T>(this ICacheProvider cacheProvider, double score, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            throw new NotImplementedException();
        }

        #region FetchHashed
        public static T FetchHashed<T>(this ICacheProvider cacheProvider, object key, Func<T> func, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashedKey<T>(), GetHashedField<T>(key), func, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, object key, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashedKey<T>(), GetHashedField<T>(key), func, tagsBuilder, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, object key, Func<T> func, string[] tags, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashedKey<T>(), GetHashedField<T>(key), func, tags, expiry);
        }
        #endregion

        #region FetchObject
        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(key), func, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(key), func, tagsBuilder, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, object key, Func<T> func, string[] tags, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(key), func, tags, expiry);
        }
        #endregion

        //void FlushAll();        

        //IEnumerable<string> GetAllTags();

        #region GetHashed
        public static T GetHashed<T>(this ICacheProvider cacheProvider, object key)
        {
            return cacheProvider.GetHashed<T>(GetHashedKey<T>(), GetHashedField<T>(key));
        }

        public static TV GetHashed<TK, TV>(this ICacheProvider cacheProvider, object key, TK field)
        {
            throw new NotImplementedException();
        }
        
        public static IDictionary<string, T> GetHashedAll<T>(this ICacheProvider cacheProvider)
        {
            return cacheProvider.GetHashedAll<T>(GetHashedKey<T>());
        }
        #endregion

        //IEnumerable<string> GetKeysByPattern(string pattern);

        //IEnumerable<string> GetKeysByTag(string[] tags, bool cleanUp = false);

        public static IEnumerable<string> GetKeysByTagA(this ICacheProvider cacheProvider, string[] tags, bool cleanUp = false)
        {
            var keys = new List<string>();
            var result = cacheProvider.GetKeysByTag(tags, cleanUp).ToList();
            result.ForEach(x => 
            {
                var key = x.Split(new string[] { ":" }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                keys.Add(key);
            });

            return keys;
        }

        public static T GetObjectA<T>(this ICacheProvider cacheProvider, object key)
        {
            return cacheProvider.GetObject<T>(GetObjectKey<T>(key));
        }

        //IEnumerable<T> GetObjectsByTag<T>(params string[] tags);

        public static T GetSetObject<T>(this ICacheProvider cacheProvider, object key, T value)
        {
            return cacheProvider.GetSetObject(GetObjectKey<T>(key), value);
        }

        //bool HyperLogLogAdd<T>(string key, T item);

        //bool HyperLogLogAdd<T>(string key, T[] items);

        //long HyperLogLogCount(string key);

        //void InvalidateKeysByTag(params string[] tags);

        public static bool KeyExists<T>(this ICacheProvider cacheProvider, object key)
        {
            return cacheProvider.KeyExists(GetObjectKey<T>(key));
        }

        public static bool KeyExpire<T>(this ICacheProvider cacheProvider, object key, DateTime expiration)
        {
            return cacheProvider.KeyExpire(GetObjectKey<T>(key), expiration);
        }

        public static bool KeyPersist<T>(this ICacheProvider cacheProvider, object key)
        {
            return cacheProvider.KeyPersist(GetObjectKey<T>(key));
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider cacheProvider)
        {
            return cacheProvider.KeyTimeToLive(GetHashedKey<T>());
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider cacheProvider, TimeSpan ttl)
        {
            return cacheProvider.KeyTimeToLive(GetHashedKey<T>(), ttl);
        }

        public static bool Remove<T>(this ICacheProvider cacheProvider, object key, CacheType cacheType = CacheType.Object)
        {
            return cacheProvider.Remove(GetKeyByCacheType<T>(key));
        }

        public static void Remove<T>(this ICacheProvider cacheProvider, object[] keys, CacheType cacheType = CacheType.Object)
        {
            var cacheKeys = new List<string>();
            keys.ToList().ForEach(x => 
            {
                cacheKeys.Add(GetKeyByCacheType<T>(x));
            });

            cacheProvider.Remove(cacheKeys.ToArray());
        }

        //bool RemoveFromSet<T>(string key, T value);

        //bool RemoveFromSortedSet<T>(string key, T value);
        
        public static bool RemoveHashed<T>(this ICacheProvider cacheProvider, object key)
        {
            return cacheProvider.RemoveHashed(GetHashedKey<T>(), GetHashedField<T>(key));
        }

        public static void RemoveTagsFromHashField<T>(this ICacheProvider cacheProvider, string field, string[] tags) 
        {
            cacheProvider.RemoveTagsFromHashField(GetHashedKey<T>(), field, tags);
        }

        private static string GetKeyByCacheType<T>(object key = null, CacheType cacheType = CacheType.Object)
        {
            var cacheKey = "";
            if (cacheType == CacheType.Hashed)
            {
                cacheKey = GetHashedKey<T>();
            }
            else
            {
                if (key == null)
                {
                    throw new ArgumentNullException("key");
                }
                cacheKey = GetObjectKey<T>(key);
            }

            return cacheKey;
        }

        public static void RemoveTagsFromKey<T>(this ICacheProvider cacheProvider, object key, string[] tags, CacheType cacheType = CacheType.Object) 
        {            
            cacheProvider.RemoveTagsFromKey(GetKeyByCacheType<T>(key, cacheType), tags);
        }

        //void RemoveTagsFromSetMember<T>(string key, T member, string[] tags) { throw new NotImplementedException(); }

        public static void RenameTagForHashField<T>(this ICacheProvider cacheProvider, string field, string currentTag, string newTag) 
        {
            cacheProvider.RenameTagForHashField(GetHashedKey<T>(), field, currentTag, newTag);
        }

        //void RenameTagForKey(string key, string currentTag, string newTag) { throw new NotImplementedException(); }

        //void RenameTagForSetMember<T>(string key, T member, string currentTag, string newTag) { throw new NotImplementedException(); }

        //IEnumerable<KeyValuePair<string, T>> ScanHashed<T>(string key, string pattern) { throw new NotImplementedException(); }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, IDictionary<string, T> fieldValues)
        {
            cacheProvider.SetHashed<T>(GetHashedKey<T>(), fieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, object key, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetHashed<T>(GetHashedKey<T>(), GetHashedField<T>(key), value, ttl, when);
        }

        //public static void SetHashed<TK, TV>(this ICacheProvider cacheProvider, string key, TK field, TV value, TimeSpan? ttl = null, When when = When.Always);

        public static void SetHashed<T>(this ICacheProvider cacheProvider, object key, T value, string[] tags, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetHashed<T>(GetHashedKey<T>(), GetHashedField<T>(key), value, tags, ttl, when);
        }

        //public static void SetHashed<TK, TV>(string key, TK field, TV value, string[] tags, TimeSpan? ttl = null, When when = When.Always) { }

        public static void SetObject<T>(this ICacheProvider cacheProvider, object key, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject<T>(GetObjectKey<T>(key), value, ttl, when);
        }
            
        public static void SetObject<T>(this ICacheProvider cacheProvider, object key, T value, string[] tags, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject<T>(GetObjectKey<T>(key), value, tags, ttl, when);
        }

        public static bool TryGetHashed<T>(this ICacheProvider cacheProvider, object key, out T value)
        {
            return cacheProvider.TryGetHashed<T>(GetHashedKey<T>(), GetHashedField<T>(key), out value);
        }

        public static bool TryGetObject<T>(this ICacheProvider cacheProvider, object key, out T value)
        {
            return cacheProvider.TryGetObject<T>(GetObjectKey<T>(key), out value);
        }
       
        #region private method(s)

        private static string GetTableName<T>()
        {
            return typeof(T).Name.Replace("DTO", "").Replace("Info", "");
        }

        private static string GetHashedKey<T>()
        {
            return string.Format(HashedKeyFormat, GetTableName<T>());
        }

        private static string GetHashedField<T>(object key)
        {
            return string.Format(HashedFieldFormat, GetTableName<T>(), key);
        }

        private static string GetObjectKey<T>(object id)
        {
            return string.Format(ObjectKeyFormat, GetTableName<T>(), id);
        }
        #endregion
    }
}
