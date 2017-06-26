using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuGfbxReportDTO : DtoBase<int>
    {
        public OuGfbxReportDTO()
        {
        }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime BeginTime { get; set; }

        [DataMember]
        public System.DateTime EndTime { get; set; }

        [DataMember]
        public int PatType { get; set; }

        [DataMember]
        public int TypeId { get; set; }

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
