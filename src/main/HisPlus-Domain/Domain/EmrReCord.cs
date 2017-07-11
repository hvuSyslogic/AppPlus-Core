using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class EmrReCord : EntityBase<int>
    {
        public EmrReCord()
        {    
        }

        public System.DateTime? Intime { get; set; }
        public System.DateTime? Outtime { get; set; }
        public int? Hospid { get; set; }
        public System.DateTime? Modifytime { get; set; }
        public string Reccontent { get; set; }
        public System.DateTime? Firstretime { get; set; }
        public int? Inemrid { get; set; }
        public bool? IsActive { get; set; }
        public bool? Ismodify { get; set; }
        public int? LocationId { get; set; }
    }
}
