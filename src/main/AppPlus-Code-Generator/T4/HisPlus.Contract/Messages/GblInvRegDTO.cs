using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblInvRegDTO : DtoBase<int>
    {
        public GblInvRegDTO()
        {
        }

        [DataMember]
        public string InvType { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string StartInvoNo { get; set; }

        [DataMember]
        public string EndInvoNo { get; set; }

        [DataMember]
        public bool IsEnd { get; set; }

        [DataMember]
        public System.DateTime? EndTime { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }
    }
}
