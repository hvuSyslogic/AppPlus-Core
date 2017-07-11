using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemIllTypeDTO : DtoBase<int>
    {
        public BsItemIllTypeDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int IllTypeId { get; set; }

        [DataMember]
        public string YbCode { get; set; }

        [DataMember]
        public int? TallyGroupId { get; set; }
    }
}
