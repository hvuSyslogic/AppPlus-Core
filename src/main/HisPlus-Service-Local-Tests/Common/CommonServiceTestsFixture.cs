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

namespace HisPlus.Service.Local.Tests.Common
{
    public class CommonServiceTestsFixture : TestBase, IDisposable
    {
        const int RECORD_COUNT = 20;

        public CommonServiceTestsFixture()
        {
            PrepareData(RECORD_COUNT);
        }

        public void PrepareData(int rowCount)
        {
            List<BsGfxeDTO> rows = new List<BsGfxeDTO>();

            for (short i = 0; i < rowCount; i++)
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
                    F4 = Constants.FLAG_TO_TEST
                };
                rows.Add(row);
            }

            var result = CallService((IBsGfxeService x) => x.Create(rows));

            Assert.NotNull(result);
            Assert.Equal(rowCount, result.Count());
        }

        public void Clean()
        {
            Expression<Func<BsGfxeDTO, bool>> expression = ((BsGfxeDTO x) => x.F4 == Constants.FLAG_TO_TEST);
            var expressionNode = expression.ToExpressionNode();

            var effectedRows = CallService((IBsGfxeService x) => x.Delete(expressionNode));

            //Assert.True(effectedRows >= RECORD_COUNT);
        }

        public void Dispose()
        {
            Clean();
        }
    }
}
