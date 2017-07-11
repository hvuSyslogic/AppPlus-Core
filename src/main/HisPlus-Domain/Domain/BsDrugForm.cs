using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsDrugForm : EntityBase<int>
    {
        public BsDrugForm()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsReject { get; set; }
        public bool IsSave { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public bool? IsTcmForm { get; set; }
    }
}
