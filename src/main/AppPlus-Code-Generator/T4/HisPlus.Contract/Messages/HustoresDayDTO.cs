using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HustoresDayDTO : DtoBase<int>
    {
        public HustoresDayDTO()
        {
        }

        [DataMember]
        public int? CompId { get; set; }
    }
}
