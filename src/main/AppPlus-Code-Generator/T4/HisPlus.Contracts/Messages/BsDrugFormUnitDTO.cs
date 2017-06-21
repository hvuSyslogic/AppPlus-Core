using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsDrugFormUnitDTO : DtoBase<int>
    {
        public BsDrugFormUnitDTO()
        {
        }

        public int FormId { get; set; }
        public int UnitId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
