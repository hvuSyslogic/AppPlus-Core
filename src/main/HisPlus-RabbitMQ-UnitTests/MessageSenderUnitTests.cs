using HisPlus.MQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.RabbitMQ.UnitTests
{    
    public partial class MessageSenderUnitTests
    {
        const string TraitName = "MessageSenderUnitTests";
        const string TraitValue = "MessageQueue";

        [Fact]
        public void Message_Send_Test()
        {
            Message msg = new Message() 
            {
                Id = "1111",
                Title = "Test",
                Router = "testQueue",
                Body = "Hello World!"
            };

            MQHelper mq = new MQHelper();
            mq.Publish(msg);
        }
    }
}
