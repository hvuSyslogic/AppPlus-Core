using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkLabBoodDTO : DtoBase<int>
    {
        public CkLabBoodDTO()
        {
        }

        [DataMember]
        public int? LabId { get; set; }

        [DataMember]
        public int? BdBankId { get; set; }
    }
}
