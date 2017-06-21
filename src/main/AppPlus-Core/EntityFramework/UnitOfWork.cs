﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using Z.EntityFramework.Plus;
using AppPlus.Infrastructure.Contract.Messages;
using AppPlus.Infrastructure.Configuration;

namespace AppPlus.Core.EntityFramework
{
    public class UnitOfWork<TDbContext> : IUnitOfWork 
        where TDbContext : DbContext
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool disposed;
        private IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        #region Construct(s)
        
        public UnitOfWork(DbContext context)
        {
            EFContext = context;
        }

        #endregion

        #region Properties

        public virtual DbContext EFContext { get; set; }

        public bool IsConnectionOpen 
        {
            get { return EFContext != null; } 
        }

        private IRepository<TEntity> Repo<TEntity>()
           where TEntity : EntityRoot, new()
        {            
            if (!repositories.ContainsKey(typeof(TEntity)))
            {
                var repository = AppConfigurator.Container.Resolve<Repository<TEntity>>(new ParameterOverrides { { "unitOfWork", this } });

                repositories.Add(new KeyValuePair<Type, object>(typeof(TEntity), repository));                
            }

            return (IRepository<TEntity>)repositories[typeof(TEntity)];
        }

        #endregion

        #region Create
        public virtual TEntity Create<TEntity>(TEntity entity)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Create(entity);
        }

        public virtual IEnumerable<TEntity> Create<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Create(entities);
        }
        #endregion

        #region Retrieve
        public virtual TEntity Retrieve<TEntity>(params object[] keyValues)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Retrieve(keyValues);
        }

        public virtual IQueryable<TEntity> Retrieve<TEntity>(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, 
            IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Retrieve(predicate, orderBy, includeProperties);
        }

        //public IQueryable<TEntity> Retrieve<TEntity>(string sql, params object[] parameters)
        //    where TEntity : EntityRoot, new()
        //{
        //    return UowRepository<TEntity>().Retrieve(sql, parameters);
        //}
        #endregion

        #region Update
        public virtual void Update<TEntity>(TEntity entity)
            where TEntity : EntityRoot, new()
        {
            Repo<TEntity>().Update(entity);
        }

        public virtual void Update<TEntity>(IEnumerable<TEntity> entities)
           where TEntity : EntityRoot, new()
        {
            Repo<TEntity>().Update(entities);
        }

        public virtual int Update<TEntity>(Expression<Func<TEntity, TEntity>> updateExpression, Expression<Func<TEntity, bool>> predicate = null)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Update(updateExpression, predicate);
        }
        #endregion

        #region Delete
        public virtual void Delete<TEntity>(params object[] keyValues)
            where TEntity : EntityRoot, new()
        {
            Repo<TEntity>().Delete(keyValues);
        }

        public virtual void Delete<TEntity>(TEntity entity)
            where TEntity : EntityRoot, new()
        {
            Repo<TEntity>().Delete(entity);
        }

        public virtual void Delete<TEntity>(IEnumerable<TEntity> entities)
            where TEntity : EntityRoot, new()
        {
            Repo<TEntity>().Delete(entities);
        }

        public virtual int Delete<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Delete(predicate);
        }
        #endregion     

        #region Join Supports

        public virtual IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
            where TEntityOuter : EntityRoot, new()
            where TEntityInner : EntityRoot, new()
        {
            return Repo<TEntityOuter>().Retrieve().Join(Repo<TEntityInner>().Retrieve(), outerKeySelector, innerKeySelector, resultSelector).AsQueryable();
        }

        public virtual IQueryable<TResult> Join<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
            where TEntityOuter : EntityRoot, new()
            where TEntityInner : EntityRoot, new()
        {
            return Repo<TEntityOuter>().Retrieve().Join(Repo<TEntityInner>().Retrieve(), outerKeySelector, innerKeySelector, resultSelector, comparer).AsQueryable();
        }

        public virtual IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector)
            where TEntityOuter : EntityRoot, new()
            where TEntityInner : EntityRoot, new()
        {
            return Repo<TEntityOuter>().Retrieve().GroupJoin(Repo<TEntityInner>().Retrieve(), outerKeySelector, innerKeySelector, (p, q) => resultSelector(p, q.FirstOrDefault())).AsQueryable();
        }

        public virtual IQueryable<TResult> LeftJoin<TEntityOuter, TEntityInner, TResult>(Func<TEntityOuter, object> outerKeySelector, Func<TEntityInner, object> innerKeySelector, Func<TEntityOuter, TEntityInner, TResult> resultSelector, IEqualityComparer<object> comparer)
            where TEntityOuter : EntityRoot, new()
            where TEntityInner : EntityRoot, new()
        {
            return Repo<TEntityOuter>().Retrieve().GroupJoin(Repo<TEntityInner>().Retrieve(), outerKeySelector, innerKeySelector, (p, q) => resultSelector(p, q.FirstOrDefault()), comparer).AsQueryable();
        }

        #endregion                

        //#region Execute DataTable(DataSet)

        //public virtual DataTable ExecuteDataTable(string commandText, DbParameter[] parameters, CommandType commandType)
        //{
        //    return this.ExecuteDataSet(commandText, parameters, commandType).Tables[0];
        //}

        //public virtual DataSet ExecuteDataSet(string commandText, DbParameter[] parameters, CommandType commandType)
        //{
        //    using (var command = this.EFContext.Database.Connection.CreateCommand())
        //    {
        //        command.CommandText = commandText;
        //        command.CommandType = commandType;
        //        command.CommandTimeout = 60 * 5;

        //        if (parameters != null)
        //        {
        //            foreach (SqlParameter parameter in parameters)
        //            {
        //                if (parameter != null)
        //                {
        //                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
        //                        (parameter.Value == null))
        //                    {
        //                        parameter.Value = DBNull.Value;
        //                    }
        //                    command.Parameters.Add(parameter);
        //                }
        //            }
        //        }

        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        //        sqlDataAdapter.SelectCommand = (SqlCommand)command;
        //        DataSet ds = new DataSet();
        //        sqlDataAdapter.Fill(ds, "Table");

        //        return ds;
        //    }
        //}

        //#endregion

        #region Count

        public virtual int Count<TEntity>(Expression<Func<TEntity, bool>> predicate = null)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Count(predicate);
        }
        #endregion

        #region Contains

        public virtual bool Contains<TEntity>(Expression<Func<TEntity, bool>> predicate)
            where TEntity : EntityRoot, new()
        {
            return Repo<TEntity>().Contains(predicate);
        }

        #endregion

        #region Filter

        public virtual Tuple<IQueryable<TEntity>, int> Filter<TEntity>(Expression<Func<TEntity, bool>> predicate, int index = 0, int size = 50)
            where TEntity : EntityRoot, new()
        {
            int total = 0;

            return new Tuple<IQueryable<TEntity>, int>(Repo<TEntity>().Filter(predicate, out total, index, size), total);
        }

        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (EFContext != null)
                    {
                        EFContext.Dispose();
                        EFContext = null;
                    }

                    repositories.Clear();
                }
            }

            this.disposed = true;
        }

        #endregion

        public virtual void SaveChanges(bool withDisposing = false)
        {
            try
            {
                EFContext.SaveChanges();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (withDisposing)
                {
                    Dispose();
                }
            }
        }
    }
}