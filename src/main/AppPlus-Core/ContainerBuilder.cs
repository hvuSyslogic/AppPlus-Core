using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using Microsoft.Practices.Unity;
using AppPlus.Core.EntityFramework;
using AppPlus.Infrastructure.Contracts.Services;

namespace AppPlus.Core
{
    public class ContainerBuilder
    {
        public static IUnityContainer Build<TDbContext>(string connectionString)
            where TDbContext : DbContext
        {
            IUnityContainer unityContainer = IoCContainer.Instance;
            unityContainer.RegisterType<DbContext, TDbContext>(new InjectionConstructor(connectionString))
                .RegisterType<IUnitOfWork, UnitOfWork<TDbContext>>()
                .RegisterType<ICommandWrapper, CommandWrapper>()
                //.RegisterType<ICommonService, CommonService>()
                ;

            return unityContainer;
        }
    }
}