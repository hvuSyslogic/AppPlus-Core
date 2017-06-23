using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class GblReportDetail : EntityBase<int>
    {
        public GblReportDetail()
        {    
        }

        public int GroupId { get; set; }
        public int FeeId { get; set; }
    }
}
