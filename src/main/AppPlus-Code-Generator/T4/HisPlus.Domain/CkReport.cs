using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
