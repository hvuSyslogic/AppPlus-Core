using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Config
{
    public interface ILocalProvider
    {
        IConnectionString ConnectionString { get; }

        IEnumerable<IInstallerConfig> Installers { get; }
    }
}
