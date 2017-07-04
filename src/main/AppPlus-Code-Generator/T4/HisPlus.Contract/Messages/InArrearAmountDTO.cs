using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InArrearAmountDTO : DtoBase<int>
    {
        public InArrearAmountDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public decimal ArrearAmount { get; set; }

        [DataMember]
        public string AuthMan { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime? ExpireDate { get; set; }

        [DataMember]
        public short? ExpireHours { get; set; }

        [DataMember]
        public bool? IsMax { get; set; }
    }
}
