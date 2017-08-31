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
using HisPlus.Infrastructure.Config;

namespace HisPlus.UnitTesting.Redis
{
    public class RedisTestFixture
    {
        public RedisTestFixture()
        {
            RedisTestBase.Users = ServiceHandler.CallService((IBsUserService x) => x.GetAll()).ToArray();
            RedisTestBase.Users.Should().NotBeNullOrEmpty();
            var theFirstUser = RedisTestBase.Users.First();
            var theSecondUser = RedisTestBase.Users.Last();
            theFirstUser.Should().NotBeNull();
            theSecondUser.Should().NotBeNull();

            RedisTestBase.TheFirstUser = theFirstUser;
            RedisTestBase.TheSecondUser = theSecondUser;
        }
    }     

    public class RedisTestBase : TestBase
    {
         
        static readonly IRedisContext _context = IoCManager.Container.Resolve<IRedisContext>();
        //protected static readonly IRedisContext RedisContext = new RedisContext("192.168.1.225:6379, connectRetry=10, abortConnect=false, allowAdmin=true");

        protected static CachingFramework.Redis.Contracts.Providers.ICacheProvider Cache
        {
            get { return _context.Cache; }
        }

        public static string[] UserKeys = new string[] { };

        public static BsUserDTO TheFirstUser { get; set; }

        public static BsUserDTO TheSecondUser { get; set; }

        public static BsUserDTO[] Users { get; set; }
    }
}
