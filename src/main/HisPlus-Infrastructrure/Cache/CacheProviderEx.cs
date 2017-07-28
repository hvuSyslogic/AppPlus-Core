using CachingFramework.Redis.Contracts;
using CachingFramework.Redis.Contracts.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public static class CacheProviderEx
    {
        private const string HashKeyFormat = "{0}s:hash";
        private const string ObjectKeyFormat = "{0}:{1}";
        private const string FieldFormat = "{0}:id:{1}";

        private static string GetHashKey<T>()
        {
            return string.Format(HashKeyFormat, typeof(T).Name);
        }

        private static string GetField<T>(int id)
        {
            return string.Format(FieldFormat, typeof(T).Name, id);
        }

        private static string GetObjectKey<T>(int id)
        {
            return string.Format(ObjectKeyFormat, typeof(T).Name, id);
        }

        public static void AddTagsToHashField<T>(this ICacheProvider cacheProvider, int id, string[] tags)
        {
            cacheProvider.AddTagsToHashField(GetHashKey<T>(), GetField<T>(id), tags);
        }

        public static void AddTagsToKey<T>(this ICacheProvider cacheProvider, string[] tags)
        {
            cacheProvider.AddTagsToKey(GetHashKey<T>(), tags);
        }

        public static void AddTagsToSetMember<T>(this ICacheProvider cacheProvider, T member, string[] tags)
        {
            cacheProvider.AddTagsToSetMember(GetHashKey<T>(), member, tags);
        }

        public static void AddToSet<T>(this ICacheProvider cacheProvider, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            cacheProvider.AddToSet(GetHashKey<T>(), value, tags, ttl);
        }

        public static void AddToSortedSet<T>(this ICacheProvider cacheProvider,  double score, T value, string[] tags = null, TimeSpan? ttl = null)
        {
            cacheProvider.AddToSortedSet(GetHashKey<T>(), score, value, tags, ttl);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, int id, Func<T> func, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashKey<T>(), GetField<T>(id), func, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, int id, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashKey<T>(), GetField<T>(id), func, tagsBuilder, expiry);
        }

        public static T FetchHashed<T>(this ICacheProvider cacheProvider, int id, Func<T> func, string[] tags, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchHashed(GetHashKey<T>(), GetField<T>(id), func, tags, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, int id, Func<T> func, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(id), func, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, int id, Func<T> func, Func<T, string[]> tagsBuilder, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(id), func, tagsBuilder, expiry);
        }

        public static T FetchObject<T>(this ICacheProvider cacheProvider, int id, Func<T> func, string[] tags, TimeSpan? expiry = null)
        {
            return cacheProvider.FetchObject(GetObjectKey<T>(id), func, tags, expiry);
        }

        public static T GetHashed<T>(this ICacheProvider cacheProvider, int id)
        {
            return cacheProvider.GetHashed<T>(GetHashKey<T>(), GetField<T>(id));
        }

        //TV GetHashed<TK, TV>(this ICacheProvider cacheProvider, string key, TK field);
        
        public static IDictionary<string, T> GetHashedAll<T>(this ICacheProvider cacheProvider)
        {
            return cacheProvider.GetHashedAll<T>(GetHashKey<T>());
        }

        public static T GetObject<T>(this ICacheProvider cacheProvider, int id)
        {
            return cacheProvider.GetObject<T>(GetObjectKey<T>(id));
        }

        public static T GetSetObject<T>(this ICacheProvider cacheProvider, int id, T value)
        {
            return cacheProvider.GetSetObject(GetObjectKey<T>(id), value);
        }

        public static bool KeyExists<T>(this ICacheProvider cacheProvider, int id)
        {
            return cacheProvider.KeyExists(GetObjectKey<T>(id));
        }

        public static bool KeyExpire<T>(this ICacheProvider cacheProvider, int id, DateTime expiration)
        {
            return cacheProvider.KeyExpire(GetObjectKey<T>(id), expiration);
        }

        public static bool KeyPersist<T>(this ICacheProvider cacheProvider, int id)
        {
            return cacheProvider.KeyPersist(GetObjectKey<T>(id));
        }

        public static TimeSpan? KeyTimeToLive<T>(this ICacheProvider cacheProvider)
        {
            return cacheProvider.KeyTimeToLive(GetHashKey<T>());
        }

        public static bool KeyTimeToLive<T>(this ICacheProvider cacheProvider, TimeSpan ttl)
        {
            return cacheProvider.KeyTimeToLive(GetHashKey<T>(), ttl);
        }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, IDictionary<string, T> fieldValues)
        {
            cacheProvider.SetHashed(GetHashKey<T>(), fieldValues);
        }

        public static void SetHashed<T>(this ICacheProvider cacheProvider, int id, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetHashed(GetHashKey<T>(), GetField<T>(id), value, ttl, when);
        }

        //public static void SetHashed<TK, TV>(this ICacheProvider cacheProvider, string key, TK field, TV value, TimeSpan? ttl = null, When when = When.Always);

        public static void SetHashed<T>(this ICacheProvider cacheProvider, int id, T value, string[] tags, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetHashed(GetHashKey<T>(), GetField<T>(id), value, tags, ttl, when);
        }

        //public static void SetHashed<TK, TV>(string key, TK field, TV value, string[] tags, TimeSpan? ttl = null, When when = When.Always) { }

        public static void SetObject<T>(this ICacheProvider cacheProvider, T value, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject(GetHashKey<T>(), value, ttl, when);
        }

        public static void SetObject<T>(this ICacheProvider cacheProvider, T value, string[] tags, TimeSpan? ttl = null, When when = When.Always)
        {
            cacheProvider.SetObject(GetHashKey<T>(), value, tags, ttl, when);
        }        

        public static bool TryGetHashed<T>(this ICacheProvider cacheProvider, int id, out T value)
        {
            return cacheProvider.TryGetHashed(GetHashKey<T>(), GetField<T>(id), out value);
        }

        public static bool TryGetObject<T>(this ICacheProvider cacheProvider, int id, out T value)
        {
            return cacheProvider.TryGetObject(GetObjectKey<T>(id), out value);
        }

        public static bool RemoveHashed<T>(this ICacheProvider cacheProvider, int id)
        {
            return cacheProvider.RemoveHashed(GetHashKey<T>(), GetField<T>(id));
        }
    }
}
