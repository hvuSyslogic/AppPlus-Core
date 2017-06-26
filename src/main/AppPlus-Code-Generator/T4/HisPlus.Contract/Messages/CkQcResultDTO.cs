using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkQcResultDTO : DtoBase<int>
    {
        public CkQcResultDTO()
        {
        }

        [DataMember]
        public System.DateTime ResultDate { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string ResultComment { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string ResultStatus { get; set; }

        [DataMember]
        public int LotId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public int CtrlId { get; set; }

        [DataMember]
        public bool? IsShowQc { get; set; }

        [DataMember]
        public string RejectMemo { get; set; }

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
