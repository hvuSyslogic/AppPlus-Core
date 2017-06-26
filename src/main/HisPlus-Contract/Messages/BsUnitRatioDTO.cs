using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUnitRatioDTO : DtoBase<int>
    {
        public BsUnitRatioDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int UnitId1 { get; set; }

        [DataMember]
        public int UnitId2 { get; set; }

        [DataMember]
        public decimal DrugRatio { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
