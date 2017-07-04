using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsSubjectDTO : DtoBase<int>
    {
        public BsSubjectDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }
    }
}
