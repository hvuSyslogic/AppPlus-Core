using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBpItem : EntityBase<int>
    {
        public BsBpItem()
        {    
        }

        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public int? LsRpType { get; set; }
        public string YbCode { get; set; }
    }
}
