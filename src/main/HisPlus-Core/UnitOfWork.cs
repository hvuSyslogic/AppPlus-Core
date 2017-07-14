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
using log4net;
using Z.EntityFramework.Plus;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Core.Infrastructure.CodeContracts;
using HisPlus.Core.Redis;
using HisPlus.Infrastructure;

namespace HisPlus.Core.EntityFramework
{
    /// <summary>
    /// https://www.codeproject.com/articles/543810/dependency-injection-and-unit-of-work-using-castle
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        [ThreadStatic]
        private static UnitOfWork _current;

        private readonly DbContextTransaction _transaction;        

        #region Construct(s)
    
        private UnitOfWork(UnitOfWorkSettings settings)
        {
            Settings = settings ?? UnitOfWorkSettings.Default;
            Session = DependencyContext.Container.Resolve<DbContext>();
            SetSession(Session);
            if (Settings.EnableCommit)
            {
                _transaction = Session.Database.BeginTransaction();
            }
        }

        #endregion

        private void SetSession(DbContext session)
        {
            Requires.NotNull(session, "session");

            if (_current == null)
            {
                IsRoot = true;
            }
            else
            {
                if (Settings.ThrowIfNestedUnitOfWork)
                    throw new NotSupportedException("Nested UnitOfWorks are not supported due to UnitOfWorkSettings configuration");

                IsRoot = false;
            }

            _current = this;
            Id = Guid.NewGuid();
        }

        #region Properties

        public Guid Id { get; private set; }

        public bool IsFinished
        {
            get { return _current == null; }
        }

        public bool IsRoot { get; private set; }
      
        public DbContext Session { get; set; }
        
        public bool IsConnectionOpen
        {
            get { return Session != null; }
        }

        public UnitOfWorkSettings Settings { get; private set; }

        public IRepository<TEntity> Repo<TEntity>()
           where TEntity : EntityRoot, new()
        {
            if (!repositories.ContainsKey(typeof(TEntity)))
            {
                var repository = DependencyContext.Container.Resolve<IRepository<TEntity>>(new { unitOfWork = this });
                repositories.Add(new KeyValuePair<Type, object>(typeof(TEntity), repository));
            }

            return (IRepository<TEntity>)repositories[typeof(TEntity)];
        }

        #endregion

        #region Do (Action or Function)

        public static void Do(Action<UnitOfWork> work, UnitOfWorkSettings settings = null)
        {
            Requires.NotNull(work, "work");

            using (var uow = new UnitOfWork(settings))
            {                              
                work(uow);               
            }
        }

        public static TResult Do<TResult>(Func<UnitOfWork, TResult> work, UnitOfWorkSettings settings = null)
        {
            Requires.NotNull(work, "work");

            using (var uow = new UnitOfWork(settings))
            {
                return work(uow);
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
                if (Settings.RollbackOnDispose)
                {
                    Rollback();
                }
                else
                {
                    Commit();
                }                    
            }
            else
            {
                if (IsRoot && !IsFinished)
                {
                    CloseUnitOfWork();
                }
            }
        }

        public void Rollback()
        {
            Perform(() => 
            {
                if (Settings.EnableCommit && _transaction != null)
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

                if (Settings.EnableCommit && _transaction != null)
                {                    
                    _transaction.Commit();
                }                    
            });
        }

        private void Perform(Action action)
        {
            Requires.NotNull(action, "action");
            if (IsRoot && !IsFinished)
            {
                try
                {
                    action();
                }
                finally
                {
                    CloseUnitOfWork();
                }
            }
        }

        private void CloseUnitOfWork()
        {
            repositories.Clear();
            if ( Settings.EnableCommit && _transaction != null)
            {
                _transaction.Dispose();
            }
            Session.Dispose();
            _current = null;
        }
    }
}