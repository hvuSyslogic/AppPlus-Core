using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsItemFirstPageType' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsItemFirstPageTypeDTO
    {
        public BsItemFirstPageTypeDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
