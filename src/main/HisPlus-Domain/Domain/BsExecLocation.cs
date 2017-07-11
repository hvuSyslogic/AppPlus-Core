using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsExecLocation : EntityBase<int>
    {
        public BsExecLocation()
        {    
        }

        public int? LocationId { get; set; }
        public int ItemId { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public string ExecPoint { get; set; }
        public string Memo { get; set; }
        public short IconIndex { get; set; }
    }
}
