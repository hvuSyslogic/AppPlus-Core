using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisPlus.Core
{
    public enum TransactionOption
    {
        Default = 0,
        TransactionScope = 1,
        DBTransaction = 2,
    }
}
