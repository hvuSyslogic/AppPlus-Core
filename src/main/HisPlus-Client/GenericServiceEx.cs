using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;

namespace HisPlus.Client
{
    public static class GenericServiceEx
    {
        private const int PageSize = 100000;

        #region GetAllByPage

        public static IEnumerable<TDTO> GetAllByPage<TDTO>(this IGenericService<TDTO, int> service)
            where TDTO : DtoBase<int>, new()
        {
            return GetAllByPage<TDTO, int>(service, PageSize);
        }

        public static IEnumerable<TDTO> GetAllByPage<TDTO>(this IGenericService<TDTO, long> service)
            where TDTO : DtoBase<long>, new()
        {
            return GetAllByPage<TDTO, long>(service, PageSize);
        }

        public static IEnumerable<TDTO> GetAllByPage<TDTO>(this IGenericService<TDTO, int> service, int pageSize)
            where TDTO : DtoBase<int>, new()
        {
            return GetAllByPage<TDTO, int>(service, pageSize);
        }

        public static IEnumerable<TDTO> GetAllByPage<TDTO>(this IGenericService<TDTO, long> service, int pageSize)
            where TDTO : DtoBase<long>, new()
        {
            return GetAllByPage<TDTO, long>(service, pageSize);
        }

        private static IEnumerable<TDTO> GetAllByPage<TDTO, TKey>(this IGenericService<TDTO, TKey> service, int pageSize)
            where TDTO : DtoBase<TKey>, new()
            where TKey : struct
        {
            var pages = new List<TDTO>();
            int nextPageNumber = 1;
            int pageCount = 0;
            do
            {
                var page = service.GetPagedData(nextPageNumber, pageSize, out pageCount);
                pages.AddRange(page);

            } while (nextPageNumber++ < pageCount);

            return pages;
        }

        #endregion
    }
}
