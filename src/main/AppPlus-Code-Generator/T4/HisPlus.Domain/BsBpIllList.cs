using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBpIllList : EntityBase<int>
    {
        public BsBpIllList()
        {    
        }

        public int? BpIllId { get; set; }
        public string BpIllName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
    }
}
