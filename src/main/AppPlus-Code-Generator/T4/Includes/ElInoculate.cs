using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElInoculate : EntityBase<int>
    {
        public ElInoculate()
        {    
        }

        public int PatId { get; set; }
        public int? HospitalId { get; set; }
        public int ItemId { get; set; }
        public short NTime { get; set; }
        public System.DateTime PlanTime { get; set; }
        public int PlanOperId { get; set; }
        public string Memo { get; set; }
        public bool IsInoculate { get; set; }
        public System.DateTime? InoTime { get; set; }
        public int? InoOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
