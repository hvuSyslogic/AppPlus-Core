using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public interface ILocalProvider
    {
        IConnectionString ConnectionString { get; }

        IEnumerable<IInstallerConfig> Installers { get; }
    }
}
