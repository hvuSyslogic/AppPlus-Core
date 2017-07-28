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
using System.Runtime.InteropServices;
using Z.EntityFramework.Plus;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Core.Infrastructure.CodeContracts;
using System.Transactions;
using Castle.Core.Logging;
using HisPlus.Infrastructure.Dependency;

namespace HisPlus.Core.EntityFramework
{
    /// <summary>
    /// https://www.codeproject.com/articles/543810/dependency-injection-and-unit-of-work-using-castle   
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {        
        private IDictionary<Type, object> repositories = new Dictionary<Type, object>();
        
        /// <summary>
        /// Reference to the currently running transcation.
        /// </summary>
        private DbContextTransaction _transaction;

        [ThreadStatic]
        private static UnitOfWork _current;     

        #region Construct(s)
    
        private UnitOfWork()
        {            
            Session = IoCManager.Container.Resolve<DbContext>();
            if (Session == null)
            {
                throw new NullReferenceException("Can not resolve Session object from IoC container");
            }

            _current = this;
        }

        #endregion

        #region Properties

        public ILogger Logger 
        {
            get { return GetType().GetLogger(); }
        }        

        public DbContext Session { get; set; }
        
        public IRepository<TEntity> Repo<TEntity>()
           where TEntity : EntityRoot, new()
        {
            if (!repositories.ContainsKey(typeof(TEntity)))
            {
                var repository = IoCManager.Container.Resolve<IRepository<TEntity>>(new { unitOfWork = _current });
                repositories.Add(new KeyValuePair<Type, object>(typeof(TEntity), repository));
            }

            return (IRepository<TEntity>)repositories[typeof(TEntity)];
        }

        #endregion

        #region Do (Action or Function)

        public static void Do(Action<UnitOfWork> work, TransactionOption option = TransactionOption.SelfTransaction)
        {
            Requires.NotNull(work, "work");

            using (var uow = new UnitOfWork())
            {
                // Transaction Scope
                if (option == TransactionOption.TransactionScope)
                {
                    uow.DoTransactionScope(work, uow);                    
                }
                else
                {
                    // DbTransaction
                    if (option == TransactionOption.DbTransaction)
                    {
                        uow._transaction = uow.Session.Database.BeginTransaction();
                    }

                    // SelfTransaction
                    work(uow);
                }                
            }
        }

        private void DoTransactionScope(Action<UnitOfWork> work, UnitOfWork uow)
        {
            var ts = new TransactionScope();

            try
            {
                work(uow);
                ts.Complete();
            }
            catch (Exception ex)
            {
                Logger.Error("Do TransactionScope error: ", ex);
                throw;
            }
            finally
            {
                if (ts != null)
                {
                    ts.Dispose();
                }
            }
        }

        private TResult DoTransactionScope<TResult>(Func<UnitOfWork, TResult> work, UnitOfWork uow)
        {
            var ts = new TransactionScope();;

            try
            {                
                var result = work(uow);
                ts.Complete();
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error("Do TransactionScope error: ", ex);
                throw;
            }
            finally
            {
                if (ts != null)
                {
                    ts.Dispose();
                }                
            }
        }

        public static TResult Do<TResult>(Func<UnitOfWork, TResult> work, TransactionOption option = TransactionOption.SelfTransaction)
        {
            Requires.NotNull(work, "work");

            TResult result;

            using (var uow = new UnitOfWork())
            {
                if (option == TransactionOption.TransactionScope)
                {
                    result = uow.DoTransactionScope(work, uow);
                }
                else
                {
                    if (option == TransactionOption.DbTransaction)
                    {
                        uow._transaction = uow.Session.Database.BeginTransaction();
                    }

                    result = work(uow);
                }

                return result;
            }
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
            if (Marshal.GetExceptionCode() == 0)
            {                            
                Commit();               
            }
            else
            {                    
                CloseUnitOfWork();
            }
        }

        public void Rollback()
        {
            Perform(() => 
            {
                if (_transaction != null)
                {
                    _transaction.Rollback();
                }                    
            });
        }

        #endregion
      
        public void Commit()
        {
            Perform(() =>
            {
                Session.SaveChanges();

                if (_transaction != null)
                {                    
                    _transaction.Commit();
                }                    
            });
        }

        private void Perform(Action action)
        {
            Requires.NotNull(action, "action");

            try
            {
                action();
            }
            finally
            {
                CloseUnitOfWork();
            }
        }

        private void CloseUnitOfWork()
        {
            repositories.Clear();
            if ( _transaction != null)
            {
                _transaction.Dispose();
            }
            Session.Dispose();
            _current = null;
        }
    }
}