using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsIncomeSubjDTO : DtoBase<int>
    {
        public CsIncomeSubjDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short? OrderBy { get; set; }
    }
}
