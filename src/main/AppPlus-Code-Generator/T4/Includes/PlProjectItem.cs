using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class PlProjectItem : EntityBase<int>
    {
        public PlProjectItem()
        {    
        }

        public int ProjId { get; set; }
        public int ItemId { get; set; }
        public string Memo { get; set; }
        public short Hours { get; set; }
        public System.DateTime? BeginPlan { get; set; }
        public System.DateTime? EndPlan { get; set; }
        public bool? IsClose { get; set; }
        public short? HoursFact { get; set; }
        public System.DateTime? EndFact { get; set; }
        public int? ChargeOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
