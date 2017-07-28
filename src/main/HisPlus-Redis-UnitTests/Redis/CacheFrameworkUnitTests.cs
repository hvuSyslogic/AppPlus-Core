using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using HisPlus.UnitTesting.Common;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests : TestBase
    {
        private static readonly IRedisContext redisContext = IoCManager.Container.Resolve<IRedisContext>();
        private const string TraitName = "CacheFrameworkUnitTests";
        private const string TraitValue = "CacheFramework.Redis";
    }
}
