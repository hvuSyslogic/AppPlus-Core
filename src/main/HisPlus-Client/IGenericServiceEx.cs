using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;

namespace HisPlus.Client
{
    public static class IGenericServiceEx
    {
        #region GetAllByPage   
        public static IEnumerable<TDTO> GetAllByPage<TDTO, TKey>(this IGenericService<TDTO, TKey> service, int pageSize)
            where TDTO : DtoBase<TKey>, new()
            where TKey : struct
        {
            var allPages = new List<TDTO>();
            int nextPageNumber = 1;
            int pageCount = 0;
            do
            {
                var page = service.GetByPage(nextPageNumber, pageSize, out pageCount);
                allPages.AddRange(page);

            } while (nextPageNumber++ < pageCount);

            return allPages;
        }
        #endregion
    }
}
