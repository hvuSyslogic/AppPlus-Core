using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsItemFirstPageType' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsItemFirstPageTypeDTO
    {
        public BsItemFirstPageTypeDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

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
