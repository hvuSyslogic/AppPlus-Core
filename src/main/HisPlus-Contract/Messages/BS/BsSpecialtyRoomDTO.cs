using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsSpecialtyRoomDTO : DtoBase<int>
    {
        public BsSpecialtyRoomDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? Hospitalid { get; set; }
        public int? Locationid { get; set; }
        public string Wbcode { get; set; }
        public string Pycode { get; set; }
        public int Orderby { get; set; }
        public int Isactive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int Iconindex { get; set; }
    }
}
