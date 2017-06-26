using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsPatientYbIll : EntityBase<int>
    {
        public BsPatientYbIll()
        {    
        }

        public int PatTyeId { get; set; }
        public int YbIllId { get; set; }
        public string MedicareNo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
    }
}
