using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class DgDrugTip : EntityBase<int>
    {
        public DgDrugTip()
        {    
        }

        public int DrugId { get; set; }
        public string Sex { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public decimal? Weight { get; set; }
        public int? WorktypeId { get; set; }
        public int? ItemId { get; set; }
        public int? IcdId { get; set; }
        public short? LsWomenStatus { get; set; }
        public int? DropSpeed { get; set; }
        public string LClass { get; set; }
        public string Expain { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Dosage { get; set; }
    }
}
