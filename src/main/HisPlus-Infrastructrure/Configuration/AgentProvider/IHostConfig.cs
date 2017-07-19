using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public interface IHostConfig
    {
        string Name { get; }

        int Port { get; }

        ICredentialsConfig Credentials { get; }
    }
}