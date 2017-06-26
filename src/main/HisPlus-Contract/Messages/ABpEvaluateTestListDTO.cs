using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'A_BPEvaluateTestList' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class ABpEvaluateTestListDTO
    {
        public ABpEvaluateTestListDTO()
        {
        }

        [DataMember]
        public string EvaluateName { get; set; }

        [DataMember]
        public string Common { get; set; }

        [DataMember]
        public double? Orderby { get; set; }

        [DataMember]
        public string IllName { get; set; }

        [DataMember]
        public string GroupType { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string Py { get; set; }

        [DataMember]
        public string Wb { get; set; }
    }
}
