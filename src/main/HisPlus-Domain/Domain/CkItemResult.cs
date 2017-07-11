using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkItemResult : EntityBase<int>
    {
        public CkItemResult()
        {    
        }

        public int TestId { get; set; }
        public string Result { get; set; }
        public bool IsBold { get; set; }
        public bool IsPass { get; set; }
        public string Summary { get; set; }
        public string DoctorAdvice { get; set; }
    }
}
