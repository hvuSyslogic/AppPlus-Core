using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsItemFrequency : EntityBase<int>
    {
        public BsItemFrequency()
        {    
        }

        public int ItemId { get; set; }
        public int FrequencyId { get; set; }
        public short IconIndex { get; set; }
    }
}
