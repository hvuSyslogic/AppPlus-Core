﻿using System;
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
        private const string TraitName = "CacheFrameworkUnitTests";
        private const string TraitValue = "CacheFramework.Redis";

        private static readonly IRedisContext redisContext = IoCManager.Container.Resolve<IRedisContext>();
    }
}
