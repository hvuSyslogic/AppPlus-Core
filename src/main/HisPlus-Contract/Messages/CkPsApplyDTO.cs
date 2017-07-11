using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkPsApplyDTO : DtoBase<int>
    {
        public CkPsApplyDTO()
        {
        }

        [DataMember]
        public string ApplyId { get; set; }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string CheckBody { get; set; }

        [DataMember]
        public short XType { get; set; }
    }
}
