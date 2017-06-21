using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsItemPeopleDTO : DtoBase<int>
    {
        public BsItemPeopleDTO()
        {
        }

        public int ItemId { get; set; }
        public string Sex { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
