using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkReportDefineDTO : DtoBase<int>
    {
        public CkReportDefineDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? TestTypeId { get; set; }

        [DataMember]
        public byte[] ReportContent { get; set; }
    }
}
