using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InBodyHeatDTO : DtoBase<int>
    {
        public InBodyHeatDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string AnimalHeat { get; set; }

        [DataMember]
        public string HeatType { get; set; }

        [DataMember]
        public string Pulse { get; set; }

        [DataMember]
        public string Heart { get; set; }

        [DataMember]
        public string Breath { get; set; }

        [DataMember]
        public string Stool { get; set; }

        [DataMember]
        public string Urine { get; set; }

        [DataMember]
        public string Weight { get; set; }

        [DataMember]
        public string Bldpress0 { get; set; }

        [DataMember]
        public string Bldpress1 { get; set; }

        [DataMember]
        public string FluidM { get; set; }

        [DataMember]
        public string TotalIn { get; set; }

        [DataMember]
        public string UrineM { get; set; }

        [DataMember]
        public string OtherM { get; set; }

        [DataMember]
        public string TotalOut { get; set; }

        [DataMember]
        public string MemoUp { get; set; }

        [DataMember]
        public string MemoDn { get; set; }

        [DataMember]
        public bool SpinTest { get; set; }

        [DataMember]
        public bool LowerTemp { get; set; }

        [DataMember]
        public bool IsRecheck { get; set; }

        [DataMember]
        public bool IsOutSide { get; set; }

        [DataMember]
        public bool IsMachine { get; set; }

        [DataMember]
        public string Others { get; set; }

        [DataMember]
        public bool IsOps { get; set; }

        [DataMember]
        public System.DateTime? BirthTime { get; set; }

        [DataMember]
        public bool IsReject { get; set; }

        [DataMember]
        public System.DateTime? DeadTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public decimal? Bg { get; set; }

        [DataMember]
        public string CwInject { get; set; }

        [DataMember]
        public string JmInject { get; set; }

        [DataMember]
        public string CwHeight { get; set; }

        [DataMember]
        public System.DateTime? OperationTime { get; set; }

        [DataMember]
        public bool? IsLeave { get; set; }

        [DataMember]
        public string MemoUp1 { get; set; }

        [DataMember]
        public string MemoDn1 { get; set; }

        [DataMember]
        public System.DateTime? RecordTime { get; set; }

        [DataMember]
        public string TimeQuantum { get; set; }
    }
}
