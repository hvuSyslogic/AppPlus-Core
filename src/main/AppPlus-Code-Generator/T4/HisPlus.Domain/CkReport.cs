using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class CkReport : EntityBase<int>
    {
        public CkReport()
        {    
        }

        public int CheckId { get; set; }
        public int TestGroupId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public byte[] Content { get; set; }
        public string XmlFile { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
