using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.UnitTesting.Common
{
    [TestCaseOrderer(
    CustomTestCaseOrderer.TypeName,
    CustomTestCaseOrderer.AssembyName)]
    public class TestClassBase
    {
        protected static int I;

        protected void AssertTestName(string testName)
        {
            var type = GetType();
            var queue = CustomTestCaseOrderer.QueuedTests[type.FullName];
            string dequeuedName;
            var result = queue.TryDequeue(out dequeuedName);
            Assert.True(result);
            Assert.Equal(testName, dequeuedName);
        }
    }
}
