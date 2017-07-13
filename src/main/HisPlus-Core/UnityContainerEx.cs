﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using HisPlus.Core;
using HisPlus.Core.Service;
using HisPlus.Infrastructure.Contract.Services;
using System.Data.Entity;
using HisPlus.Core.EntityFramework;
using AutoMapper;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Core.Redis;

namespace HisPlus.Core
{
    public static class UnityContainerEx
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static IUnityContainer RegisterAssembly(this IUnityContainer unityContainer, Assembly fromAssembly, Assembly toAssembly)
        {
            var allRegisteredTypes = fromAssembly.GetTypes()
                .Where(x => typeof(IServiceRoot).IsAssignableFrom(x));

            var allMappedToTypes = toAssembly.GetTypes()                
                .Where(x => x.IsClass && (x.IsDerivedOfGenericType(typeof(AbstractService<,,>)) || x.IsSubclassOf(typeof(ServiceRoot))));

            //Log.Debug("=================================================== Starting to register types in assembly =======================================================");
            //Log.DebugFormat("Registered Assembly: {0} ", fromAssembly.FullName);
            //Log.DebugFormat("Mapped TypeAssembly: {0} ", toAssembly.FullName);

            int totalOfRegisteredTypes = 0;

            allRegisteredTypes.ToList().ForEach(type => 
            {
                var mappedToTypes = allMappedToTypes.Where(x => type.IsAssignableFrom(x));

                if (mappedToTypes.Any())
                {
                    foreach (var mappedToType in mappedToTypes)
                    {
                        if (!unityContainer.IsRegistered(type))
                        {
                            unityContainer.RegisterType(type, mappedToType);
                            //Log.DebugFormat("Type {0} ==========> {1}", mappedToType.FullName, registeredType.FullName);
                            totalOfRegisteredTypes++;
                        }
                    }
                }
            });
        
            //Log.DebugFormat("=================================================== {0} types was registered successfully ========================================================", totalOfRegisteredTypes);
            
            return unityContainer;
        }

        public static IUnityContainer RegisterMapProfiles(this IUnityContainer container, Assembly profileAssembly)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(profileAssembly);
            });

            return container;
        }

        public static IUnityContainer RegisterStorage<TDbContext>(this IUnityContainer container, string connectionString)
             where TDbContext : DbContext
        {
            container.RegisterType<DbContext, TDbContext>(new InjectionConstructor(connectionString))
                .RegisterType<DbContext, TDbContext>()
                .RegisterType<IUnitOfWork, UnitOfWork>()
                .RegisterType(typeof(IRepository<>), typeof(Repository<>))
                .RegisterType<ICommonService, CommonService>()
                .RegisterType<ICacheProvider, CacheProvider>(new InjectionConstructor(0))
                ;

            return container;      
        }

        public static IUnityContainer RegisterServices(this IUnityContainer container, Assembly fromAssembly, Assembly toAssembly)
        {            
            return container.RegisterAssembly(fromAssembly, toAssembly);
        }

        internal static bool IsDerivedOfGenericType(this Type type, Type genericType)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition() == genericType)
            {
                return true;
            }

            if (type.BaseType != null)
            {
                return IsDerivedOfGenericType(type.BaseType, genericType);
            }

            return false;
        }
    }    
}