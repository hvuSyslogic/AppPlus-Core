using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OuDiagCall : EntityBase<int>
    {
        public OuDiagCall()
        {    
        }

        public int MzRegId { get; set; }
        public int? DoctorId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PatName { get; set; }
        public string ActType { get; set; }
        public bool? IsCall { get; set; }
    }
}
