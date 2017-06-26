using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core.EntityFramework
{
    public class UnitOfWorkSettings
    {
        private static UnitOfWorkSettings _default = new UnitOfWorkSettings();

        public UnitOfWorkSettings() 
        {
            TransactionScope = TransactionOption.Default;
        }

        public TransactionOption TransactionScope { get; set; }
        
        public static UnitOfWorkSettings Default
        {
            get { return _default; }
            set { _default = value; }
        }
    }
}
