using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data.Entity.Infrastructure;
using AutoMapper;
using Castle.Core.Logging;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Infrastructure.Contract.Services;

namespace HisPlus.Core.Abstractions.Support
{    
    public abstract class ServiceRoot : Profile, IServiceRoot
    {
        private bool _disposed = false;

        public ServiceRoot()
        {
            Logger = NullLogger.Instance;
        }

        public ILogger Logger { get; set; }

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
            });
        }
    }
}
