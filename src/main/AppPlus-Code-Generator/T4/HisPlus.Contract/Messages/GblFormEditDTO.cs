using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblFormEditDTO : DtoBase<int>
    {
        public GblFormEditDTO()
        {
        }

        public string FormName { get; set; }
        public string FiledName { get; set; }
        public bool? IsAdd { get; set; }
        public string ToolTip { get; set; }
        public bool? IsExcept { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
