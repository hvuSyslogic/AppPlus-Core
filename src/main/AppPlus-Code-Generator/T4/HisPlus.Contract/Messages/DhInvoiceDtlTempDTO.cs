using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DhInvoiceDtlTempDTO : DtoBase<int>
    {
        public DhInvoiceDtlTempDTO()
        {
        }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public short LsInOut { get; set; }

        [DataMember]
        public string ItemCode { get; set; }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public decimal? Price { get; set; }

        [DataMember]
        public string LimitName { get; set; }

        [DataMember]
        public int? FeeId { get; set; }

        [DataMember]
        public string FeetyName { get; set; }

        [DataMember]
        public string InvFeetyName { get; set; }

        [DataMember]
        public string AccountName { get; set; }

        [DataMember]
        public string UnitName { get; set; }

        [DataMember]
        public decimal? Totality { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string Location1 { get; set; }

        [DataMember]
        public string Location2 { get; set; }

        [DataMember]
        public string Location3 { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public string DocLevel { get; set; }

        [DataMember]
        public System.DateTime? RegOperTime { get; set; }

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
