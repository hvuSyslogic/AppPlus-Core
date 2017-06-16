using System;
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
using AppPlus.Infrastructure.Contracts.Messages;

namespace AppPlus.Core.EntityFramework
{
    internal partial class Repository<TEntity> : IGenericRepository<TEntity>
        where TEntity : EntityRoot, new()
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        #region Constructor(s)

        [InjectionConstructor]
        public Repository(IUnitOfWork unitOfWork)
        {
            this.EFContext = unitOfWork.EFContext;

            this.EFContext.Database.CommandTimeout = 3*60*1000;

            this.EFSet = this.EFContext.Set<TEntity>();
        }

        #endregion

        #region Properties

        protected virtual DbSet<TEntity> EFSet { get; set; }

        protected virtual DbContext EFContext { get; set; }
        
        #endregion

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
            if (this.EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }
            else
            {
                this.EFContext.Entry<TEntity>(entity).CurrentValues.SetValues(entity);
            }

            this.EFContext.Entry<TEntity>(entity).State = EntityState.Modified;
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
        public virtual TEntity Delete(params object[] keyValues)
        {
            return this.EFSet.Remove(this.Retrieve(keyValues));
        }

        public virtual TEntity Delete(TEntity entity)
        {
            if (this.EFContext.Entry<TEntity>(entity).State == EntityState.Detached)
            {
                this.EFSet.Attach(entity);
            }

            return this.EFSet.Remove(entity);
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

        #region Contains
        public virtual bool Contains(Expression<Func<TEntity, bool>> predicate)
        {
            return Count(predicate) > 0;
        }
        #endregion

        #region Filter
        public virtual IQueryable<TEntity> Filter(
            Expression<Func<TEntity, bool>> predicate,
            out int total,
            int index = 0,
            int size = 50)
        {
            int skipCount = index * size;

            IQueryable<TEntity> query = (predicate == null) ? this.EFSet : this.EFSet.Where(predicate);

            query = query.AsNoTracking();

            query = (skipCount == 0) ? query.Take(size) : query.Skip(skipCount).Take(size);

            total = query.Count();

            return query;
        }
        #endregion
    }
}