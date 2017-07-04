using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsDiagRoom : EntityBase<int>
    {
        public BsDiagRoom()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? HospitalId { get; set; }
        public int LocationId { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
