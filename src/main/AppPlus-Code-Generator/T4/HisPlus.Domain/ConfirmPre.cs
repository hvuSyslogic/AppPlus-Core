using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ConfirmPre : EntityBase<int>
    {
        public ConfirmPre()
        {    
        }

        public string Presno { get; set; }
        public System.DateTime PresDate { get; set; }
        public int WindowNo { get; set; }
        public string PatientId { get; set; }
        public string Flag { get; set; }
        public string Fpno { get; set; }
    }
}
