using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DhInvoiceTempDTO : DtoBase<int>
    {
        public DhInvoiceTempDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public short LsInOut { get; set; }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public System.DateTime InvoTime { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string OperName { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string PatientName { get; set; }

        [DataMember]
        public string RegTypeName { get; set; }

        [DataMember]
        public short? InDays { get; set; }

        [DataMember]
        public string PatTypeCode { get; set; }

        [DataMember]
        public string PatType1 { get; set; }

        [DataMember]
        public string PatType2 { get; set; }

        [DataMember]
        public string PatType3 { get; set; }

        [DataMember]
        public string IcdCode { get; set; }

        [DataMember]
        public string Illness { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

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
