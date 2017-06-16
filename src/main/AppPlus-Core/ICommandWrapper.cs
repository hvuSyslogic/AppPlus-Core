using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppPlus.Core
{
    public interface ICommandWrapper : IDisposable
    {        
        void Execute(Action<IUnitOfWork> unitOfWork, TransactionOption option = TransactionOption.Default);

        TResult Execute<TResult>(Func<IUnitOfWork, TResult> unitOfWork, TransactionOption option = TransactionOption.Default);   
    }
}
