﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using AppPlus.Infrastructure.Contract.Messages;

namespace AppPlus.Core
{
    public interface IUnitOfWork : IDisposable
    {
        #region Properties

        DbContext Session { get; set; }

        bool IsConnectionOpen { get; }

        #endregion        
    }
}