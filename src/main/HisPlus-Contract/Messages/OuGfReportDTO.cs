using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuGfReportDTO : DtoBase<int>
    {
        public OuGfReportDTO()
        {
        }

        [DataMember]
        public int TallyGroupId { get; set; }

        [DataMember]
        public short LsreportFee { get; set; }

        [DataMember]
        public short ReportJz { get; set; }

        [DataMember]
        public short ReportBx { get; set; }

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
