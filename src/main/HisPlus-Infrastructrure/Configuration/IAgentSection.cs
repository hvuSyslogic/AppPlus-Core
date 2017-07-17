﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public interface IAgentSection
    {
        IServiceAgentNode ServiceAgent { get; }

        ICredentialsNode Credentials { get; }
    }
}
