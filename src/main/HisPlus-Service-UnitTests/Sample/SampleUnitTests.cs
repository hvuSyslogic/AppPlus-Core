using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using System.Diagnostics;
using HisPlus.UnitTests.Common;
using System.ServiceModel;
using HisPlus.Client;

namespace HisPlus.Service.UnitTests.Sample
{
    public partial class SampleUnitTests : TestBase
    {
        const string TraitName = "SampleUnitTests";
        const string TraitValue = "Multi_Test";

        [Fact(DisplayName = "001_EntityFramework_L1_Cache_NOK")]
        [Trait(TraitName, TraitValue)]
        public void EntityFramework_L1_Cache_OK()
        {
            var result = CallService((ISampleService x) => x.L1CacheTest());
        }

        [Fact(DisplayName = "002_Transaction_NOK")]
        [Trait(TraitName, TraitValue)]
        public void DbTransaction_NOK()
        {
            Assert.Throws<FaultException>(() => 
            {
                var result = CallService((ISampleService x) => x.TransactionTest());
            });            
        }

        //[Fact]
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
            var result = ServiceHandler.RetrievePagedData<IBsItemUnitService, BsItemUnitDTO, int>();
            st.Stop();
            var elapsedTime = st.Elapsed;
        }

        [Fact(DisplayName = "003_Join_OK")]
        [Trait(TraitName, TraitValue)]
        public void GetPatientInHosInfo_By_CardNo_TestMethod() 
        {
            string cardNo = "201707030007";            

            var result = CallService((ISampleService x) => x.GetPatientInHosInfo(cardNo));

            Assert.NotNull(result);
            Assert.Equal(result.Patient.InPatNo, result.InHosInfo.InPatNo);
            Assert.Equal(cardNo, result.Patient.CardNo);
        }
    }
}
