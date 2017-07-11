using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuDocRegType : EntityBase<int>
    {
        public OuDocRegType()
        {    
        }

        public System.DateTime RegDate { get; set; }
        public int? WeekPlanId { get; set; }
        public int DoctorId { get; set; }
        public int RegTypeId { get; set; }
        public int TimeSpanId { get; set; }
        public int LocationId { get; set; }
        public int? DiagRoomId { get; set; }
        public short? LimitNum { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public int? Iscancel { get; set; }
        public int? Lastlimitnum { get; set; }
    }
}
