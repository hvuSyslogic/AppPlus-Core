using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblModuleDTO : DtoBase<int>
    {
        public GblModuleDTO()
        {
        }

        public int? FunctionId { get; set; }
        public int? MenuId { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
