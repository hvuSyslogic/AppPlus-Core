using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Cache
{
    public class RedisCacheOptions
    {
        public RedisCacheOptions(string connectionString, int databaseId, string keyFormat)
        {
            this.ConnectionString = connectionString;
            this.DatabaseId = databaseId;
            this.KeyFormat = keyFormat;
        }

        public string ConnectionString { get; set; }

        public int DatabaseId { get; set; }

        public string KeyFormat { get; set; }
    }
}
