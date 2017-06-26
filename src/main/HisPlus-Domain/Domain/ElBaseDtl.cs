using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElBaseDtl : EntityBase<int>
    {
        public ElBaseDtl()
        {    
        }

        public int? ElId { get; set; }
        public int? ElId1 { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsAllowSort { get; set; }
        public short? Width { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
