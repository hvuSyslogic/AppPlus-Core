using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Config
{
    public interface IConnectionString
    {
        string Name { get; }

        string Value { get; set; }
    }
}
