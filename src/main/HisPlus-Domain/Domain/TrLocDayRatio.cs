using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrLocDayRatio : EntityBase<int>
    {
        public TrLocDayRatio()
        {    
        }

        public int LocationId { get; set; }
        public System.DateTime RegDate { get; set; }
        public decimal MedicineRatio { get; set; }
        public decimal? AntiBiRatio { get; set; }
        public decimal? Ratio1 { get; set; }
        public decimal? Ratio2 { get; set; }
        public decimal? Ratio3 { get; set; }
        public decimal? Ratio4 { get; set; }
        public decimal? Ratio5 { get; set; }
        public decimal? Ratio6 { get; set; }
        public decimal? Ratio7 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
