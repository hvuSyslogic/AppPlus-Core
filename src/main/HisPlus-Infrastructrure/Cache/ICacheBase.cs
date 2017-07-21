using System;
namespace HisPlus.Infrastructure.Cache
{
    public interface ICacheBase
    {
        StackExchange.Redis.ITransaction CreateTransaction();
        StackExchange.Redis.IDatabase CurrentDB { get; }
        StackExchange.Redis.IDatabase GetDatabase();
        double HashDecrement(string key, string dataKey, double val = 1);
        System.Threading.Tasks.Task<double> HashDecrementAsync(string key, string dataKey, double val = 1);
        long HashDelete(string key, System.Collections.Generic.List<StackExchange.Redis.RedisValue> dataKeys);
        bool HashDelete(string key, string dataKey);
        System.Threading.Tasks.Task<long> HashDeleteAsync(string key, System.Collections.Generic.List<StackExchange.Redis.RedisValue> dataKeys);
        System.Threading.Tasks.Task<bool> HashDeleteAsync(string key, string dataKey);
        bool HashExists(string key, string dataKey);
        System.Threading.Tasks.Task<bool> HashExistsAsync(string key, string dataKey);
        System.Threading.Tasks.Task<T> HashGeAsync<T>(string key, string dataKey);
        T HashGet<T>(string key, string dataKey);
        double HashIncrement(string key, string dataKey, double val = 1);
        System.Threading.Tasks.Task<double> HashIncrementAsync(string key, string dataKey, double val = 1);
        System.Collections.Generic.List<T> HashKeys<T>(string key);
        System.Threading.Tasks.Task<System.Collections.Generic.List<T>> HashKeysAsync<T>(string key);
        bool HashSet<T>(string key, string dataKey, T t);
        System.Threading.Tasks.Task<bool> HashSetAsync<T>(string key, string dataKey, T t);
        long KeyDelete(System.Collections.Generic.List<string> keys);
        bool KeyDelete(string key);
        bool KeyExists(string key);
        bool KeyExpire(string key, TimeSpan? expiry = default(TimeSpan?));
        bool KeyRename(string key, string newKey);
        T ListLeftPop<T>(string key);
        System.Threading.Tasks.Task<T> ListLeftPopAsync<T>(string key);
        void ListLeftPush<T>(string key, T value);
        System.Threading.Tasks.Task<long> ListLeftPushAsync<T>(string key, T value);
        long ListLength(string key);
        System.Threading.Tasks.Task<long> ListLengthAsync(string key);
        System.Collections.Generic.List<T> ListRange<T>(string key);
        System.Threading.Tasks.Task<System.Collections.Generic.List<T>> ListRangeAsync<T>(string key);
        void ListRemove<T>(string key, T value);
        System.Threading.Tasks.Task<long> ListRemoveAsync<T>(string key, T value);
        T ListRightPop<T>(string key);
        System.Threading.Tasks.Task<T> ListRightPopAsync<T>(string key);
        void ListRightPush<T>(string key, T value);
        System.Threading.Tasks.Task<long> ListRightPushAsync<T>(string key, T value);
        bool SortedSetAdd<T>(string key, T value, double score);
        System.Threading.Tasks.Task<bool> SortedSetAddAsync<T>(string key, T value, double score);
        long SortedSetLength(string key);
        System.Threading.Tasks.Task<long> SortedSetLengthAsync(string key);
        System.Collections.Generic.List<T> SortedSetRangeByRank<T>(string key);
        System.Threading.Tasks.Task<System.Collections.Generic.List<T>> SortedSetRangeByRankAsync<T>(string key);
        bool SortedSetRemove<T>(string key, T value);
        System.Threading.Tasks.Task<bool> SortedSetRemoveAsync<T>(string key, T value);
        double StringDecrement(string key, double val = 1);
        System.Threading.Tasks.Task<double> StringDecrementAsync(string key, double val = 1);
        StackExchange.Redis.RedisValue[] StringGet(System.Collections.Generic.List<string> listKey);
        string StringGet(string key);
        T StringGet<T>(string key);
        System.Threading.Tasks.Task<StackExchange.Redis.RedisValue[]> StringGetAsync(System.Collections.Generic.List<string> listKey);
        System.Threading.Tasks.Task<string> StringGetAsync(string key);
        System.Threading.Tasks.Task<T> StringGetAsync<T>(string key);
        double StringIncrement(string key, double val = 1);
        System.Threading.Tasks.Task<double> StringIncrementAsync(string key, double val = 1);
        bool StringSet(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<StackExchange.Redis.RedisKey, StackExchange.Redis.RedisValue>> keyValues);
        bool StringSet(string key, string value, TimeSpan? expiry = default(TimeSpan?));
        bool StringSet<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?));
        System.Threading.Tasks.Task<bool> StringSetAsync(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<StackExchange.Redis.RedisKey, StackExchange.Redis.RedisValue>> keyValues);
        System.Threading.Tasks.Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = default(TimeSpan?));
        System.Threading.Tasks.Task<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?));
    }
}
