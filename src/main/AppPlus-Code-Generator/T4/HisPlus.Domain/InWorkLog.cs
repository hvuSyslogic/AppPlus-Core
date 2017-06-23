using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InWorkLog : EntityBase<int>
    {
        public InWorkLog()
        {    
        }

        public int? LocationId { get; set; }
        public decimal? BedSum { get; set; }
        public decimal? OverBedSum { get; set; }
        public string Standard { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? OperId { get; set; }
        public short? LastNum { get; set; }
        public short? StartNum { get; set; }
        public short? InHospital { get; set; }
        public short? InLocation { get; set; }
        public short? OutLocation { get; set; }
        public short? OutHospital { get; set; }
        public short? Dead { get; set; }
        public short? NowNum { get; set; }
        public short? OverNum { get; set; }
        public short? CompanyNum { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? Days { get; set; }
        public int? Danger { get; set; }
        public int? Heavy { get; set; }
        public int? Acute { get; set; }
    }
}
