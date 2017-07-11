using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InBodyHeat : EntityBase<int>
    {
        public InBodyHeat()
        {    
        }

        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string AnimalHeat { get; set; }
        public string HeatType { get; set; }
        public string Pulse { get; set; }
        public string Heart { get; set; }
        public string Breath { get; set; }
        public string Stool { get; set; }
        public string Urine { get; set; }
        public string Weight { get; set; }
        public string Bldpress0 { get; set; }
        public string Bldpress1 { get; set; }
        public string FluidM { get; set; }
        public string TotalIn { get; set; }
        public string UrineM { get; set; }
        public string OtherM { get; set; }
        public string TotalOut { get; set; }
        public string MemoUp { get; set; }
        public string MemoDn { get; set; }
        public bool SpinTest { get; set; }
        public bool LowerTemp { get; set; }
        public bool IsRecheck { get; set; }
        public bool IsOutSide { get; set; }
        public bool IsMachine { get; set; }
        public string Others { get; set; }
        public bool IsOps { get; set; }
        public System.DateTime? BirthTime { get; set; }
        public bool IsReject { get; set; }
        public System.DateTime? DeadTime { get; set; }
        public int? LocationId { get; set; }
        public decimal? Bg { get; set; }
        public string CwInject { get; set; }
        public string JmInject { get; set; }
        public string CwHeight { get; set; }
        public System.DateTime? OperationTime { get; set; }
        public bool? IsLeave { get; set; }
        public string MemoUp1 { get; set; }
        public string MemoDn1 { get; set; }
        public System.DateTime? RecordTime { get; set; }
        public string TimeQuantum { get; set; }
    }
}
