using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemPatTypeDTO : DtoBase<int>
    {
        public BsItemPatTypeDTO()
        {
        }

        [DataMember]
        public int PatTypeId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal DiscDiag { get; set; }

        [DataMember]
        public decimal DiscIn { get; set; }

        [DataMember]
        public int InvMzItemId { get; set; }

        [DataMember]
        public int InvInItemId { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
