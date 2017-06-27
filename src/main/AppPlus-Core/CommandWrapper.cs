using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Transactions;
using System.Data.Entity;
using log4net;
using Microsoft.Practices.Unity;
using AppPlus.Core.EntityFramework;

namespace AppPlus.Core
{
    public class CommandWrapper : ICommandWrapper
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private bool _disposed;
        private IUnitOfWork _unitOfWork;

        [InjectionConstructor]
        public CommandWrapper(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void Execute(Action<IUnitOfWork> action, UnitOfWorkSettings unitOfWorkSettings = null)
        {
            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            unitOfWorkSettings = unitOfWorkSettings ?? new UnitOfWorkSettings() { TransactionScope = TransactionOption.Default };

            using (_unitOfWork)
            {
                try
                {
                    switch (unitOfWorkSettings.TransactionScope)
                    {
                        case TransactionOption.Default:
                            this.ExecuteCommand(action);
                            break;

                        case TransactionOption.DBTransaction:
                            this.ExecuteTXCommand(action);
                            break;

                        case TransactionOption.TransactionScope:
                            this.ExecuteTSCommand(action);
                            break;

                        default:
                            this.ExecuteCommand(action);
                            break;
                    }

                }
                catch(Exception ex) 
                {
                    Log.Error(ex);
                    if (_unitOfWork != null)
                    {
                        _unitOfWork.Dispose();
                        _unitOfWork = null;
                    }

                    Log.Error(ex.Unwrap());

                    ex.RethrowWithNoStackTraceLoss();
                }
            }
        }

        public TResult Execute<TResult>(Func<IUnitOfWork, TResult> action, UnitOfWorkSettings unitOfWorkSettings = null)
        {
            TResult result = default(TResult);

            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            unitOfWorkSettings = unitOfWorkSettings ?? new UnitOfWorkSettings() { TransactionScope = TransactionOption.Default };

            using (_unitOfWork)
            {
                try
                {
                    switch (unitOfWorkSettings.TransactionScope)
                    {
                        case TransactionOption.Default:
                            result = this.ExecuteCommand(action);
                            break;

                        case TransactionOption.DBTransaction:
                            result = this.ExecuteTXCommand(action);
                            break;

                        case TransactionOption.TransactionScope:
                            result = this.ExecuteTSCommand(action);
                            break;

                        default:
                            result = this.ExecuteCommand(action);
                            break;
                    }
                }
                catch(Exception ex)
                {
                    if (_unitOfWork != null)
                    {
                        _unitOfWork.Dispose();
                        _unitOfWork = null;
                    }
                    
                    Log.Error(ex.Unwrap());

                    ex.RethrowWithNoStackTraceLoss();
                }
                
            }

            return result;
        }       

        private void ExecuteCommand(Action<IUnitOfWork> action)
        {
            action(_unitOfWork);
            _unitOfWork.SaveChanges();
        }

        private void ExecuteTXCommand(Action<IUnitOfWork> action)
        {
            var db = _unitOfWork.EFContext.Database;

            using (var tx = db.BeginTransaction())
            {
                try
                {
                    this.ExecuteCommand(action);
                    tx.Commit();
                }
                catch(Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        tx.Dispose();
                    }

                    ex.RethrowWithNoStackTraceLoss();
                }
            }
        }

        private void ExecuteTSCommand(Action<IUnitOfWork> action)
        {
            using (var tx = new TransactionScope())
            {
                try
                {
                    this.ExecuteCommand(action);
                    tx.Complete();
                }
                catch(Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Dispose();
                    }

                    ex.RethrowWithNoStackTraceLoss();
                }
            }
        }

        private TResult ExecuteCommand<TResult>(Func<IUnitOfWork, TResult> action)
        {
            TResult result = default(TResult);

            result = action(this._unitOfWork);
            _unitOfWork.SaveChanges();

            return result;
        }

        private TResult ExecuteTXCommand<TResult>(Func<IUnitOfWork, TResult> action)
        {
            TResult result = default(TResult);

            var db = this._unitOfWork.EFContext.Database;

            using (var tx = db.BeginTransaction())
            {
                try
                {
                    result = this.ExecuteCommand(action);
                    tx.Commit();
                }
                catch(Exception ex)
                {
                    if (tx != null)
                    {
                        tx.Rollback();
                        tx.Dispose();
                    }

                    ex.RethrowWithNoStackTraceLoss();
                }
            }

            return result;
        }

        private TResult ExecuteTSCommand<TResult>(Func<IUnitOfWork, TResult> action)
        {
            TResult result = default(TResult);
            
            using (var ts = new TransactionScope())
            {
                try
                {
                    result = this.ExecuteCommand(action);
                    ts.Complete();
                }
                catch(Exception ex)
                {
                    if (ts != null)
                    {
                        ts.Dispose();
                    }

                    ex.RethrowWithNoStackTraceLoss();
                }
            }

            return result;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    if (this._unitOfWork != null)
                    {
                        this._unitOfWork.Dispose();
                        this._unitOfWork = null;
                    }
                }
            }

            this._disposed = true;
        }
    }
}
