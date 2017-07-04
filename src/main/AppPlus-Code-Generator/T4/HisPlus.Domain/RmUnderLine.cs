using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RmUnderLine : EntityBase<int>
    {
        public RmUnderLine()
        {    
        }

        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public decimal UnderLine { get; set; }
        public decimal UperLine { get; set; }
        public decimal Normal { get; set; }
        public bool? IsActive { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsStop { get; set; }
    }
}
