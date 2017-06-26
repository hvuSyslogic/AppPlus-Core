using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class TmpMyPat : EntityBase<int>
    {
        public TmpMyPat()
        {    
        }

        public int PatId { get; set; }
        public int DoctorId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public bool IsAlert { get; set; }
        public int? FrequencyId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
