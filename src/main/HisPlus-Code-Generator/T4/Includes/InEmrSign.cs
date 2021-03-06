using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InEmrSign : EntityBase<int>
    {
        public InEmrSign()
        {    
        }

        public int? OperId { get; set; }
        public int? EmrId { get; set; }
        public string SignValue { get; set; }
        public System.DateTime? SignDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
