using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBacteriaShu : EntityBase<int>
    {
        public BsBacteriaShu()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public int? GramsId { get; set; }
    }
}
