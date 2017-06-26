using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OuGfbxReport : EntityBase<int>
    {
        public OuGfbxReport()
        {    
        }

        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int PatType { get; set; }
        public int TypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
