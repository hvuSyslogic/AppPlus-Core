using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElPatRecord : EntityBase<int>
    {
        public ElPatRecord()
        {    
        }

        public int? PatId { get; set; }
        public int? HospitalId { get; set; }
        public int GroupId { get; set; }
        public string RecNo { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
