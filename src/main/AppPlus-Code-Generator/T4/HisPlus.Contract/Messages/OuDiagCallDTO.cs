using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuDiagCallDTO : DtoBase<int>
    {
        public OuDiagCallDTO()
        {
        }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string PatName { get; set; }

        [DataMember]
        public string ActType { get; set; }

        [DataMember]
        public bool? IsCall { get; set; }
    }
}
