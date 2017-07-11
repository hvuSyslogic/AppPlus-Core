using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkReportDTO : DtoBase<int>
    {
        public CkReportDTO()
        {
        }

        [DataMember]
        public int CheckId { get; set; }

        [DataMember]
        public int TestGroupId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public byte[] Content { get; set; }

        [DataMember]
        public string XmlFile { get; set; }
    }
}
