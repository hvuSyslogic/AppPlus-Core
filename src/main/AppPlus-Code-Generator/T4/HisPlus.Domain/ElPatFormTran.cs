using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElPatFormTran : EntityBase<int>
    {
        public ElPatFormTran()
        {    
        }

        public int? PatFormId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string RecNo { get; set; }
        public System.DateTime? ChangeTime { get; set; }
        public int? ChangeOperId { get; set; }
        public string Reason { get; set; }
        public string FromHospital { get; set; }
        public string ToHospital { get; set; }
        public System.DateTime? RecieveTime { get; set; }
        public int? RecieveOperId { get; set; }
        public string Disposal { get; set; }
        public string Diagnose { get; set; }
        public string Memo { get; set; }
    }
}
