using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InOpsSumDTO : DtoBase<int>
    {
        public InOpsSumDTO()
        {
        }

        public int LocationId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int SelectDateNum { get; set; }
        public int EmergencyNum { get; set; }
        public int OutPatientNum { get; set; }
        public string Memo { get; set; }
    }
}
