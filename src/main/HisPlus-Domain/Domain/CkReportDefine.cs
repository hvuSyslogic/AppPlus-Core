using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class CkReportDefine : EntityBase<int>
    {
        public CkReportDefine()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int? TestTypeId { get; set; }
        public byte[] ReportContent { get; set; }
    }
}
