using AppPlus.Infrastructure.Contract.Messages;
using AppPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Service.Remote.Tests.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Diagnostics;

namespace HisPlus.Service.Remote.Tests.Sample
{
    public partial class SampleTests : TestBase
    {
        const string TraitName = "SampleTests.Remote";
         
        [Fact(DisplayName = "001_GetCurrentDataTime_OK")]
        [Trait(TraitName, "GetCurrentDataTime")]
        public void GetCurrentDataTime_OK()
        {
            var result = CallService((ICommonService x) => x.GetCurrentDateTime());
            Assert.IsType<DateTime>(result);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "002_EntityFramework_L1_Cache_OK")]
        [Trait(TraitName, "EntityFramework_L1_Cache")]
        public void EntityFramework_L1_Cache_OK()
        {
            var result = CallService((ISampleService x) => x.L1CacheTest());
        }

        [Fact(DisplayName = "002_DbTransaction_OK")]
        [Trait(TraitName, "DbTransaction_OK")]
        public void DbTransaction_NOK()
        {
            var result = CallService((ISampleService x) => x.TransactionTest());
        }

        [Fact]
        public void LargeDataTest()
        {
            //int currentPageNumber = 1;
            //int pageSize = 50000;
            //int totalPages = 0;

            //do
            //{
            //    var result = CallService((IBsItemUnitService x) => x.Filter(out totalPages, currentPageNumber, pageSize));                
            //    currentPageNumber++;
            //} while (totalPages > currentPageNumber);

            var st = new Stopwatch();
            st.Start();
            var result = RetrieveByPage<IBsItemUnitService, BsItemUnitDTO, int>();
            st.Stop();
            var elapsedTime = st.Elapsed;
        }

        private List<TDTO> RetrieveByPage<T, TDTO, TKey>(int pageSize = 100000)
            where T : IGenericService<TDTO, TKey>
            where TDTO : DtoBase<TKey>, new()
            where TKey : struct
        {
            var pages = new List<TDTO>();
            int nextPageNumber = 1;
            int totalPages = 0;
            do
            {
                var page = CallService((T x) => x.Filter(out totalPages, nextPageNumber, pageSize));
                pages.AddRange(page);
            } while (nextPageNumber++ < totalPages);

            return pages;
        }
    }
}
