using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElEhr : EntityBase<int>
    {
        public ElEhr()
        {    
        }

        public string RecNo { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime? ModifyOperTime { get; set; }
        public int? ModifyOperId { get; set; }
        public int PatMenuId { get; set; }
        public byte[] Content { get; set; }
        public string XmlFile { get; set; }
        public bool IsAuth { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public int? AuthOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
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
    }
}
