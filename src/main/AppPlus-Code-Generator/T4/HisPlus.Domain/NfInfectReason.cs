using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class NfInfectReason : EntityBase<int>
    {
        public NfInfectReason()
        {    
        }

        public int InfectId { get; set; }
        public int InfReasonId { get; set; }
        public bool? IsRelated { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
