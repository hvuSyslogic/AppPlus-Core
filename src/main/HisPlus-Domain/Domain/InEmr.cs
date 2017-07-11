using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InEmr : EntityBase<int>
    {
        public InEmr()
        {    
        }

        public string RecNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime? ModifyOperTime { get; set; }
        public int? ModifyOperId { get; set; }
        public int CatalogId { get; set; }
        public byte[] Content { get; set; }
        public string XmlFile { get; set; }
        public bool IsAuth { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public byte[] XmlContent { get; set; }
        public bool? IsRealease { get; set; }
        public System.DateTime? RealeaseTime { get; set; }
        public int? RealeaseOperId { get; set; }
        public bool? IsPrint { get; set; }
        public System.DateTime? PrintTime { get; set; }
        public int? PrintOperId { get; set; }
        public bool? IsClosed { get; set; }
        public System.DateTime? ClosedTime { get; set; }
        public int? ClosedOperId { get; set; }
        public bool? IsCheck { get; set; }
        public int? LocationId { get; set; }
        public bool? IsDelete { get; set; }
        public System.DateTime? OperTime2 { get; set; }
        public short? NodeOrderBy { get; set; }
        public string DeptName { get; set; }
        public string BedName { get; set; }
        public string EmrTypeName { get; set; }
    }
}
