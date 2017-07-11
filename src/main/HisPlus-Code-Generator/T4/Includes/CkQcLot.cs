using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkQcLot : EntityBase<int>
    {
        public CkQcLot()
        {    
        }

        public string Code { get; set; }
        public string SampleNum { get; set; }
        public int MachineId { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int CtrlId { get; set; }
    }
}
