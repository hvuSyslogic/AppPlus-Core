using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public class MiddleWareSection : ConfigurationElement
    {
        [ConfigurationProperty("host", IsRequired = true, IsKey = true)]
        public string Host
        {
            get { return (string)base["host"]; }
            set { base["host"] = value; }
        }

        [ConfigurationProperty("port", IsRequired = true)]
        public int Port
        {
            get { return (int)base["port"]; }
            set { base["port"] = value; }
        }
    }
}
