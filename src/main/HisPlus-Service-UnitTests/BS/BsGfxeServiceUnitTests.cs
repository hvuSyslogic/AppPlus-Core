using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using System.ServiceModel;
using Xunit;
using HisPlus.Client;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.UnitTests.Common;
using HisPlus.Service.UnitTests.Common;
using HisPlus.Infrastructure.Configuration;

namespace HisPlus.Service.UnitTests.BS
{
    public class BsGfxeServiceUnitTests : UnitTestBase<BsGfxeDTO>, IClassFixture<BsGfxeServiceTestsFixture>
    {
        private const string TraitName = "BSGfxeServiceUnitTests";        

        #region Retrieve
        [Fact(DisplayName = "001_RetrieveById_ArgumentOutRange_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveById_ArgumentOutRange_NOK()
        {
            Assert.Throws<FaultException>(() => 
            {
                var result = CallService((IBsGfxeService x) => x.RetrieveById(Constants.Invalid_Primary_Key));                
            });
        }

        [Fact(DisplayName = "002_RetrieveById_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveById_OK()
        {
            Assert.NotEmpty(MockCollections);
            int id = MockCollections.FirstOrDefault().Id;
            var result = CallService((IBsGfxeService x) => x.RetrieveById(id));

            Assert.NotNull(result);
            Assert.True(result.Id == id);
        }  

        [Fact(DisplayName = "003_RetrieveAll_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveAll_OK()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
        }              

        [Fact(DisplayName = "004_RetrieveByExpression_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveByExpression_OK()
        {
            Assert.NotEmpty(MockCollections);

            var item = MockCollections.First();

            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => item.PyCode == x.PyCode);
            var expressionNode = expression.ToExpressionNode();

            var result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.Equal(MockCollections.Count(), result.Count());            
        }

        [Fact(DisplayName = "005_RetrieveByExpression_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveByExpression_NullExpression_FaultException_NOK()
        {
            Assert.Throws<FaultException>(() =>
            {
                var result = CallService((IBsGfxeService x) => x.Retrieve(null));            
            });
        }

        [Fact(DisplayName = "006_RetrieveByExpression_InheritanceProperty_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void TestMethod_Call_Repository_Inheritance_InvalidCastException_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = (BsGfxeDTO x) => x.Id == 3;

            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
            Assert.Throws<FaultException>(() =>
            {
                var result = ServiceHandler.CallService((IBsGfxeService x) => x.Retrieve(predicateExpressionNode));
                Assert.NotNull(result);
                Assert.NotEmpty(result);
            });
        }
        #endregion

        #region Contains
        [Fact(DisplayName = "001_ContainsByEntity_OK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByEntity_OK_TestMethod()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            var item = result.FirstOrDefault();
            
            var exists = CallService((IBsGfxeService x) => x.Contains(item));
            Assert.True(exists);
        }

        [Fact(DisplayName = "002_ContainsByExpression_ExcludeKey_OK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByExpression_ExcludeKey_OK_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Contains(expressionNode));
            Assert.True(result);          
        }

        [Fact(DisplayName = "003_ContainsByExpression_IncludeKey_NOK")]
        [Trait(TraitName, "Contains")]
        public void ContainsByExpression_NOK_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();
            if (HisConfigurationManager.Configuration.IsDistributed)
            {
                Assert.Throws<FaultException>(() =>
                {
                    var result = CallService((IBsGfxeService x) => x.Contains(expressionNode));
                });

            }
            else
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    var result = CallService((IBsGfxeService x) => x.Contains(expressionNode));
                });

            }
        }
        #endregion

        #region Count
        [Fact(DisplayName="001_Count_OK")]
        [Trait(TraitName, "Count")]        
        public void Count_TestMethod()
        {
            var result = CallService((IBsGfxeService x) => x.Count());
            Assert.NotNull(result);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "002_CountByExpression_ExcludeKey_OK")]
        [Trait(TraitName, "Count")]
        public void CountByExpression_ExcludeKey_OK_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Count(expressionNode));
            Assert.NotNull(result);
            Assert.True(result > 0);

            expression = ((BsGfxeDTO x) => x.PyCode == "CSFYXE");
            expressionNode = expression.ToExpressionNode();
            result = CallService((IBsGfxeService x) => x.Count(expressionNode));
            Assert.NotNull(result);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "003_CountByExpression_IncludeKey_NOK")]
        [Trait(TraitName, "Count")]
        public void CountByExpression_IncludeKey_NOK_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();

            if (HisConfigurationManager.Configuration.IsDistributed)
            {
                Assert.Throws<FaultException>(() =>
                {
                    var result = CallService((IBsGfxeService x) => x.Count(expressionNode));
                });
            }
            else
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    var result = CallService((IBsGfxeService x) => x.Count(expressionNode));
                });

            }
        }
        #endregion

        #region Create
        [Fact(DisplayName = "001_Create_OK")]
        [Trait(TraitName, "Create")]
        public void Create_TestMethod()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);

            var newItem = result.FirstOrDefault();
            newItem.Code = "99";
            newItem.Name = "测试费用限额";
            newItem.PyCode = "CSFYXE";
            newItem.WbCode = "CCCCCC";
            newItem.IsActive = false;
            newItem.IconIndex = Constants.To_Be_Delete_Records;
            newItem = CallService((IBsGfxeService x) => x.Create(newItem));
            
            Assert.NotNull(newItem);
            Assert.True(newItem.Id > 0);

            CallService((IBsGfxeService x) => x.RetrieveById(newItem.Id));
        }
        #endregion

        #region Update
        [Fact(DisplayName = "001_Update_OK")]
        [Trait(TraitName, "Update")]
        public void Update_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);

            var itemToBeUpdated = result.FirstOrDefault();            

            string code = "1000";

            itemToBeUpdated.Code = code;
            itemToBeUpdated.Name = "测试更新";
            itemToBeUpdated.PyCode = "CSGX";
            itemToBeUpdated.WbCode = "CCCC";
            itemToBeUpdated.IsActive = true;
            CallService((IBsGfxeService x) => x.Update(itemToBeUpdated));

            var updatedItem = CallService((IBsGfxeService x) => x.RetrieveById(itemToBeUpdated.Id));
            Assert.NotNull(updatedItem);
            Assert.True(updatedItem.Code == code);
        }

        [Fact(DisplayName = "002_UpdateAll_OK")]
        [Trait(TraitName, "Update")]
        public void UpdateAll_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            Assert.NotNull(result);
            Assert.NotEmpty(result);
            string name = "TESTING DATA";

            foreach (var item in result)
            {
                item.Name = name;
            }

            CallService((IBsGfxeService x) => x.Update(result));
            result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            foreach (var item in result)
            {
                Assert.Equal(name, item.Name);
            }
        }
        #endregion        
    }
}
