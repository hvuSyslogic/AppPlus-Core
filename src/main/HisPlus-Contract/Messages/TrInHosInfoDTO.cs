using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class TrInHosInfoDTO : DtoBase<int>
    {
        public TrInHosInfoDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public System.DateTime? InTime { get; set; }

        [DataMember]
        public System.DateTime? OutTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? BedId { get; set; }

        [DataMember]
        public short? LsInStatus { get; set; }

        [DataMember]
        public int? LocIn { get; set; }

        [DataMember]
        public string Residence { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string IdCardNo { get; set; }

        [DataMember]
        public short? LsMarriage { get; set; }
    }
}
