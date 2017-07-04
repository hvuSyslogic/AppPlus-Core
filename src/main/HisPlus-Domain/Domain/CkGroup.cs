using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkGroup : EntityBase<int>
    {
        public CkGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public short IconIndex { get; set; }
    }
}
