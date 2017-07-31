using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using AutoMapper;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Infrastructure.Extensions
{
    public static class DtoEx
    {
        public static TDestination MapTo<TDestination>(this DtoRoot source)
            where TDestination : EntityRoot
        {
            return (source == null) ? default(TDestination) : Mapper.Map<TDestination>(source);
        }

        public static IEnumerable<TDestination> MapTo<TDestination>(this IEnumerable<DtoRoot> source)
            where TDestination : EntityRoot
        {
            return (source == null) ? new List<TDestination>() : Mapper.Map<IEnumerable<TDestination>>(source);
        }
    }
}