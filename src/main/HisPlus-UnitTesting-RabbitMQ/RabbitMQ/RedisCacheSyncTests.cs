using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.UnitTesting.RabbitMQ
{
    public class RedisCacheSyncTests 
    {
        private const string HostName = "localhost";
        private string CacheKey = "BsGfxe";
        

        [Fact]
        public void Retrieve_From_Cache()
        {
            PublishMessage(CacheKey, "aaaaaaaaaaaa");
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
