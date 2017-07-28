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
using HisPlus.Infrastructure.Configuration;
using FluentAssertions;
using HisPlus.Infrastructure.Exceptions;
using HisPlus.UnitTesting.Common;

namespace HisPlus.UnitTesting.Service.BS
{
    public class BsGfxeServiceUnitTests : UnitTestBase<BsGfxeDTO>, IClassFixture<BsGfxeServiceTestsFixture>
    {
        private const string TraitName = "BSGfxeServiceUnitTests";        

        #region Retrieve

        [Fact(DisplayName = "Retrieve_By_Id_Argument_Out_Range_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void Retrieve_By_Id_Argument_Out_Range_NOK()
        {
            Action retrieveById = () => CallService((IBsGfxeService x) => x.RetrieveById(Constants.Invalid_Primary_Key));            
            retrieveById.ShouldThrow<HisPlusException>();
        }

        [Fact(DisplayName = "Retrieve_By_Id_OK")]
        [Trait(TraitName, "Retrieve")]
        public void Retrieve_By_Id_OK()
        {
            DataSource.Should().NotBeNullOrEmpty();

            int id = DataSource.FirstOrDefault().Id;
            var result = CallService((IBsGfxeService x) => x.RetrieveById(id));

            result.Should().NotBeNull();
            result.Id.Should().Be(id);
        }  

        [Fact(DisplayName = "Retrieve_All_OK")]
        [Trait(TraitName, "Retrieve")]
        public void RetrieveAll_OK()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            result.Should().NotBeNullOrEmpty();
        }              

        [Fact(DisplayName = "Retrieve_By_Expression_OK")]
        [Trait(TraitName, "Retrieve")]
        public void Retrieve_By_Expression_OK()
        {
            DataSource.Should().NotBeNullOrEmpty();

            var item = DataSource.First();
            
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => item.PyCode == x.PyCode);
            var expressionNode = expression.ToExpressionNode();

            var result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            result.Should().NotBeNullOrEmpty();
            result.Count().Should().Be(DataSource.Count());            
        }

        [Fact(DisplayName = "Retrieve_By_Expression_With_Null_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void Retrieve_By_Expression_With_Null_NOK()
        {         
            Action retrieve = () => CallService((IBsGfxeService x) => x.Retrieve(null));
            retrieve.ShouldThrow<HisPlusException>();
        }

        [Fact(DisplayName = "Retrieve_By_Expression_Include_Key_NOK")]
        [Trait(TraitName, "Retrieve")]
        public void Retrieve_By_Expression_Include_Key_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = (BsGfxeDTO x) => x.Id == 3;
            ExpressionNode predicateExpressionNode = expression.ToExpressionNode();
            Action retrieve = () => CallService((IBsGfxeService x) => x.Retrieve(predicateExpressionNode));
            
            retrieve.ShouldThrow<HisPlusException>();
        }

        #endregion

        #region Contains

        [Fact(DisplayName = "Contains_By_Entity_OK")]
        [Trait(TraitName, "Contains")]
        public void Contains_By_Entity_OK()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            result.Should().NotBeNullOrEmpty();

            var item = result.FirstOrDefault();            
            var exists = CallService((IBsGfxeService x) => x.Contains(item));
            exists.Should().BeTrue();            
        }

        [Fact(DisplayName = "Contains_By_Expression_OK")]
        [Trait(TraitName, "Contains")]
        public void Contains_By_Expression_OK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Contains(expressionNode));
            result.Should().BeTrue();            
        }

        [Fact(DisplayName = "Contains_By_Expression_And_Include_Key_NOK")]
        [Trait(TraitName, "Contains")]
        public void Contains_By_Expression_And_Include_Key_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();
            Action action = () => CallService((IBsGfxeService x) => x.Contains(expressionNode));
            action.ShouldThrow<HisPlusException>();            
        }

        #endregion

        #region Count

        [Fact(DisplayName="Count_OK")]
        [Trait(TraitName, "Count")]
        public void Count_OK()
        {
            var result = CallService((IBsGfxeService x) => x.Count());
            result.Should().BeGreaterThan(0);
        }

        [Fact(DisplayName = "Count_By_Expression_OK")]
        [Trait(TraitName, "Count")]
        public void Count_By_Expression_OK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IsActive);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Count(expressionNode));
            result.Should().BeGreaterThan(0);

            expression = ((BsGfxeDTO x) => x.PyCode == "CSFYXE");
            expressionNode = expression.ToExpressionNode();
            result = CallService((IBsGfxeService x) => x.Count(expressionNode));
            result.Should().BeGreaterThan(0);
        }

        [Fact(DisplayName = "Count_By_Expression_And_Include_Key_NOK")]
        [Trait(TraitName, "Count")]
        public void Count_By_Expression_And_Include_Key_NOK()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.Id > 0);
            var expressionNode = expression.ToExpressionNode();

            Action countAction = () => CallService((IBsGfxeService x) => x.Count(expressionNode));
            countAction.ShouldThrow<HisPlusException>();
        }

        #endregion

        #region Create

        [Fact(DisplayName = "Create_OK")]
        [Trait(TraitName, "Create")]
        public void Create_OK()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            result.Should().NotBeNullOrEmpty();

            var newItem = result.FirstOrDefault();
            newItem.Id = 0;
            newItem.Code = "99";
            newItem.Name = "测试费用限额";
            newItem.PyCode = "CSFYXE";
            newItem.WbCode = "CCCCCC";
            newItem.IsActive = false;
            newItem.IconIndex = Constants.To_Be_Delete_Records;
            
            newItem.Id.Should().BeLessOrEqualTo(0);

            newItem = CallService((IBsGfxeService x) => x.Create(newItem));

            newItem.Should().NotBeNull();
            newItem.Id.Should().BeGreaterThan(0);

            var result1 = CallService((IBsGfxeService x) => x.RetrieveById(newItem.Id));
            result1.Should().NotBeNull();
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
            result.Should().NotBeNullOrEmpty();

            var itemToBeUpdated = result.FirstOrDefault();

            string code = "1000";

            itemToBeUpdated.Code = code;
            itemToBeUpdated.Name = "测试更新";
            itemToBeUpdated.PyCode = "CSGX";
            itemToBeUpdated.WbCode = "CCCC";
            itemToBeUpdated.IsActive = true;
            CallService((IBsGfxeService x) => x.Update(itemToBeUpdated));

            var updatedItem = CallService((IBsGfxeService x) => x.RetrieveById(itemToBeUpdated.Id));
            
            updatedItem.Should().NotBeNull();
            updatedItem.Code.Should().Be(code);
        }

        [Fact(DisplayName = "002_UpdateAll_OK")]
        [Trait(TraitName, "Update")]
        public void UpdateAll_TestMethod()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();
            var result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            result.Should().NotBeNullOrEmpty();

            string name = "TESTING DATA";

            foreach (var item in result)
            {
                item.Name = name;
            }

            CallService((IBsGfxeService x) => x.Update(result));
            result = CallService((IBsGfxeService x) => x.Retrieve(expressionNode));
            foreach (var item in result)
            {
                item.Name.Should().Be(name);
            }
        }

        #endregion
    }
}
