using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Z.EntityFramework.Plus;
using HisPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Core.Abstractions.Support
{
    internal partial class Repository<TEntity> : IRepository<TEntity>
        where TEntity : EntityRoot, new()
    {
        #region Private Field(s)
        private const string DefaultPrimaryKeyColumn = "Id";
        private readonly IUnitOfWork _unitOfWork;
        #endregion

        #region Constructor(s)
        public Repository(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;            
        }
        #endregion        

        #region Propertie(s)
        public IQueryable<TEntity> Queryable
        {
            get { return EFSet.AsQueryable<TEntity>(); }
        }

        private ObjectContext ObjectContext()
        {
            return (Session as IObjectContextAdapter).ObjectContext;
        }

        protected DbSet<TEntity> EFSet 
        {
            get { return this.Session.Set<TEntity>(); } 
        }

        protected DbContext Session 
        {
            get 
            {
                _unitOfWork.Session.Database.CommandTimeout = 3 * 60 * 1000;
                return _unitOfWork.Session;
            } 
        }        
        #endregion

        #region Add
        public virtual TEntity Add(TEntity entity)
        {            
            return this.EFSet.Add(entity);
        }

        public virtual IEnumerable<TEntity> Add(IEnumerable<TEntity> entities)
        {
            this.EFSet.AddRange(entities);
            
            return entities;
        }        
        #endregion

        #region Get
        public virtual TEntity Get(params object[] keyValues)
        {
            return this.EFSet.Find(keyValues);
        }        

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, 
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
            if (predicate == null)
            {
                return this.EFSet.Update(updateExpression);
            }
            
            return this.EFSet.Where(predicate).Update(updateExpression);
        }
        #endregion

        #region Delete
        public virtual void Delete(object id)
        {
            var entity = Get(id);
            
            this.EFSet.Remove(entity);
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
            if (predicate == null)
            {
                return this.EFSet.Delete();
            }

            return this.EFSet.Where(predicate).Delete();
        }
        #endregion

        #region Count
        public virtual int Count(Expression<Func<TEntity, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return this.EFSet.Count();
            }

            return this.EFSet.Where(predicate).Count();
        }
        #endregion

        #region LongCount
        public virtual long LongCount(Expression<Func<TEntity, bool>> predicate = null)
        {            
            if (predicate == null)
            {
                return this.EFSet.LongCount();
            }

            return this.EFSet.Where(predicate).LongCount();
        }
        #endregion

        #region Contains
        public virtual bool Contains(Expression<Func<TEntity, bool>> predicate = null)
        {
            long count = LongCount(predicate);

            return count > 0;
        }        
        #endregion

        #region GetByPage
        public virtual IQueryable<TEntity> GetByPage(Expression<Func<TEntity, bool>> predicate, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, int pageNumber, int pageSize, out int pageCount)
        {
            int skippedCount = (pageNumber - 1) * pageSize;

            IQueryable<TEntity> queryable = (predicate == null) ? this.EFSet : this.EFSet.Where(predicate);

            pageCount = (int)Math.Ceiling((decimal)queryable.Count() / pageSize);

            queryable = queryable.AsNoTracking();
            if (orderBy == null)
            {
                queryable = queryable.OrderBy(DefaultPrimaryKeyColumn);
            }
            else
            {
                queryable = orderBy(queryable);
            }

            queryable = (skippedCount == 0) ? queryable.Take(pageSize) : queryable.Skip(skippedCount).Take(pageSize);
            
            return queryable;        
        }
        #endregion
    }
}