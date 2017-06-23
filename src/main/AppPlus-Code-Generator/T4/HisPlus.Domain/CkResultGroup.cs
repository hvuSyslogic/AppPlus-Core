using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkResultGroup : EntityBase<int>
    {
        public CkResultGroup()
        {    
        }

        public int TestGroupId { get; set; }
        public int CheckId { get; set; }
        public string CheckDesc { get; set; }
        public string Summary { get; set; }
        public string DoctorAdvice { get; set; }
        public short? LsStatus { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime? ResultTime { get; set; }
        public int? ResultOperId { get; set; }
        public System.DateTime? AuthTime { get; set; }
        public int? AuthOperId { get; set; }
    }
}
