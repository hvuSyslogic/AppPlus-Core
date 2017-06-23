using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InEmrSignDTO : DtoBase<int>
    {
        public InEmrSignDTO()
        {
        }

        public int? OperId { get; set; }
        public int? EmrId { get; set; }
        public string SignValue { get; set; }
        public System.DateTime? SignDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
