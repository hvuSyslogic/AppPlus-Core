using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsPatientYbIllDTO : DtoBase<int>
    {
        public BsPatientYbIllDTO()
        {
        }

        [DataMember]
        public int PatTyeId { get; set; }

        [DataMember]
        public int YbIllId { get; set; }

        [DataMember]
        public string MedicareNo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }
    }
}
