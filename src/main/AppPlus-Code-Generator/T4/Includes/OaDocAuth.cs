using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class OaDocAuth : EntityBase<int>
    {
        public OaDocAuth()
        {    
        }

        public int? DocId { get; set; }
        public int? AuthOperId { get; set; }
        public short? OrderBy { get; set; }
        public bool IsAuth { get; set; }
        public System.DateTime? AuthOperTime { get; set; }
        public bool? IsReject { get; set; }
        public string RejectReason { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? LsReadClass { get; set; }
    }
}
