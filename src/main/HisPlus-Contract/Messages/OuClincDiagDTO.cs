using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuClincDiagDTO : DtoBase<int>
    {
        public OuClincDiagDTO()
        {
        }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public int ListNum { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? LsDiagType { get; set; }

        [DataMember]
        public int? SequenceNum { get; set; }
    }
}
