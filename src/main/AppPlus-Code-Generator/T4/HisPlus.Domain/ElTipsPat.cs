using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElTipsPat : EntityBase<int>
    {
        public ElTipsPat()
        {    
        }

        public int? HospitalId { get; set; }
        public int? TipId { get; set; }
        public string Tips { get; set; }
        public int? PatFormId { get; set; }
        public System.DateTime OperTime { get; set; }
        public short? ActiveDays { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
