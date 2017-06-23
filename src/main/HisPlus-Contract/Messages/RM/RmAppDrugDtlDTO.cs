using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RmAppDrugDtlDTO : DtoBase<int>
    {
        public RmAppDrugDtlDTO()
        {
        }

        public int BillId { get; set; }
        public int ItemId { get; set; }
        public decimal DrugNum { get; set; }
        public int UnitId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
