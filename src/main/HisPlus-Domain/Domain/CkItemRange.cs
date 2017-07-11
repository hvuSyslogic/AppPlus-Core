using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkItemRange : EntityBase<int>
    {
        public CkItemRange()
        {    
        }

        public int TestId { get; set; }
        public string Sex { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal PanicLow { get; set; }
        public decimal PanicHigh { get; set; }
        public string PrintResult { get; set; }
        public string TextRange { get; set; }
        public short? LsAgeUnit { get; set; }
        public int? MachineId { get; set; }
    }
}
