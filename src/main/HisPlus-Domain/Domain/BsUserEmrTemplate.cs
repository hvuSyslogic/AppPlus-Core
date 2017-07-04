using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUserEmrTemplate : EntityBase<int>
    {
        public BsUserEmrTemplate()
        {    
        }

        public int OperId { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public string TemplateFile { get; set; }
        public bool IsDefault { get; set; }
        public short OrderBy { get; set; }
        public short IconIndex { get; set; }
        public short? LsOpenType { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LocationId { get; set; }
        public bool? IsActive { get; set; }
    }
}
