using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using HisPlus.Infrastructure.Contract.Messages;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;

namespace HisPlus.Core.Abstractions
{
    public partial interface IRepository<TEntity> where TEntity :  EntityRoot, new()
    {
        #region Properties

        IQueryable<TEntity> Queryable { get; }

        #endregion

        #region Add

        TEntity Add(TEntity entity);

        IEnumerable<TEntity> Add(IEnumerable<TEntity> entities);
        
        #endregion

        #region Get

        TEntity Get(params object[] keyValues);

        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        #endregion

        #region Update

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        int Update(Expression<Func<TEntity, TEntity>> updateExpression, Expression<Func<TEntity, bool>> predicate = null);
        
        #endregion

        #region Delete
        
        void Delete(TEntity entity);

        void Delete(object id);

        IEnumerable<TEntity> Delete(IEnumerable<TEntity> entities);

        int Delete(Expression<Func<TEntity, bool>> predicate = null);

        #endregion

        #region Count

        int Count(Expression<Func<TEntity, bool>> predicate = null);

        #endregion

        #region LongCount

        long LongCount(Expression<Func<TEntity, bool>> predicate = null);

        #endregion

        #region Contains

        bool Contains(Expression<Func<TEntity, bool>> predicate = null);
        
        #endregion

        #region RetrievePagedData

        IQueryable<TEntity> GetPagedData(Expression<Func<TEntity, bool>> predicate, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, int pageNumber, int pageSize, out int pageCount);

        #endregion
    }
}
