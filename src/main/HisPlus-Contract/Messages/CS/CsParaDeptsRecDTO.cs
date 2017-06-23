using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsParaDeptsRecDTO : DtoBase<int>
    {
        public CsParaDeptsRecDTO()
        {
        }

        public string YearMonth { get; set; }
        public int? LocId { get; set; }
        public short? LsAppPara { get; set; }
        public decimal? Totality { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
