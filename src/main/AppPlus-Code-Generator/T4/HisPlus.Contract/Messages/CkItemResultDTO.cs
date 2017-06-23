using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkItemResultDTO : DtoBase<int>
    {
        public CkItemResultDTO()
        {
        }

        public int TestId { get; set; }
        public string Result { get; set; }
        public bool IsBold { get; set; }
        public bool IsPass { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string DoctorAdvice { get; set; }
    }
}
