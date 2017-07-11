using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBacteriaDrug : EntityBase<int>
    {
        public BsBacteriaDrug()
        {    
        }

        public int BactriaId { get; set; }
        public int DrugId { get; set; }
    }
}
