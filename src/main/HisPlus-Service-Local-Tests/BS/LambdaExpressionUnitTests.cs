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
using HisPlus.Domain.BS;
using System.ServiceModel;
using Serialize.Linq.Serializers;
using HisPlus.Contracts.Messages.BS;
using HisPlus.Contracts.Services.BS;

namespace AppPlus.His.Domain.Tests.BS
{
    public class LambdaExpressionUnitTests : TestBase
    {
        private const string TraitName = "继承属性兰不达表达式的测试";
        private const string TraitValue = "RetrieveByExpression";

        [Fact(DisplayName = "001_Call_Service_Inheritance_NOK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Service_Inheritance_NOK()
        {
            IBSGfxeService service = Container.Resolve<IBSGfxeService>();
            Assert.NotNull(service);

            Expression<Func<BsGfxeDto, bool>> expression = (BsGfxeDto x) => x.Id == 3;

            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
            
            Assert.Throws<AutoMapperMappingException>(() =>
            {
               var result = service.Retrieve(predicateExpressionNode);
            });                
        }

        [Fact(DisplayName = "002_Call_Service_NoneInheritance_OK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Service_NoneInheritance_OK()
        {
            IBSGfxeService service = Container.Resolve<IBSGfxeService>();
            Assert.NotNull(service);

            Expression<Func<BsGfxeDto, bool>> expression = (BsGfxeDto x) => x.IsActive;
            
            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
                        
            var result = service.Retrieve(predicateExpressionNode);
            Assert.NotNull(result);
            Assert.NotEmpty(result);
        }

        [Fact(DisplayName = "003_Call_Repository_Inheritance_OK")]
        [Trait(TraitName, TraitValue)]
        public void TestMethod_Call_Repository_Inheritance_OK()
        {
            //ICommandWrapper commandWrapper = Container.Resolve<ICommandWrapper>();
            //Assert.NotNull(commandWrapper);

            //Expression<Func<BsGfxe, bool>> expression = (BsGfxe x) => x.Id == 3;
            
            //using (var command = commandWrapper)
            //{
            //    var result = command.Execute(uow => 
            //    {
            //        return uow.Repository<BsGfxe>().Retrieve(expression).ToList();
            //    });

            //    Assert.NotNull(result);
            //    Assert.NotEmpty(result);
            //}
        }

        [Fact]
        public void TestMethod_Contains()
        {
            IBSGfxeService service = Container.Resolve<IBSGfxeService>();
            Assert.NotNull(service);
            
            var result = service.RetrieveAll();

            Assert.NotNull(result);
            Assert.NotEmpty(result);

            var item = result.FirstOrDefault();

            var contains = service.Contains(item);

            Assert.True(contains);
        }
    }
}
