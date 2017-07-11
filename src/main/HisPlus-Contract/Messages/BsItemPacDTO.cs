using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemPacDTO : DtoBase<int>
    {
        public BsItemPacDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public short? XType { get; set; }

        [DataMember]
        public string Equipment { get; set; }

        [DataMember]
        public string CheckBody { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
