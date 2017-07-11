using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using Xunit;

namespace HisPlus.RabbitMQTests
{    
    public partial class Send
    {
        private const string HostName = "localhost";

        public void SendMessage(string queueName)
        {
            var connectionFactory = new ConnectionFactory()
            {
                HostName = HostName
            };

            using(var connection = connectionFactory.CreateConnection()) 
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: queueName,
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);

                    string message = "Hello World .... !";
                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(exchange: "",
                                         routingKey: "hello",
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine(" [x] Sent {0}", message);
                }
            }
        }

        [Fact]
        public void TestSendMessage()
        {
            string queueName = "testQueue";

            SendMessage(queueName);
        }
    }
}
