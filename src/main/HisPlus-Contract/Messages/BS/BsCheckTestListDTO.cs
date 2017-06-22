using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsCheckTestListDTO : DtoBase<int>
    {
        public BsCheckTestListDTO()
        {
        }

        public int? IllId { get; set; }
        public string IllName { get; set; }
        public string GroupType { get; set; }
        public string CheckTestType { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string ItemResult { get; set; }
    }
}
