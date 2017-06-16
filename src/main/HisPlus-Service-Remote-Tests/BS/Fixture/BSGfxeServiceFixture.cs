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
using HisPlus.Contracts.Messages.BS;
using HisPlus.Contracts.Services.BS;

namespace AppPlus.His.Services.Tests.BS.Fixture
{
    public class BSGfxeServiceFixture : TestBase, IDisposable
    {
        const int RECORD_COUNT = 20;

        public BSGfxeServiceFixture()
        {
            PrepareData(RECORD_COUNT);
        }

        public void PrepareData(int rowCount)
        {
            List<BsGfxeDto> rows = new List<BsGfxeDto>();

            for (short i = 0; i < rowCount; i++)
            {
                string order = i.ToString();

                BsGfxeDto row = new BsGfxeDto()
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

            var result = CallService((IBSGfxeService x) => x.Create(rows));

            Assert.NotNull(result);
            Assert.Equal(rowCount, result.Count());
        }


        public void Clean()
        {
            Expression<Func<BsGfxeDto, bool>> expression = ((BsGfxeDto x) => x.F4 == Constants.FLAG_TO_TEST);
            var expressionNode = expression.ToExpressionNode();

            var effectedRows = ServiceHandler.CallService((IBSGfxeService x) => x.Delete(expressionNode));

            Assert.True(effectedRows >= RECORD_COUNT);
        }

        public void Dispose()
        {
            Clean();
        }
    }

}
