using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class RdContract : EntityBase<int>
    {
        public RdContract()
        {    
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public bool IsTeach { get; set; }
        public bool IsMessage { get; set; }
        public bool IsEmail { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
