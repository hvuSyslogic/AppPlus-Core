using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsOuMergeFee : EntityBase<int>
    {
        public BsOuMergeFee()
        {    
        }

        public int PatTypeId { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
