using AppPlus.Core.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPlus.Core
{
    public interface ICommandWrapper : IDisposable
    {
        void Execute(Action<IUnitOfWork> unitOfWork, UnitOfWorkSettings unitOfWorkSettings = null);

        TResult Execute<TResult>(Func<IUnitOfWork, TResult> unitOfWork, UnitOfWorkSettings unitOfWorkSettings = null);   
    }
}
