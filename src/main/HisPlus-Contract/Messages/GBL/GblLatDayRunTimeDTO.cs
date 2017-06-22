using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblLatDayRunTimeDTO : DtoBase<int>
    {
        public GblLatDayRunTimeDTO()
        {
        }

        public System.DateTime? LastTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
