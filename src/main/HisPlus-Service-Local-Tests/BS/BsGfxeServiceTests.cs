using AppPlus.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Xunit;
using Serialize.Linq.Nodes;
using AutoMapper;
using System.Linq.Expressions;
using Serialize.Linq.Extensions;
using System.ServiceModel;
using Serialize.Linq.Serializers;
using HisPlus.Contract.Services;
using AppPlus.Client;
using HisPlus.Contract.Messages;
using HisPlus.Service.Local.Tests.Common;
using AppPlus.Infrastructure.Contract.Services;

namespace HisPlus.Service.Local.Tests
{
    public class BsGfxeServiceTests : TestBase, IClassFixture<BsGfxeServiceTestsFixture>
    {
        private const string TraitName = "继承属性兰不达表达式的测试";
        private const string TraitValue = "RetrieveByExpression";

        [Fact(DisplayName = "001_Call_Service_Inheritance_AutoMapperMappingException_NOK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Service_Inheritance_AutoMapperMappingException_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = (BsGfxeDTO x) => x.Id == 3;

            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
            
            Assert.Throws<AutoMapperMappingException>(() =>
            {
               var result = ServiceHandler.CallService((IBsGfxeService x) => x.Retrieve(predicateExpressionNode));
            });
        }

        [Fact(DisplayName = "002_Call_Service_NoneInheritance_OK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Service_NoneInheritance_OK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = (BsGfxeDTO x) => x.IsActive;
            
            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();

            var result = ServiceHandler.CallService((IBsGfxeService x) => x.Retrieve(predicateExpressionNode));

            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact(DisplayName = "003_Call_Service_Inheritance_InvalidCastException_NOK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Repository_Inheritance_InvalidCastException_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = (BsGfxeDTO x) => x.Id == 3;
                   
            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
            Assert.Throws<AutoMapperMappingException>(() =>
            {
                var result = ServiceHandler.CallService((IBsGfxeService x) => x.Retrieve(predicateExpressionNode));
                //Assert.NotNull(result);
                //Assert.NotEmpty(result);
            });          
        }

        [Fact]
        public void TestMethod_Contains()
        {
            var result = ServiceHandler.CallService((IBsGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.NotEmpty(result);

            var item = result.FirstOrDefault();

            var contains = ServiceHandler.CallService((IBsGfxeService x) => x.Contains(item));

            Assert.True(contains);
        }

        [Fact(DisplayName = "002_DbTransaction_OK")]
        [Trait(TraitName, "DbTransaction_OK")]
        public void DbTransaction_NOK()
        {
            var result = CallService((ISampleService x) => x.TransactionTest());
        }
    }
}