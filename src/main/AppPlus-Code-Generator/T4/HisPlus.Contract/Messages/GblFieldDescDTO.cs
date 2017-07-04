using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblFieldDescDTO : DtoBase<int>
    {
        public GblFieldDescDTO()
        {
        }

        [DataMember]
        public string TableName { get; set; }

        [DataMember]
        public string FieldName { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public string GroupName { get; set; }
    }
}
