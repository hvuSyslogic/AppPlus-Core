using HisPlus.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Serialize.Linq.Nodes;
using Serialize.Linq.Extensions;
using Xunit;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;

namespace HisPlus.Service.UnitTests.Common
{
    public class GblRoleServiceTestsFixture : TestsFixtureBase<GblRoleDTO>
    {
        const int RECORD_COUNT = 20;

        public override void MockData()
        {
            List<GblRoleDTO> rows = new List<GblRoleDTO>();

            for (short i = 0; i < RECORD_COUNT; i++)
            {
                string order = i.ToString();

                GblRoleDTO row = new GblRoleDTO()
                {
                    Code = "Code" + i.ToString(),
                    Name = "测试" + i.ToString(),
                    IsActive = true,
                    OrderBy = i,
                    IconIndex = Constants.FLAG_TO_DELETE
                };
                rows.Add(row);
            }

            var result = CallService((IGblRoleService x) => x.Create(rows));

            Assert.NotNull(result);
            Assert.Equal(RECORD_COUNT, result.Count());
        }

        public override void Clean()
        {
            Expression<Func<GblRoleDTO, bool>> expression = ((GblRoleDTO x) => x.IconIndex == Constants.FLAG_TO_DELETE);
            var expressionNode = expression.ToExpressionNode();

            var effectedRows = CallService((IGblRoleService x) => x.Delete(expressionNode));

            Assert.True(effectedRows == RECORD_COUNT);
        }
    }
}
