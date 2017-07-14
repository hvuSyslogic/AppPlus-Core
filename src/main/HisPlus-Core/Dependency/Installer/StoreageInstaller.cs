﻿using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using HisPlus.Core.EntityFramework;
using HisPlus.Core.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Core.Dependency.Installer
{
    public class StoreageInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // You can set dependencies on Resolve() method by adding an anonymous type with constructor parameter's name
            // type = container.Resolve<IType>(new { connectionString = connectionString });

            container.Register(Component.For<ICacheProvider>().ImplementedBy<CacheProvider>().LifestyleTransient());
            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifestyleTransient());            
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifestyleTransient());                                    
        }
    }
}