using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblFunTrace : EntityBase<int>
    {
        public GblFunTrace()
        {    
        }

        public byte? DebugMode { get; set; }
        public int? FuntionId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? UserId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
