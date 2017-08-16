using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HisPlus.Infrastructure.Extensions;
using FluentAssertions;
using CachingFramework.Redis;
using HisPlus.Redis;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests
    {
        [Fact(DisplayName = "SetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void SetHashed_Test_OK()
        {
            var users = CallService((IBsUserService x) => x.GetAll()).ToList();
            users.ForEach(x => SetHashedToCache(redisContext, x, new[] { string.Format("BsUserDTO:Code:{0}", x.Code), string.Format("BsUserDTO:Name:{0}", x.Name) }));
        }        

        [Fact]
        public void GetAllTags()
        {
            var tags = redisContext.Cache.GetAllTags().ToList();
            tags.Should().NotBeNullOrEmpty();
        }
        
        [Fact]
        public void Get()
        {
            var keys = redisContext.Cache.GetKeysByTagA(new[] { string.Format("BsUserDTO:Code:999999", ""), "BsUserDTO:Name:蔡华琼" }).ToList();
            keys.Should().NotBeNullOrEmpty();

            var first = redisContext.Cache.GetHashed<BsUserDTO>(keys.First());
            first.Should().NotBeNull();
            var last = redisContext.Cache.GetHashed<BsUserDTO>(keys.Last());
            last.Should().NotBeNull();
        }

        [Fact]
        public void GetHashed_Test()
        {
            var keys = redisContext.Cache.GetKeysByTag(new[] { "BsUserDTO:Code:999999" });
            keys.Should().NotBeNullOrEmpty();

            var user = redisContext.Cache.GetHashed<BsUserDTO>(9);            

            //var user = redisContext.Cache.GetObjectsByTag<BsUserDTO>("9").ToList();
            //user.Should().NotBeNullOrEmpty();
        }

        private void SetHashedToCache<T>(IRedisContext context, T o, string[] tags) where T : DtoBase<int>
        {
            context.Cache.SetHashed(o.Id, o, tags);
        }
    }
}
