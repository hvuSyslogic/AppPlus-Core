﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Config
{
    public interface ICacheProvider
    {
        IConnectionString ConnectionString { get; }

        ICustomizedKey CustomizedKey { get; }
    }
}
