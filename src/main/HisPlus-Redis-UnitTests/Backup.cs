using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Redis.UnitTests
{
    class Class1
    {
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    CacheProvider redis = new CacheProvider(0);

        //    new Thread((ThreadStart)delegate()
        //    {
        //        var result = RetrieveByPage<IBsItemUnitService, BsItemUnitDTO, int>();
        //    }).Start();
        //}

        //private List<TDTO> RetrieveByPage<T, TDTO, TKey>(int pageSize = 100000)
        //    where T : IGenericService<TDTO, TKey>
        //    where TDTO : DtoBase<TKey>, new()
        //    where TKey : struct
        //{
        //    var pages = new List<TDTO>();
        //    int nextPageNumber = 1;
        //    int totalPages = 0;
        //    do
        //    {
        //        var page = ServiceHandler.CallService((T x) => x.Filter(out totalPages, nextPageNumber, pageSize));
        //        pages.AddRange(page);
        //    } while (nextPageNumber++ < totalPages);

        //    return pages;
        //}
    }
}
