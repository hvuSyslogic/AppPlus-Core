using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsCareGroup : EntityBase<int>
    {
        public BsCareGroup()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public int? DoctorId { get; set; }
        public int? NurseUserId { get; set; }
        public int? GuardUserId { get; set; }
        public int? OtherUserId { get; set; }
        public short IconIndex { get; set; }
    }
}
