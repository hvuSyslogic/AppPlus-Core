using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsOpsItemDTO : DtoBase<int>
    {
        public BsOpsItemDTO()
        {
        }

        [DataMember]
        public int OpsItem { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
