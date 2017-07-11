using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OaDocument : EntityBase<int>
    {
        public OaDocument()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? GroupMainId { get; set; }
        public int? GroupSubId { get; set; }
        public short? LsOpenType { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LocationId { get; set; }
        public bool? IsActive { get; set; }
        public string InActiveReason { get; set; }
        public System.DateTime? InActiveTime { get; set; }
        public int? InActiveOperId { get; set; }
        public short? IconIndex { get; set; }
        public short? Security { get; set; }
        public string Password { get; set; }
    }
}
