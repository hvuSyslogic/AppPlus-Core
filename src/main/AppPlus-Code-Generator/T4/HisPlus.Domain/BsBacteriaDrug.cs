using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsBacteriaDrug : EntityBase<int>
    {
        public BsBacteriaDrug()
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
