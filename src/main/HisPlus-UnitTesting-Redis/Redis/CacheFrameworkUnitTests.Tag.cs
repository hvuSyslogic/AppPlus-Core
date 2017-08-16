using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.DependencyInjection;
using HisPlus.UnitTesting.Common;
using HisPlus.Redis;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests : TestBase
    {
        [Fact]
        public void AddTagsToHashField_Test() 
        {
            string[] tags = new[] { "AddTagsToHashField_Test-1", "AddTagsToHashField_Test-2" };
            redisContext.Cache.AddTagsToHashField<BsLocationDTO>(856, tags);

            redisContext.Cache.GetAllTags().Should().Contain(tags[0]);
        }

    }
}
