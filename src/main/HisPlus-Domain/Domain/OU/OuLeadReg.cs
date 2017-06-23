using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuLeadReg : EntityBase<int>
    {
        public OuLeadReg()
        {    
        }

        public int PatId { get; set; }
        public int? MzRegId { get; set; }
        public int RegTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsElder { get; set; }
        public int LocationId { get; set; }
        public int? DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
