using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsFrequencyTime : EntityBase<int>
    {
        public BsFrequencyTime()
        {    
        }

        public int FrequencyId { get; set; }
        public string ExecTime { get; set; }
        public short IconIndex { get; set; }
    }
}
