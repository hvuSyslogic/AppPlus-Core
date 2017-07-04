using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemFirstPageDTO : DtoBase<int>
    {
        public BsItemFirstPageDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int? PsFeeId { get; set; }
    }
}
