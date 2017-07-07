﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core
{
    public class CacheableRepository<T>
    {
        private static readonly object CacheLockObject = new object();
        private readonly IRepository<T> _modelRepository;

        private IList<T> ThreadSafeCacheAccessAction(Action<IList<T>> action = null)
        {
            // refresh cache if necessary
            //var list = HttpRuntime.Cache[CacheKey] as IList<T>;
            var list = new List<T>();
            if (list == null)
            {
                lock (CacheLockObject)
                {
                    //      list = HttpRuntime.Cache[CacheKey] as IList<T>;
                    if (list == null)
                    {
                        //list = _modelRepository.All.ToList();
                        //TODO: remove hardcoding
                        //        HttpRuntime.Cache.Insert(CacheKey, list, null, DateTime.UtcNow.AddMinutes(10), Cache.NoSlidingExpiration);
                    }
                }
            }

            // execute custom action, if one is required
            if (action != null)
            {
                lock (CacheLockObject)
                {
                    action(list);
                }
            }

            return list;
        }

        public IList<T> GetCachedItems()
        {
            IList<T> ret = ThreadSafeCacheAccessAction();
            return ret;
        }

        public void BulkInsert(IEnumerable<T> entities)
        {
            var enumerable = entities as IList<T> ?? entities.ToList();
            //_modelRepository.BulkInsert(enumerable);

            // also inserting items within the cache
            ThreadSafeCacheAccessAction((list) =>
            {
                foreach (var item in enumerable)
                    list.Add(item);
            });
        }

        public void Delete(T entity)
        {
            _modelRepository.Delete(entity);

            ThreadSafeCacheAccessAction((list) =>
            {
                list.Remove(entity);
            });
        }

        //public IQueryable<T> All => _modelRepository.All;

        public IQueryable<T> AllNoTracking
        {
            get
            {
                var cachedItems = GetCachedItems();
                return cachedItems.AsQueryable();
            }
        }
    }
}