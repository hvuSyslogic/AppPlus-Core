using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsitemcustomgroupDTO : DtoBase<int>
    {
        public BsitemcustomgroupDTO()
        {
        }

        public string Name { get; set; }
        public int Orderby { get; set; }
        public int Isactive { get; set; }
        public int Lsoutorin { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int Iconindex { get; set; }
    }
}
