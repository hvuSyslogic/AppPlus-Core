using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InBodyHeatDTO : DtoBase<int>
    {
        public InBodyHeatDTO()
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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public decimal? Bg { get; set; }
        public string CwInject { get; set; }
        public string JmInject { get; set; }
        public string CwHeight { get; set; }
        public System.DateTime? OperationTime { get; set; }
        public bool? IsLeave { get; set; }
        public string MemoUp1 { get; set; }
        public string MemoDn1 { get; set; }
        public System.DateTime? RecordTime { get; set; }
    }
}
