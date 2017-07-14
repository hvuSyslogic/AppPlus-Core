using HisPlus.Core.Redis;
using HisPlus.Contract.Services;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using HisPlus.UnitTests.Common;

namespace HisPlus.Redis.UnitTests
{
    public class RedisCacheSyncUnitTests : TestBase
    {
        private const string HostName = "localhost";
        private string CacheKey = "BsGfxe";
        ICacheProvider cacheProvider = new CacheProvider(0);

        [Fact]
        public void Initialize_Redis_Cache()
        {            
            var locations = CallService((IBsLocationService x) => x.RetrieveAll());
            cacheProvider.StringSet("BsLocation", locations);

            var users = CallService((IBsUserService x) => x.RetrieveAll());
            cacheProvider.StringSet("BsUser", users);

            var result = CallService((IBsGfxeService x) => x.RetrieveAll());
            cacheProvider.StringSet(CacheKey, result);
        }

        [Fact]
        public void Update_Db_And_Publish_Message()
        {
            var result = CallService((IBsGfxeService x) => x.RetrieveAll());

            result.ToList().ForEach(x => x.IsActive = true);

            CallService((IBsGfxeService x) => x.Update(result));

            PublishMessage(CacheKey, result);
        }

        [Fact]
        public void Retrieve_From_Cache()
        {
            cacheProvider.StringGet(CacheKey);
        }
        public void PublishMessage(string queueName, object message)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = HostName
            };

            using (var connection = connectionFactory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

                    var jsonMsg = JsonConvert.SerializeObject(message);
                    var body = Encoding.UTF8.GetBytes(jsonMsg);
                    channel.BasicPublish(exchange: "",
                                         routingKey: queueName,
                                         basicProperties: null,
                                         body: body);
                }
            }
        }
    }
}
