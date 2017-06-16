using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using Xunit;
using AppPlus.Client;
using System.ServiceModel;
using AppPlus.His.Services.Tests.BS.Fixture;
using HisPlus.Contracts.Services.BS;
using HisPlus.Contracts.Messages.BS;

namespace AppPlus.His.Services.Tests.BS
{
    public class BSGfxeServiceUnitTests : TestBase, IClassFixture<BSGfxeServiceFixture>
    {
        private const string TraitName = "BSGfxeServiceUnitTests";
        private const string TraitValue = "费用限额基础数据";

        #region Retrieve
        [Fact(DisplayName = "004_RetrieveAll_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveAll_OK_TestMethod()
        {
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "002_RetrieveById_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveById_OK_TestMethod()
        {
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.RetrieveById(Constants.QUOTA_ID));
            Assert.NotNull(result);
            Assert.True(result.Id == Constants.QUOTA_ID);
        }

        [Fact(DisplayName = "003_RetrieveByExpression_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveByExpression_OK_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => !x.IsActive);
            var expressionNode = expression.ToExpressionNode();

            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
        }        
        #endregion

        #region Contains
        [Fact(DisplayName = "001_ContainsByEntity_OK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByEntity_OK_TestMethod()
        {
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            var item = result.FirstOrDefault();
            
            var exists = ServiceHandler.CallService((IBSGfxeService x) => x.Contains(item));
            Assert.True(exists);            
        }

        [Fact(DisplayName = "002_ContainsByExpression_ExcludeKey_OK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByExpression_ExcludeKey_OK_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Contains(expressionNode));
            Assert.True(result);            
        }

        [Fact(DisplayName = "003_ContainsByExpression_IncludeKey_NOK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByExpression_NOK_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();

            Assert.Throws<FaultException>(() =>
            {
                var result = ServiceHandler.CallService((IBSGfxeService x) => x.Contains(expressionNode));
            });
        }
        #endregion

        #region Count
        [Fact(DisplayName="001_Count_OK")]
        [Trait(TraitName, "Count")]        
        public void Count_TestMethod()
        {
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Count());
            Assert.NotNull(result);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "002_CountByExpression_ExcludeKey_OK")]
        [Trait(TraitName, "Count")]
        public void CountByExpression_ExcludeKey_OK_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Count(expressionNode));
            Assert.NotNull(result);
            Assert.True(result > 0);

            expression = ((BsGfxeDto x) => x.PyCode == "CSFYXE");
            expressionNode = expression.ToExpressionNode();
            result = ServiceHandler.CallService((IBSGfxeService x) => x.Count(expressionNode));
            Assert.NotNull(result);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "003_CountByExpression_IncludeKey_NOK")]
        [Trait(TraitName, "Count")]
        public void CountByExpression_IncludeKey_NOK_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();

            Assert.Throws<FaultException>(() => 
            {
                var result = ServiceHandler.CallService((IBSGfxeService x) => x.Count(expressionNode));                
            }); 
        }
        #endregion

        #region Create
        [Fact(DisplayName = "001_Create_OK")]
        [Trait(TraitName, "Create")]
        public void Create_TestMethod()
        {
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);

            var newItem = result.FirstOrDefault();
            newItem.Code = "99";
            newItem.Name = "测试费用限额";
            newItem.PyCode = "CSFYXE";
            newItem.WbCode = "CCCCCC";
            newItem.IsActive = false;
            newItem.F4 = Constants.FLAG_TO_TEST;
            newItem = ServiceHandler.CallService((IBSGfxeService x) => x.Create(newItem));
            
            Assert.NotNull(newItem);
            Assert.True(newItem.Id > 0);            
        }
        #endregion

        #region Update
        [Fact(DisplayName = "001_Update_OK")]
        [Trait(TraitName, "Update")]
        public void Update_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.F4 == Constants.FLAG_TO_TEST);
            var expressionNode = expression.ToExpressionNode();
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);

            var itemToBeUpdated = result.FirstOrDefault();            

            string code = "1000";

            itemToBeUpdated.Code = code;
            itemToBeUpdated.Name = "测试更新";
            itemToBeUpdated.PyCode = "CSGX";
            itemToBeUpdated.WbCode = "CCCC";
            itemToBeUpdated.IsActive = true;
            ServiceHandler.CallService((IBSGfxeService x) => x.Update(itemToBeUpdated));

            var updatedItem = ServiceHandler.CallService((IBSGfxeService x) => x.RetrieveById(itemToBeUpdated.Id));
            Assert.NotNull(updatedItem);
            Assert.True(updatedItem.Code == code);
        }

        [Fact(DisplayName = "002_UpdateAll_OK")]
        [Trait(TraitName, "Update")]
        public void UpdateAll_TestMethod()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.F4 == Constants.FLAG_TO_TEST);
            var expressionNode = expression.ToExpressionNode();
            var result = ServiceHandler.CallService((IBSGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            string F1 = "TESTING DATA";

            foreach (var item in result)
            {
                item.F1 = F1;
            }

            ServiceHandler.CallService((IBSGfxeService x) => x.Update(result));
            result = ServiceHandler.CallService((IBSGfxeService x) => x.Retrieve(expressionNode));
            foreach (var item in result)
            {
                Assert.Equal(F1, item.F1);
            }
        }
        #endregion        
    }
}
