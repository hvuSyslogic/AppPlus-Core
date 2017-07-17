using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisPlus.Core
{
    public enum TransactionOption
    {
        SelfTransaction = 0,
        DbTransaction = 1,
        TransactionScope = 2,
    }
}
