using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsHospitalDTO : DtoBase<int>
    {
        public BsHospitalDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int AreaId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Area { get; set; }
        public decimal? Farthest { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? ResidentPopulation { get; set; }
        public int? TentPopulation { get; set; }
        public string Memo { get; set; }
        public short IconIndex { get; set; }
    }
}
