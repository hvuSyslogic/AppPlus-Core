using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public short? LsReadClass { get; set; }
    }
}
