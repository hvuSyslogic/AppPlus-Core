using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OugetSchInfoDTO : DtoBase<int>
    {
        public OugetSchInfoDTO()
        {
        }

        [DataMember]
        public int? ShiftId { get; set; }

        [DataMember]
        public int? ShiftType { get; set; }

        [DataMember]
        public System.DateTime? SchDate { get; set; }

        [DataMember]
        public decimal? SchFee { get; set; }

        [DataMember]
        public decimal? SchRegfee { get; set; }

        [DataMember]
        public decimal? SchTreatfee { get; set; }

        [DataMember]
        public string SchBegintime { get; set; }

        [DataMember]
        public string SchEndtime { get; set; }

        [DataMember]
        public short? SchRegMax { get; set; }

        [DataMember]
        public int? SchRegCount { get; set; }

        [DataMember]
        public int? Iscancel { get; set; }

        [DataMember]
        public string DiagRoom { get; set; }

        [DataMember]
        public string SpecialtyRoom { get; set; }
    }
}
