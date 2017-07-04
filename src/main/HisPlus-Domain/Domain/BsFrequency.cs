using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsFrequency : EntityBase<int>
    {
        public BsFrequency()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public int Days { get; set; }
        public decimal Times { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public bool? IsHour { get; set; }
    }
}
