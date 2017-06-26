using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsOuMergeFeeDTO : DtoBase<int>
    {
        public BsOuMergeFeeDTO()
        {
        }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public int ItemId1 { get; set; }

        [DataMember]
        public int ItemId2 { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
