using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
        public string GroupName { get; set; }
    }
}
