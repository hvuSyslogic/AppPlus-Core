using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsEducationIllDTO : DtoBase<int>
    {
        public BsEducationIllDTO()
        {
        }

        public int EducationId { get; set; }
        public int ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
