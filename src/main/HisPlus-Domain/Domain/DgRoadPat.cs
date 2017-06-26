using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class DgRoadPat : EntityBase<int>
    {
        public DgRoadPat()
        {    
        }

        public int? HospId { get; set; }
        public int RoadId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsChk { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public int? ChkOperId { get; set; }
    }
}
