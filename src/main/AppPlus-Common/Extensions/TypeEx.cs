﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPlus.Common.Dynamic;

namespace AppPlus.Common.Extensions
{
    public static class TypeEx
    {
        public static bool IsDerivedOfGenericType(this Type type, Type genericType)
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

        public static bool IsAssignableFrom(this Type type, string typeName)
        {
            return type.GetInterfaces()
                .Where(x => x.FullName == typeName)
                .Any();
        }

        public static object GetDefaultValue(this Type type)
        {
            object defaultValue = null;

            if (typeof(IEnumerable).IsAssignableFrom(type))
            {
                if (type.IsGenericType)
                {
                    var genericArguments = type.GetGenericArguments();
                    Type template = type.GetGenericTypeDefinition();

                    if (template == typeof(IEnumerable<>))
                    {
                        defaultValue = Activator.CreateInstance(typeof(Enumerable).MakeGenericType(genericArguments));
                    }
                    else if (template == typeof(IList<>))
                    {
                        defaultValue = Activator.CreateInstance(typeof(List<>).MakeGenericType(genericArguments));
                    }
                    else if (template == type)
                    {
                        defaultValue = Activator.CreateInstance(type.MakeGenericType(genericArguments));
                    }
                }

                try
                {
                    if (type.IsValueType)
                    {
                        defaultValue = Activator.CreateInstance(type);
                    }
                }
                catch (MissingMethodException)
                {
                }
            }

            return defaultValue;
        }

        public static bool IsSubclassOfRawGeneric(this Type type, Type generic)
        {
            while (type != null & type != typeof(object))
            {
                var intermediate = type.IsGenericType ? type.GetGenericTypeDefinition() : type;
                if (generic == intermediate)
                {
                    return true;
                }
                type = type.BaseType;
            }
            return false;
        }

        public static bool IsRawGeneric(this Type type, Type generic)
        {
            if (type == null || generic == null) return false;

            return type.IsGenericType && type.GetGenericTypeDefinition() == generic;
        }

        public static dynamic AsStaticMembersDynamicWrapper(this Type type)
        {
            return new StaticMembersDynamicWrapper(type);
        }

        //public static object GetDefaultValue(this Type type)
        //{
        //    if (type.IsValueType)
        //    {
        //        return Activator.CreateInstance(type);
        //    }
        //    return null;
        //}

    }
}
