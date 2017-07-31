using HisPlus.Contract.Messages;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Contract.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.UnitTesting.Redis
{
    public partial class CacheFrameworkUnitTests
    {
        [Fact(DisplayName = "SetHashed_Test_OK")]
        [Trait(TraitName, TraitValue)]
        public void SetHashed_Test_OK()
        {
            CallService((IBsLocationService x) => x.RetrieveAll()).ToList().ForEach(x => SetHashedToCache(redisContext, x));

            CallService((IBsItemService x) => x.RetrieveAll()).ToList().ForEach(x => SetHashedToCache(redisContext, x));
        }

        private void SetHashedToCache<T>(IRedisContext context, T o) where T : DtoBase<int>
        {
            context.Cache.SetHashed(o.Id, o);
        }      
    }
}
