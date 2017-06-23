using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class ConfirmPreDTO : DtoBase<int>
    {
        public ConfirmPreDTO()
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
