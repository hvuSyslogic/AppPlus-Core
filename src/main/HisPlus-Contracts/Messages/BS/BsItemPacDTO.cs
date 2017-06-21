using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemPacDTO : DtoBase<int>
    {
        public BsItemPacDTO()
        {
        }

        public int ItemId { get; set; }
        public short? XType { get; set; }
        public string Equipment { get; set; }
        public string CheckBody { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
