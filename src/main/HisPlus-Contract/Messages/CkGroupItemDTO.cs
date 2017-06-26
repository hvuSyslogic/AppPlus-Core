using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
