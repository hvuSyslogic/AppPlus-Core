using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUnit : EntityBase<int>
    {
        public BsUnit()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
