using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
