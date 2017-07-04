using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string PatName { get; set; }
        public string ActType { get; set; }
        public bool? IsCall { get; set; }
    }
}
