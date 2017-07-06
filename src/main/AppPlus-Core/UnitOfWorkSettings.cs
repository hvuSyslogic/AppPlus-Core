using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core
{
    public class UnitOfWorkSettings
    {
        public string StorageName { get; set; }
        public bool EnableCommit { get; set; }
        public bool RollbackOnDispose { get; set; }
        public bool ThrowIfNestedUnitOfWork { get; set; }

        public UnitOfWorkSettings()
        {
            StorageName = "Default";
            EnableCommit = false;
            RollbackOnDispose = false;
            ThrowIfNestedUnitOfWork = false;
        }

        private static UnitOfWorkSettings _default = new UnitOfWorkSettings();
        public static UnitOfWorkSettings Default
        {
            get { return _default; }
            set { _default = value; }
        }
    }
}
