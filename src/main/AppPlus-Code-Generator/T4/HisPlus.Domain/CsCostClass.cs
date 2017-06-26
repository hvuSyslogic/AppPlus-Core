using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CsCostClass : EntityBase<int>
    {
        public CsCostClass()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string SuppItemCode { get; set; }
        public bool? IsActive { get; set; }
        public string LastLevel { get; set; }
        public string PyCode { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string WbCode { get; set; }
        public short? OrderBy { get; set; }
    }
}
