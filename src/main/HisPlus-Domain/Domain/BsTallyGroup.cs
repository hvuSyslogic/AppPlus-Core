using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsTallyGroup : EntityBase<int>
    {
        public BsTallyGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string YbHospNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public string ZyClassName { get; set; }
        public string MzClassName { get; set; }
        public short? Lsinout { get; set; }
    }
}
