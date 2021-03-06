﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.DependencyInjection
{
    public class AllTypes
    {
        public static IEnumerable<Type> BasedOn<T>(IEnumerable<Assembly> from = null)
        {
            return BasedOn(typeof(T), from);
        }

        public static IEnumerable<Type> BasedOn(Type baseType, IEnumerable<Assembly> from = null)
        {
            var lookinAssemblies = from ?? From.AllAssemblies();

            return lookinAssemblies
                .SelectMany(a => a.GetTypes())
                .Where(baseType.IsAssignableFrom);
        }
    }
}
