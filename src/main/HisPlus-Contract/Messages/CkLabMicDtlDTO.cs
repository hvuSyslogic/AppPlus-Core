using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
