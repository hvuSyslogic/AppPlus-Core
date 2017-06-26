using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class EqCheckDTO : DtoBase<int>
    {
        public EqCheckDTO()
        {
        }

        [DataMember]
        public int EquipmentId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public string CheckMan { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
