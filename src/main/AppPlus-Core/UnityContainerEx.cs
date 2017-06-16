﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using log4net;
using Microsoft.Practices.Unity;
using AppPlus.Core;
using AppPlus.Core.Service;
using AppPlus.Infrastructure.Contracts.Services;

namespace AppPlus.Core
{
    public static class UnityContainerEx
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static IUnityContainer RegisterAssembly(this IUnityContainer unityContainer, Assembly fromAssembly, Assembly toAssembly)
        {
            var allRegisteredTypes = fromAssembly.GetTypes()
                .Where(x => typeof(IServiceRoot).IsAssignableFrom(x));

            var allMappedToTypes = toAssembly.GetTypes()
                .Where(x => x.IsClass && x.IsDerivedOfGenericType(typeof(AbstractService<,,>)));

            Log.Debug("=================================================== Starting to register types in assembly =======================================================");
            Log.DebugFormat("Registered Assembly: {0} ", fromAssembly.FullName);
            Log.DebugFormat("Mapped TypeAssembly: {0} ", toAssembly.FullName);

            int totalOfRegisteredTypes = 0;

            foreach (var registeredType in allRegisteredTypes)
            {
                var mappedToTypes = allMappedToTypes.Where(x => registeredType.IsAssignableFrom(x));

                if (mappedToTypes.Any())
                {
                    foreach (var mappedToType in mappedToTypes)
                    {
                        if (!unityContainer.IsRegistered(registeredType))
                        {
                            unityContainer.RegisterType(registeredType, mappedToType);
                            Log.DebugFormat("Type {0} ==========> {1}", mappedToType.FullName, registeredType.FullName);
                            totalOfRegisteredTypes++;
                        }
                    }
                }
            }
            
            Log.DebugFormat("=================================================== {0} types was registered successfully ========================================================", totalOfRegisteredTypes);
            
            return unityContainer;
        }

        private static bool IsDerivedOfGenericType(this Type type, Type genericType)
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