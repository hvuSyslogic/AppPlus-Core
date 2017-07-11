using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public int? Days { get; set; }
        public int? Danger { get; set; }
        public int? Heavy { get; set; }
        public int? Acute { get; set; }
        public short? Second { get; set; }
        public short? Ops { get; set; }
        public short? ChildBirth { get; set; }
        public short? FirstNurse { get; set; }
        public short? Third { get; set; }
        public short? Diff { get; set; }
        public short? Other { get; set; }
    }
}
