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
    public class GblRoleServiceTestsFixture : ClassFixtureBase<GblRoleDTO>
    {
        public GblRoleServiceTestsFixture()
        {
            BuildDataSource();
        }

        public override void BuildDataSource()
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

            var result = CallService((IGblRoleService x) => x.AddBatch(rows));
            result.Should().NotBeNull();
            result.Count().Should().Be(Constants.Mock_Record_Counts);            
        }

        public override void CleanDataSource()
        {
            Expression<Func<GblRoleDTO, bool>> expression = ((GblRoleDTO x) => x.IconIndex == Constants.To_Be_Delete_Records);
            var expressionNode = expression.ToExpressionNode();

            CallService((IGblRoleService x) => x.DeleteBy(expressionNode)).Should().Be(Constants.Mock_Record_Counts);
        }
    }
}
