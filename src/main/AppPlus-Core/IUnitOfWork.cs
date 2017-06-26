using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppPlus.Infrastructure.Contract.Messages;

namespace AppPlus.Core
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        DbContext EFContext { get; set; }
    
        //bool IsConnectionOpen { get; }

        #endregion

        //#region Create 
        //TEntity Create<TEntity>(TEntity entity)
        //    where TEntity : EntityRoot, new();

        //IEnumerable<TEntity> Create<TEntity>(IEnumerable<TEntity> entities)
        //    where TEntity : EntityRoot, new();
        //#endregion

        //#region Retrieve
        //TEntity Retrieve<TEntity>(params object[] keyValue)
        //    where TEntity : EntityRoot, new();        

        //IQueryable<TEntity> Retrieve<TEntity>(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, 
        //    IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
        //    where TEntity : EntityRoot, new();

        ////IQueryable<TEntity> Retrieve<TEntity>(string sql, params object[] parameters)
        ////    where TEntity : EntityRoot, new();
        //#endregion

        //#region Update

        //void Update<TEntity>(TEntity entity)
        //    where TEntity : EntityRoot, new();

        //void Update<TEntity>(IEnumerable<TEntity> entities)
        //    where TEntity : EntityRoot, new();

        //int Update<TEntity>(Expression<Func<TEntity, TEntity>> updateExpression,
        //    Expression<Func<TEntity, bool>> predicate = null)
        //    where TEntity : EntityRoot, new();                
        //#endregion

        //#region Delete
        //void Delete<TEntity>(params object[] keyValues) where TEntity : EntityRoot, new();

        //void Delete<TEntity>(TEntity entity) 
        //    where TEntity : EntityRoot, new();

        //void Delete<TEntity>(IEnumerable<TEntity> entities)
        //    where TEntity : EntityRoot, new();

        //int Delete<TEntity>(Expression<Func<TEntity, bool>> predicate = null) 
        //    where TEntity : EntityRoot, new();
        //#endregion

        //#region Count

        //int Count<TEntity>(Expression<Func<TEntity, bool>> predicate = null) 
        //    where TEntity : EntityRoot, new();
        //#endregion

        //#region Contains

        //bool Contains<TEntity>(Expression<Func<TEntity, bool>> predicate) 
        //    where TEntity : EntityRoot, new();

        //#endregion

        //#region Filter

        //Tuple<IQueryable<TEntity>, int> Filter<TEntity>(Expression<Func<TEntity, bool>> predicate, int index = 0, int size = 50) 
        //    where TEntity : EntityRoot, new();

        //#endregion

        //void Query(Action query);

        void SaveChanges(bool withDisposing = false);

        //#region Join
        //IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
        //    where TEntityInner : EntityRoot, new()
        //    where TEntityOuter : EntityRoot, new();

        //IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
        //    where TEntityInner : EntityRoot, new()
        //    where TEntityOuter : EntityRoot, new();

        //IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
        //    where TEntityInner : EntityRoot, new()
        //    where TEntityOuter : EntityRoot, new();

        //IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
        //    where TEntityInner : EntityRoot, new()
        //    where TEntityOuter : EntityRoot, new();

        //#endregion

        //#region ExecuteDataSet

        //DataSet ExecuteDataSet(string commandText, DbParameter[] parameters, CommandType commandType);

        //DataTable ExecuteDataTable(string commandText, DbParameter[] parameters, CommandType commandType);

        //#endregion

        IRepository<TEntity> Repo<TEntity>() where TEntity : EntityRoot, new();
    }    
}
