using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblMrkDTO : DtoBase<int>
    {
        public GblMrkDTO()
        {
        }

        public string MrkFile { get; set; }
        public string MrkContent { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
