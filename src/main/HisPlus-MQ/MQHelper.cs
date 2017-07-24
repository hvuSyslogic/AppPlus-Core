using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.MQ
{
    public class MQHelper
    {
        public void Publish(Message msg)
        {
            IBus bus = BusBuilder.CreateMessageBus();

            try
            {
                bus.Publish(msg, x => x.WithTopic(msg.Router));
            }
            catch (EasyNetQException ex)
            {
                //TODO: Logger
                throw;
            }
            finally
            {
                bus.Dispose();
            }                       
        }

        public void Subscribe(Message msg, IMessageProcessor processor)
        {
            IBus bus = BusBuilder.CreateMessageBus();

            try
            {
                bus.Subscribe<Message>(msg.Router, message => processor.Process(message), configure => configure.WithTopic(msg.Router));
            }
            catch (EasyNetQException ex)
            {
                //TODO: Logger
                throw;
            }
            finally
            {
                bus.Dispose();
            }
        }
    }
}
