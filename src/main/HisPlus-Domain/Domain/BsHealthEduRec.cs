using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsHealthEduRec : EntityBase<int>
    {
        public BsHealthEduRec()
        {    
        }

        public string Code { get; set; }
        public int HealthEduRec { get; set; }
        public string Name { get; set; }
        public string Rmark { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public bool? IdleFlag { get; set; }
        public short IconIndex { get; set; }
    }
}
