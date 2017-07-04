using AppPlus.Client;
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

namespace HisPlus.Service.Remote.Tests.Common
{
    public class BsGfxeServiceTestsFixture : TestsFixtureBase<BsGfxeDTO>
    {
        const int RECORD_COUNT = 20;

        public override void MockData()
        {
            List<BsGfxeDTO> rows = new List<BsGfxeDTO>();

            for (short i = 0; i < RECORD_COUNT; i++)
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
                    IconIndex = Constants.FLAG_TO_DELETE
                };
                rows.Add(row);
            }

            var result = CallService((IBsGfxeService x) => x.Create(rows));

            Assert.NotNull(result);
            Assert.Equal(RECORD_COUNT, result.Count());
        }

        public override void Clean()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.IconIndex == Constants.FLAG_TO_DELETE);
            var expressionNode = expression.ToExpressionNode();

            var effectedRows = CallService((IBsGfxeService x) => x.Delete(expressionNode));

            //Assert.True(effectedRows == RECORD_COUNT);
        }
    }
}
