using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBacteria : EntityBase<int>
    {
        public BsBacteria()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int? GramsId { get; set; }
        public int ShuId { get; set; }
        public int StandTypeId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
