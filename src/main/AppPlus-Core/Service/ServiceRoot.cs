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

namespace AppPlus.Core.Service
{    
    public abstract class ServiceRoot : Profile, IServiceRoot
    {
        private bool _disposed = false;
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
                
        [Dependency]
        protected ICommandWrapper CommandWrapper
        {
            get;
            set;
        }

        [Obsolete]
        protected override void Configure()
        {
            ConfigureMap();
        }

        protected virtual void ConfigureMap() { }

        public void Dispose()
        {
            Log.Debug("ServiceRoot Dispose() .......");

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            Log.Debug("ServiceRoot Dispose(bool) .........");

            if (!this._disposed)
            {
                if (disposing)
                {
                    if (CommandWrapper != null)
                    {
                        CommandWrapper.Dispose();
                    }
                }
            }

            this._disposed = true;
        }
    }
}
