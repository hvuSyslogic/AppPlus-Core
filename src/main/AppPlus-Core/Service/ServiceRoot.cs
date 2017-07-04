using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Practices.Unity;
using AppPlus.Infrastructure.Configuration;
using AppPlus.Infrastructure.Contract.Services;
using log4net;
using System.Reflection;
using AppPlus.Core.EntityFramework;
using System.Data.Entity.Infrastructure;

namespace AppPlus.Core.Service
{    
    public abstract class ServiceRoot : Profile, IServiceRoot
    {
        private bool _disposed = false;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
          
        [Obsolete]
        protected override void Configure()
        {
            ConfigureMap();
        }

        protected virtual void ConfigureMap() { }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    // TODO:
                }
            }

            this._disposed = true;
        }

        public DateTime GetCurrentDateTime()
        {
            return UnitOfWork.Do(uow =>
            {
                return (uow.Session as IObjectContextAdapter).ObjectContext
                    .CreateQuery<DateTime>("CurrentDateTime()")
                    .AsEnumerable()
                    .First();
            }, new UnitOfWorkSettings() { EnableCommit = false });
        }
    }
}
