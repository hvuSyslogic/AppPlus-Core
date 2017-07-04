using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmAdjustDTO : DtoBase<int>
    {
        public RmAdjustDTO()
        {
        }

        [DataMember]
        public string BillNo { get; set; }

        [DataMember]
        public System.DateTime AdjustDate { get; set; }

        [DataMember]
        public string DispUnit { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
