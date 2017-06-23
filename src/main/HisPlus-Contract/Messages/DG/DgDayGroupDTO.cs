using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DgDayGroupDTO : DtoBase<int>
    {
        public DgDayGroupDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short? Days { get; set; }
    }
}
