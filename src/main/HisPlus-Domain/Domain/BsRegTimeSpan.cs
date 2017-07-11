using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsRegTimeSpan : EntityBase<int>
    {
        public BsRegTimeSpan()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
    }
}
