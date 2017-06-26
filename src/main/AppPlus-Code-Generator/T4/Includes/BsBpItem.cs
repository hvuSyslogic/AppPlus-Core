using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
