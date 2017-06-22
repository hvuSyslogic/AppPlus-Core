using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblSettingDTO : DtoBase<int>
    {
        public GblSettingDTO()
        {
        }

        public string KeyNum { get; set; }
        public string SetValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
