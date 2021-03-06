using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsManufacturer : EntityBase<int>
    {
        public BsManufacturer()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public short? LsKind { get; set; }
        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
