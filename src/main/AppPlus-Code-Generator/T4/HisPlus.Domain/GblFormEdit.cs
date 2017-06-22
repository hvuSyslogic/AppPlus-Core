using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblFormEdit : EntityBase<int>
    {
        public GblFormEdit()
        {    
        }

        public string FormName { get; set; }
        public string FiledName { get; set; }
        public bool? IsAdd { get; set; }
        public string ToolTip { get; set; }
        public bool? IsExcept { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
