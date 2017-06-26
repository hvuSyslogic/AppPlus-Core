using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabMicDtlDTO : DtoBase<int>
    {
        public CkLabMicDtlDTO()
        {
        }

        [DataMember]
        public int MicId { get; set; }

        [DataMember]
        public int? DrugId { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string LsMic { get; set; }

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
