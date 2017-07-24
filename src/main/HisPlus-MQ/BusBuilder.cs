using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.MQ
{
    public class BusBuilder
    {
        public static IBus CreateMessageBus()
        {
            string connectionString = "host=localhost:5672;virtualHost=Dragon.Luo;username=dragon.luo;password=Oracle12c";

            return RabbitHutch.CreateBus(connectionString);
        }
    }
}
