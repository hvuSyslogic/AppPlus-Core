using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkFormulaDTO : DtoBase<int>
    {
        public CkFormulaDTO()
        {
        }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public string Formula { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
