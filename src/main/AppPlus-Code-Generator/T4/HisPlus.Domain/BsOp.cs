using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsOp : EntityBase<int>
    {
        public BsOp()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short? LsClass { get; set; }
        public short? LsAsa { get; set; }
        public bool? IsEmergency { get; set; }
        public int? AnaesId { get; set; }
        public int? Minutes { get; set; }
        public bool? IsImplant { get; set; }
        public bool? IsImglass { get; set; }
        public bool? IsOpsDrug { get; set; }
        public decimal? DangerPoint { get; set; }
    }
}
