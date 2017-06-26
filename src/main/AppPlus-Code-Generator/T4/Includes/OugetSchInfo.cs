using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OugetSchInfo : EntityBase<int>
    {
        public OugetSchInfo()
        {    
        }

        public int? ShiftId { get; set; }
        public int? ShiftType { get; set; }
        public System.DateTime? SchDate { get; set; }
        public decimal? SchFee { get; set; }
        public decimal? SchRegfee { get; set; }
        public decimal? SchTreatfee { get; set; }
        public string SchBegintime { get; set; }
        public string SchEndtime { get; set; }
        public short? SchRegMax { get; set; }
        public int? SchRegCount { get; set; }
        public int? Iscancel { get; set; }
        public string DiagRoom { get; set; }
        public string SpecialtyRoom { get; set; }
    }
}
