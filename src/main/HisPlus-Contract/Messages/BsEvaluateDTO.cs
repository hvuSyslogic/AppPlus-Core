using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsEvaluate' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsEvaluateDTO
    {
        public BsEvaluateDTO()
        {
        }

        [DataMember]
        public string EvaluateName { get; set; }

        [DataMember]
        public string Py { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}