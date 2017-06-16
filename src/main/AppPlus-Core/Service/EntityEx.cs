using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AppPlus.Infrastructure.Contracts.Messages;

namespace AppPlus.Core.Service
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

        public static void Validate(this EntityRoot entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
        }

        public static void Validate(this IEnumerable<EntityRoot> entities)
        {
            if (entities == null) throw new ArgumentException("Entity list can not be null");

            if (!entities.Any()) throw new ArgumentException("Entity list can not be empty");
        }
    }

}