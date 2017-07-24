using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HisPlus.Infrastructure.Cache
{
    public interface ICacheProviderBase
    {
        ITransaction CreateTransaction();
        
        IDatabase CurrentDB { get; }

        IDatabase GetDatabase();

        double HashDecrement(string key, string dataKey, double val = 1);
        
        Task<double> HashDecrementAsync(string key, string dataKey, double val = 1);
        
        long HashDelete(string key, List<RedisValue> dataKeys);

        bool HashDelete(string key, string dataKey);
        
        Task<long> HashDeleteAsync(string key, List<RedisValue> dataKeys);
        
        Task<bool> HashDeleteAsync(string key, string dataKey);
        
        bool HashExists(string key, string dataKey);
        
        Task<bool> HashExistsAsync(string key, string dataKey);
        
        Task<T> HashGeAsync<T>(string key, string dataKey);
        
        T HashGet<T>(string key, string dataKey);
        
        double HashIncrement(string key, string dataKey, double val = 1);
        
        Task<double> HashIncrementAsync(string key, string dataKey, double val = 1);
        
        List<T> HashKeys<T>(string key);
        
        Task<List<T>> HashKeysAsync<T>(string key);
        
        bool HashSet<T>(string key, string dataKey, T t);
        
        Task<bool> HashSetAsync<T>(string key, string dataKey, T t);
        
        long KeyDelete(List<string> keys);
        
        bool KeyDelete(string key);
        
        bool KeyExists(string key);
        
        bool KeyExpire(string key, TimeSpan? expiry = default(TimeSpan?));
        
        bool KeyRename(string key, string newKey);
        
        T ListLeftPop<T>(string key);
        
        Task<T> ListLeftPopAsync<T>(string key);
        
        void ListLeftPush<T>(string key, T value);
        
        Task<long> ListLeftPushAsync<T>(string key, T value);
        
        long ListLength(string key);
        
        Task<long> ListLengthAsync(string key);
        
        List<T> ListRange<T>(string key);
        
        Task<List<T>> ListRangeAsync<T>(string key);
        
        void ListRemove<T>(string key, T value);
        
        Task<long> ListRemoveAsync<T>(string key, T value);
        
        T ListRightPop<T>(string key);
        
        Task<T> ListRightPopAsync<T>(string key);
        
        void ListRightPush<T>(string key, T value);
        
        Task<long> ListRightPushAsync<T>(string key, T value);
        
        bool SortedSetAdd<T>(string key, T value, double score);
        
        Task<bool> SortedSetAddAsync<T>(string key, T value, double score);
        
        long SortedSetLength(string key);
        
        Task<long> SortedSetLengthAsync(string key);
        
        List<T> SortedSetRangeByRank<T>(string key);
        
        Task<List<T>> SortedSetRangeByRankAsync<T>(string key);
        
        bool SortedSetRemove<T>(string key, T value);
        
        Task<bool> SortedSetRemoveAsync<T>(string key, T value);
        
        double StringDecrement(string key, double val = 1);
        
        Task<double> StringDecrementAsync(string key, double val = 1);
        
        RedisValue[] StringGet(List<string> listKey);
        
        string StringGet(string key);
        
        T StringGet<T>(string key);
        
        Task<RedisValue[]> StringGetAsync(List<string> listKey);
        
        Task<string> StringGetAsync(string key);
        
        Task<T> StringGetAsync<T>(string key);
        
        double StringIncrement(string key, double val = 1);
        
        Task<double> StringIncrementAsync(string key, double val = 1);
        
        bool StringSet(List<KeyValuePair<RedisKey, RedisValue>> keyValues);
        
        bool StringSet(string key, string value, TimeSpan? expiry = default(TimeSpan?));
        
        bool StringSet<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?));
        
        Task<bool> StringSetAsync(List<KeyValuePair<RedisKey, RedisValue>> keyValues);
        
        Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = default(TimeSpan?));

        Task<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?));
    }
}
