using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Contract.Messages;
using AutoMapper;

namespace HisPlus.Infrastructure.Extensions
{
    public static class EntityEx
    {
        public static TDestination MapTo<TDestination>(this EntityRoot source)
            where TDestination : DtoRoot
        {
            return (source == null) ? default(TDestination) : Mapper.Map<TDestination>(source);
        }

        public static IEnumerable<TDestination> MapTo<TDestination>(this IEnumerable<EntityRoot> source)
            where TDestination : DtoRoot
        {
            return (source == null) ? new List<TDestination>() : Mapper.Map<IEnumerable<TDestination>>(source);
        }
    }
}