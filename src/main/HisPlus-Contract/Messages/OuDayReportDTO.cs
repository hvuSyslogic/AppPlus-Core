using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuDayReportDTO : DtoBase<int>
    {
        public OuDayReportDTO()
        {
        }

        [DataMember]
        public string RtpNo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public decimal Beprice { get; set; }

        [DataMember]
        public decimal FactGet { get; set; }

        [DataMember]
        public decimal? InArrear { get; set; }

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
