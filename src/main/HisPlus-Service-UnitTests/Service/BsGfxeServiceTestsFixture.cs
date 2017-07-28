using HisPlus.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using FluentAssertions;
using Xunit;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.UnitTesting.Common;

namespace HisPlus.UnitTesting.Service
{
    public class BsGfxeServiceTestsFixture : ClassFixtureBase<BsGfxeDTO>
    {
        public BsGfxeServiceTestsFixture()
        {
            BuildDataSource();
        }

        public override void BuildDataSource()
        {
            List<BsGfxeDTO> rows = new List<BsGfxeDTO>();

            for (short i = 0; i < Constants.Mock_Record_Counts; i++)
            {
                string order = i.ToString();

                BsGfxeDTO row = new BsGfxeDTO()
                {
                    Code = string.Concat("100", order),
                    Name = string.Concat("测试费用限额", "-", order),
                    PyCode = "CSFYXE",
                    WbCode = "CSFYXE",
                    OrderBy = i,
                    IsActive = true,
                    IconIndex = Constants.To_Be_Delete_Records
                };
                rows.Add(row);
            }

            DataSource = CallService((IBsGfxeService x) => x.Create(rows));
            DataSource.Should().NotBeNullOrEmpty();
            DataSource.Count().Should().Be(Constants.Mock_Record_Counts);            
        }

        public override void CleanDataSource()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();

            var effectedRows = CallService((IBsGfxeService x) => x.Delete(expressionNode));

            //Assert.True(effectedRows == RECORD_COUNT);
        }
    }
}
