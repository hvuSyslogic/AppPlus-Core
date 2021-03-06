using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblFieldDesc : EntityBase<int>
    {
        public GblFieldDesc()
        {    
        }

        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
