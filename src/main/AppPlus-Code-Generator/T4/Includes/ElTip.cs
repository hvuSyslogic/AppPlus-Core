using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElTip : EntityBase<int>
    {
        public ElTip()
        {    
        }

        public int? PatMenuId { get; set; }
        public string WhereFormat { get; set; }
        public string Arg1 { get; set; }
        public string Arg2 { get; set; }
        public string Arg3 { get; set; }
        public string Arg4 { get; set; }
        public string Arg5 { get; set; }
        public string Tips { get; set; }
        public bool? IsFollow { get; set; }
        public short? ActiveDays { get; set; }
        public string RoleIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
