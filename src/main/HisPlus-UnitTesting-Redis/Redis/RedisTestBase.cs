using HisPlus.Contract.Messages;
using HisPlus.Infrastructure.DependencyInjection;
using HisPlus.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using HisPlus.UnitTesting.Common;
using HisPlus.Contract.Services;
using HisPlus.Client;

namespace HisPlus.UnitTesting.Redis
{
    public class RedisTestFixture
    {
        public RedisTestFixture()
        {
            RedisTestBase.AllUsers = ServiceHandler.CallService((IBsUserService x) => x.GetAll());
            RedisTestBase.AllUsers.Should().NotBeNullOrEmpty();

            RedisTestBase.TheFirstUser = RedisTestBase.AllUsers.First();
            RedisTestBase.TheLastUser = RedisTestBase.AllUsers.Last();
            RedisTestBase.TheFirstUser.Should().NotBeNull();
            RedisTestBase.TheLastUser.Should().NotBeNull();
        }
    }     

    public class RedisTestBase : TestBase
    {
        protected static readonly IRedisContext RedisContext = IoCManager.Container.Resolve<IRedisContext>();

        public static BsUserDTO TheFirstUser { get; set; }

        public static BsUserDTO TheLastUser { get; set; }

        public static IEnumerable<BsUserDTO> AllUsers { get; set; }
    }
}
