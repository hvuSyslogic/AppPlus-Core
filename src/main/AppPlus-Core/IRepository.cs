using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppPlus.Infrastructure.Contracts.Messages;

namespace AppPlus.Core
{
    public partial interface IRepository<TEntity>
        where TEntity : EntityRoot, new()
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
        TEntity Delete(params object[] keyValues);

        TEntity Delete(TEntity entity);        

        IEnumerable<TEntity> Delete(IEnumerable<TEntity> entities);

        int Delete(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Count
        int Count(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Contains
        bool Contains(Expression<Func<TEntity, bool>> predicate);
        #endregion

        #region Filter
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate, out int total, int index = 0, int size = 50);
        #endregion
    }
}
