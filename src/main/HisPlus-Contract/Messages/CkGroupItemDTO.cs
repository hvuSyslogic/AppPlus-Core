using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkGroupItemDTO : DtoBase<int>
    {
        public CkGroupItemDTO()
        {
        }

        [DataMember]
        public int CompanyGroupId { get; set; }

        [DataMember]
        public int TestId { get; set; }

        [DataMember]
        public int ParentId { get; set; }

        [DataMember]
        public string ItemId { get; set; }

        [DataMember]
        public string AppId { get; set; }
    }
}
