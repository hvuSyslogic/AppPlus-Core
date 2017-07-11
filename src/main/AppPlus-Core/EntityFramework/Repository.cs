﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using log4net;
using Microsoft.Practices.Unity;
using Z.EntityFramework.Plus;
using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using AppPlus.Core.Redis;

namespace AppPlus.Core.EntityFramework
{
    internal partial class Repository<TEntity> : IRepository<TEntity>
        where TEntity : EntityRoot, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        
        #region Constructor(s)

        [InjectionConstructor]
        public Repository(IUnitOfWork unitOfWork)
        {
            this.Session = unitOfWork.Session;

            this.Session.Database.CommandTimeout = 3*60*1000;

            this.EFSet = this.Session.Set<TEntity>();
        }

        #endregion

        #region Properties

        [Dependency]
        public virtual ICacheProvider RedisRepository { get; set; }

        protected virtual DbSet<TEntity> EFSet { get; set; }

        protected virtual DbContext Session { get; set; }
        
        #endregion

        private ObjectContext ObjectContext()
        {
            return (Session as IObjectContextAdapter).ObjectContext;
        }        

        #region Create

        public virtual TEntity Create(TEntity entity)
        {            
            return this.EFSet.Add(entity);
        }

        public virtual IEnumerable<TEntity> Create(IEnumerable<TEntity> entities)
        {
            this.EFSet.AddRange(entities);

            return entities;
        }
        
        #endregion

        #region Retrieve

        public virtual TEntity Retrieve(params object[] keyValues)
        {
            return this.EFSet.Find(keyValues);
        }        

        public virtual IQueryable<TEntity> Retrieve(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, 
            IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        {
            IQueryable<TEntity> queryable = this.EFSet;
            if (predicate != null)
            {
                queryable = queryable.Where(predicate);
            }

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                queryable = queryable.Include(includeProperty);
            }

            if (orderBy != null)
            {
                queryable = orderBy(queryable);
            }

            return queryable;
        }

        //public virtual IQueryable<TEntity> Retrieve(string sql, params object[] parameters)
        //{
        //    return this.EFSet.SqlQuery(sql, parameters).AsNoTracking().AsQueryable();
        //}

        #endregion

        #region Update

        public virtual void Update(TEntity entity)
        {
            if (this.Session.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }
            else
            {
                this.Session.Entry<TEntity>(entity).CurrentValues.SetValues(entity);
            }

            this.Session.Entry<TEntity>(entity).State = EntityState.Modified;
        }        

        public virtual void Update(IEnumerable<TEntity> entities)
        {            
            entities.ToList().ForEach(entity => 
            {
                this.Update(entity);
            });
        }

        public virtual int Update(Expression<Func<TEntity, TEntity>> updateExpression, Expression<Func<TEntity, bool>> predicate = null)
        {
            return (predicate == null) ? this.EFSet.Update(updateExpression) : this.EFSet.Where(predicate).Update(updateExpression);            
        }

        #endregion

        #region Delete

        public virtual void Delete(object id)
        {            
            this.EFSet.Remove(this.Retrieve(id));
        }

        public virtual void Delete(TEntity entity)
        {
            if (this.Session.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }

            this.EFSet.Remove(entity);
        }

        public virtual IEnumerable<TEntity> Delete(IEnumerable<TEntity> entities)
        {
            return this.EFSet.RemoveRange(entities);
        }

        public virtual int Delete(Expression<Func<TEntity, bool>> predicate = null)
        {
            return (predicate == null) ? this.EFSet.Delete() : this.EFSet.Where(predicate).Delete();
        }

        #endregion        

        #region Count
        
        public virtual int Count(Expression<Func<TEntity, bool>> predicate)
        {         
            return (predicate == null) ? this.EFSet.Count() : this.EFSet.Where(predicate).Count();
        }

        #endregion

        #region LongCount
        
        public virtual long LongCount(Expression<Func<TEntity, bool>> predicate = null)
        {
            return (predicate == null) ? this.EFSet.LongCount() : this.EFSet.Where(predicate).LongCount();
        }

        #endregion

        #region Contains

        public virtual bool Contains(Expression<Func<TEntity, bool>> predicate)
        {
            return Count(predicate) > 0;
        }
        
        #endregion

        #region Filter

        public virtual IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, 
            IOrderedQueryable<TEntity>> orderBy, out int totalPages, int pageNumber = 0, int pageSize = 50)
        {
            int skipCount = (pageNumber - 1) * pageSize;

            IQueryable<TEntity> queryable = (predicate == null) ? this.EFSet : this.EFSet.Where(predicate);

            totalPages = (int)Math.Ceiling((decimal)queryable.Count() / pageSize);

            queryable = queryable.AsNoTracking();
            if (orderBy == null)
            {
                queryable = queryable.OrderBy("Id");
            }
            else
            {
                queryable = orderBy(queryable);
            }
            
            queryable = (skipCount == 0) ? queryable.Take(pageSize) : queryable.Skip(skipCount).Take(pageSize);
            
            return queryable;        
        }

        #endregion

        public IQueryable<TEntity> Queryable { get { return EFSet.AsQueryable<TEntity>(); } }
    }
}