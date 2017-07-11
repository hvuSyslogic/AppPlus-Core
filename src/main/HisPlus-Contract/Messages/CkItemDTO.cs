using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkItemDTO : DtoBase<int>
    {
        public CkItemDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public short LsTestType { get; set; }

        [DataMember]
        public int? TestTypeId { get; set; }

        [DataMember]
        public int? TubeTypeId { get; set; }

        [DataMember]
        public string ShortName { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string OperMemo { get; set; }

        [DataMember]
        public bool IsZero { get; set; }

        [DataMember]
        public short LsGroup { get; set; }

        [DataMember]
        public bool IsReport { get; set; }

        [DataMember]
        public string UseRange { get; set; }

        [DataMember]
        public short LsForSex { get; set; }

        [DataMember]
        public int? SourceId { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public string Format { get; set; }

        [DataMember]
        public decimal LimitHigh { get; set; }

        [DataMember]
        public decimal LimitLow { get; set; }

        [DataMember]
        public string PrintHigh { get; set; }

        [DataMember]
        public string PrintLow { get; set; }

        [DataMember]
        public decimal DalAbsolute { get; set; }

        [DataMember]
        public decimal DalPercent { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsDisplay { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public int? FluidId { get; set; }

        [DataMember]
        public string TestWay { get; set; }

        [DataMember]
        public decimal? Dev3 { get; set; }

        [DataMember]
        public decimal? Dev2 { get; set; }

        [DataMember]
        public decimal? Dev1 { get; set; }

        [DataMember]
        public decimal? DevM1 { get; set; }

        [DataMember]
        public decimal? DevM2 { get; set; }

        [DataMember]
        public decimal? DevM3 { get; set; }

        [DataMember]
        public decimal? AvgValue { get; set; }

        [DataMember]
        public string DefultValue { get; set; }
    }
}
