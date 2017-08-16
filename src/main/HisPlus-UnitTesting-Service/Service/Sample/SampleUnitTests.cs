using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.Infrastructure.Contract.Messages;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Client;
using HisPlus.Infrastructure.Exceptions;
using System.Linq.Expressions;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using HisPlus.UnitTesting.Common;

namespace HisPlus.UnitTesting.Service.Sample
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

        [Fact(DisplayName = "002_UnitOfWork_Transaction_NOK")]
        [Trait(TraitName, TraitValue)]
        public void UnitOfWork_Transaction_NOK()
        {
            Action action = () => CallService((ISampleService x) => x.L1Transaction());
            action.ShouldThrow<HisPlusException>();
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
            var result = CallService((IBsItemUnitService x) => x.GetAllByPage());
            st.Stop();
            var elapsedTime = st.Elapsed.TotalMilliseconds;
        }

        [Fact(DisplayName = "003_Join_OK")]
        [Trait(TraitName, TraitValue)]
        public void GetPatientInHosInfo_By_CardNo_TestMethod() 
        {
            string cardNo = "201708030030";
            var result = CallService((ISampleService x) => x.GetPatientInHosInfo(cardNo));

            result.Should().NotBeNull();
            result.Patient.InPatNo.Should().Be(result.InHosInfo.InPatNo);
            result.Patient.CardNo.Should().Be(cardNo);
        }

        [Fact(DisplayName = "004_Nested_Transaction_NOK")]
        [Trait(TraitName, TraitValue)]
        public void Nested_Transaction_NOK()
        {            
            Expression<Func<GblRoleDTO, bool>> expression = (x => x.GroupName == "");
            var expressionNode = expression.ToExpressionNode();
            
            GblRoleDTO roleDTO = CallService((IGblRoleService x) => x.GetBy(expressionNode)).FirstOrDefault();
            roleDTO.Should().NotBeNull();

            BsLocationDTO locationDTO = CallService((IBsLocationService x) => x.GetAll()).FirstOrDefault();
            locationDTO.Should().NotBeNull();

            Action action = () => CallService((ISampleService x) => x.L2Transaction(roleDTO, locationDTO));
            action.ShouldThrow<HisPlusException>();
        }

        [Fact(DisplayName="005_Expression_To_Expression_Node")]
        [Trait(TraitName, TraitValue)]
        public void Expression_To_Expression_Node()
        {
            var workStation = "AEOAY-603111527";
            var ipAddr = "192.168.1.140";
            var userId = 9;

            Expression<Func<GblOnlinerDTO, bool>> expression = ((GblOnlinerDTO t) => 
                t.WorkStationName == workStation && t.LockIp == ipAddr && t.UserId == userId);

            var expressionNode = expression.ToExpressionNode();
            
            expressionNode.Should().NotBeNull();
        }
    }
}