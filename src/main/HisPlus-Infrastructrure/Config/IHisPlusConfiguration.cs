using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Nerdle.AutoConfig;

namespace HisPlus.Infrastructure.Config
{
    public interface IHisPlusConfiguration
    {
        ProviderType Provider { get; }

        IAgentProvider AgentProvider { get; }

        ILocalProvider LocalProvider { get; }

        ICacheProvider ClientCacheProvider { get; }
    }

    public class HisPlusConfiguration : IHisPlusConfiguration
    {
        public ProviderType Provider { get; private set; }

        public IAgentProvider AgentProvider { get; private set; }

        public ILocalProvider LocalProvider { get; private set; }

        public ICacheProvider ClientCacheProvider { get; private set; }
    }
}
