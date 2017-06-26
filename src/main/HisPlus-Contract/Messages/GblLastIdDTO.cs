using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblLastIdDTO : DtoBase<int>
    {
        public GblLastIdDTO()
        {
        }

        [DataMember]
        public string TableName { get; set; }

        [DataMember]
        public int? LastId { get; set; }

        [DataMember]
        public System.DateTime? LastTime { get; set; }
    }
}
