using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

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
