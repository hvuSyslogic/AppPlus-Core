using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInCarDTO : DtoBase<int>
    {
        public OuInCarDTO()
        {
        }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int NurseOperId { get; set; }

        [DataMember]
        public int DriverOperId { get; set; }

        [DataMember]
        public string CarNumber { get; set; }

        [DataMember]
        public System.DateTime CarTime { get; set; }

        [DataMember]
        public decimal Distance { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public int DetailId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
