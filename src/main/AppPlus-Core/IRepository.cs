using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppPlus.Infrastructure.Contract.Messages;

namespace AppPlus.Core
{
    public partial interface IRepository<TEntity> where TEntity :  EntityRoot, new()
    {
        #region Create
        TEntity Create(TEntity entity);

        IEnumerable<TEntity> Create(IEnumerable<TEntity> entities);
        #endregion

        #region Retrieve
        TEntity Retrieve(params object[] keyValues);        

        IQueryable<TEntity> Retrieve(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, 
            IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");

        //IQueryable<TEntity> Retrieve(string sql, params object[] parameters);
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

        #region Filter
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, out int total, int pageNumber = 0, int pageSize = 50);
        #endregion
    }
}
