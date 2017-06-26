using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class TrPractise : EntityBase<int>
    {
        public TrPractise()
        {    
        }

        public string Hospital { get; set; }
        public int? OriId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public System.DateTime? PractiseTime { get; set; }
        public byte? DebugMode { get; set; }
        public string Funtion { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string LocationName { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
