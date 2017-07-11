using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblMrkDTO : DtoBase<int>
    {
        public GblMrkDTO()
        {
        }

        [DataMember]
        public string MrkFile { get; set; }

        [DataMember]
        public string MrkContent { get; set; }

        [DataMember]
        public bool IsActive { get; set; }
    }
}
