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

namespace HisPlus.Service.UnitTests.Common
{
    public class GblRoleServiceTestsFixture : TestsFixtureBase<GblRoleDTO>
    {
        public override void MockData()
        {
            List<GblRoleDTO> rows = new List<GblRoleDTO>();

            for (short i = 0; i < Constants.Mock_Record_Counts; i++)
            {
                string order = i.ToString();

                GblRoleDTO row = new GblRoleDTO()
                {
                    Code = "Code" + i.ToString(),
                    Name = "测试" + i.ToString(),
                    IsActive = true,
                    OrderBy = i,
                    IconIndex = Constants.To_Be_Delete_Records
                };
                rows.Add(row);
            }

            var result = CallService((IGblRoleService x) => x.Create(rows));
            result.Should().NotBeNull();
            result.Count().Should().Be(Constants.Mock_Record_Counts);            
        }

        public override void Clean()
        {
            Expression<Func<GblRoleDTO, bool>> expression = ((GblRoleDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();

            CallService((IGblRoleService x) => x.Delete(expressionNode)).Should().Be(Constants.Mock_Record_Counts);
        }
    }
}
