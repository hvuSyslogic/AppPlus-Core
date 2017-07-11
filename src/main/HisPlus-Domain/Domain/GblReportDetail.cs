using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
