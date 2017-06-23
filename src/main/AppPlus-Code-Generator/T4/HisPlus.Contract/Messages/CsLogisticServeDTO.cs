using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsLogisticServeDTO : DtoBase<int>
    {
        public CsLogisticServeDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? UnitPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
