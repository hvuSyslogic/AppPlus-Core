using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Nerdle.AutoConfig;

namespace HisPlus.Infrastructure.Configuration
{
    public interface IHisPlusConfiguration
    {
        ProviderType Provider { get; }

        IAgentProvider AgentProvider { get; }

        ILocalProvider LocalProvider { get; }

        ICacheProvider CacheProvider { get; }
    }
}
