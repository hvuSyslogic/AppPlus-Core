using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsRegSpanSub : EntityBase<int>
    {
        public BsRegSpanSub()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public int? TimeSpanId { get; set; }
    }
}