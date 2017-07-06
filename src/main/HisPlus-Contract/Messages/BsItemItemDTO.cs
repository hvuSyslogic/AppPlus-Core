using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemItemDTO : DtoBase<int>
    {
        public BsItemItemDTO()
        {
        }

        [DataMember]
        public int ItemId1 { get; set; }

        [DataMember]
        public int ItemId2 { get; set; }

        [DataMember]
        public bool IsReject { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
