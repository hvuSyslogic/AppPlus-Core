using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElPatFormValue : EntityBase<int>
    {
        public ElPatFormValue()
        {    
        }

        public int? PatFormId { get; set; }
        public int? ElId { get; set; }
        public string ElValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? LsType { get; set; }
        public int? ClassId { get; set; }
    }
}
