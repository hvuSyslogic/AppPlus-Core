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
        bool IsDistributed { get; }

        IAgentSection AgentSection { get; }

        ILocalSection LocalSection { get; }        
    }
}
