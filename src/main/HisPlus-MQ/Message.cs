using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.MQ
{
    public class Message
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Router { get; set; }
    }
}
