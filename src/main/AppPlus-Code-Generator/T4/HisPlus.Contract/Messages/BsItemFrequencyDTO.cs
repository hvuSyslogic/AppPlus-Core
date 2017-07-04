using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemFrequencyDTO : DtoBase<int>
    {
        public BsItemFrequencyDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int FrequencyId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
