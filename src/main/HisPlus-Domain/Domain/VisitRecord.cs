using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class VisitRecord : EntityBase<int>
    {
        public VisitRecord()
        {    
        }

        public System.DateTime? VisitTime { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public short? VisitType { get; set; }
        public string VisitContent { get; set; }
        public int PatId { get; set; }
        public int MzRegId { get; set; }
        public string BackContent { get; set; }
        public short? VisitStatus { get; set; }
        public short? AppraiseType { get; set; }
    }
}
