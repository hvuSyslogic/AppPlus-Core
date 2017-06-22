using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsBacteriaDrugDTO : DtoBase<int>
    {
        public BsBacteriaDrugDTO()
        {
        }

        public int BactriaId { get; set; }
        public int DrugId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
