using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblEmailUser : EntityBase<int>
    {
        public GblEmailUser()
        {    
        }

        public int EmailId { get; set; }
        public int OperId { get; set; }
        public bool? IsRead { get; set; }
        public System.DateTime? ReadTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
