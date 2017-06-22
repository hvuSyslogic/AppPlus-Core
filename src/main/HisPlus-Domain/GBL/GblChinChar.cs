using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblChinChar : EntityBase<int>
    {
        public GblChinChar()
        {    
        }

        public string Name { get; set; }
        public string PyCode { get; set; }
        public string PyChar { get; set; }
        public string WbCode { get; set; }
        public string WbChar { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
