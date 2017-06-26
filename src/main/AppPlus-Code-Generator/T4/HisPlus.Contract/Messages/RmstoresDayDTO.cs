using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RmstoresDayDTO : DtoBase<int>
    {
        public RmstoresDayDTO()
        {
        }

        [DataMember]
        public int? CompId { get; set; }
    }
}
