using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Config
{
    public interface IHostConfig
    {
        string Name { get; }

        int Port { get; }

        ICredentialsConfig Credentials { get; }
    }
}