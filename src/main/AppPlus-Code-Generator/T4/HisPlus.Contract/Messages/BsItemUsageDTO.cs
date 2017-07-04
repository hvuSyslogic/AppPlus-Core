using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemUsageDTO : DtoBase<int>
    {
        public BsItemUsageDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int UsageId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
