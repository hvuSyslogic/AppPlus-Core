using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InHosBed : EntityBase<int>
    {
        public InHosBed()
        {    
        }

        public int HospId { get; set; }
        public int BedId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
