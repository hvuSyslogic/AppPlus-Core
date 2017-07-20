using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Core.EntityFramework;
using Castle.Core.Logging;

namespace HisPlus.Core
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        DbContext Session { get; set; }

        void Commit();

        IRepository<TEntity> Repo<TEntity>() where TEntity : EntityRoot, new();

        void Rollback();

        #endregion        
    }
}