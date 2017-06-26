using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuTransferHospDTO : DtoBase<int>
    {
        public OuTransferHospDTO()
        {
        }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int HospitalId { get; set; }

        [DataMember]
        public System.DateTime OutTime { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime? ReturnTime { get; set; }

        [DataMember]
        public string ReturnMemo { get; set; }

        [DataMember]
        public System.DateTime? ReturnOperTime { get; set; }

        [DataMember]
        public int? ReturnOperId { get; set; }
    }
}
