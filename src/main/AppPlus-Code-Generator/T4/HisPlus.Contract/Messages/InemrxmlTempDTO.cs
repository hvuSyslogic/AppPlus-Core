using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'inemrxml_temp' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class InemrxmlTempDTO
    {
        public InemrxmlTempDTO()
        {
        }

        [DataMember]
        public string Mouth { get; set; }

        [DataMember]
        public string Xmlfield { get; set; }

        [DataMember]
        public int? Rc { get; set; }
    }
}
