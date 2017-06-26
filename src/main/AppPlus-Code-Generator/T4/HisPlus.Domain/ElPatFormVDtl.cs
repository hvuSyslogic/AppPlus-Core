using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElPatFormVDtl : EntityBase<int>
    {
        public ElPatFormVDtl()
        {    
        }

        public int? PatFormId { get; set; }
        public int? PatFormValueId { get; set; }
        public int? ElId { get; set; }
        public int? BsDtlId { get; set; }
        public string ElValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
