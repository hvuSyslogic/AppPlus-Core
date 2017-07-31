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

        #region Create

        TEntity Create(TEntity entity);

        IEnumerable<TEntity> Create(IEnumerable<TEntity> entities);
        
        #endregion

        #region Retrieve

        TEntity Retrieve(params object[] keyValues);

        IQueryable<TEntity> Retrieve(Expression<Func<TEntity, bool>> predicate = null, 
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

        IQueryable<TEntity> RetrievePagedData(Expression<Func<TEntity, bool>> predicate, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy, int pageNumber, int pageSize, out int pageCount);

        #endregion
    }
}
