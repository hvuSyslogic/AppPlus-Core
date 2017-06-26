using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InInvoiceDtlADTO : DtoBase<System.DateTime>
    {
        public InInvoiceDtlADTO()
        {
        }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public decimal? LimitFee { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int? LsReportType { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? CancelId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string HostName { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public string RegDate { get; set; }

        [DataMember]
        public int? GroupItemId { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public string AdviceName { get; set; }

        [DataMember]
        public int? MainDoctorId { get; set; }
    }
}
