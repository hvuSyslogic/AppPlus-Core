using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBpCureDtl : EntityBase<int>
    {
        public BsBpCureDtl()
        {    
        }

        public int? CureId { get; set; }
        public int? BpItemId { get; set; }
        public int? TypeCode { get; set; }
        public int? RelationCode { get; set; }
        public string WayCode { get; set; }
        public string Remark { get; set; }
    }
}
