using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
