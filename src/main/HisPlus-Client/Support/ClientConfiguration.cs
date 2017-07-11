using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisPlus.Client.Support
{
    public class ClientConfiguration
    {
        public ClientConfiguration()
        {
            ContentType = "application/json";
            Accept = "application/json";
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string BaseUri { get; set; }

        public string ContentType { get; set; }

        public string Accept { get; set; }

        public bool RequrieSession { get; set; }

        public ISerializerAdapter OutBoundSerializerAdapter { get; set; }

        public ISerializerAdapter InBoundSerializerAdapter { get; set; }
    }
}
