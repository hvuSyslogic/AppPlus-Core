using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoiceDTO : DtoBase<int>
    {
        public OuInvoiceDTO()
        {
        }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime InvoTime { get; set; }

        [DataMember]
        public decimal Beprice { get; set; }

        [DataMember]
        public decimal FactGet { get; set; }

        [DataMember]
        public decimal Insurance { get; set; }

        [DataMember]
        public decimal PaySelf { get; set; }

        [DataMember]
        public decimal AmountPay { get; set; }

        [DataMember]
        public decimal AddFee { get; set; }

        [DataMember]
        public string TallyNo { get; set; }

        [DataMember]
        public string Remark { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public string CancelMemo { get; set; }

        [DataMember]
        public int? InvoLastId { get; set; }

        [DataMember]
        public System.DateTime? TallyTime { get; set; }

        [DataMember]
        public System.DateTime? CancelTallyTime { get; set; }

        [DataMember]
        public decimal? ReAmount { get; set; }

        [DataMember]
        public System.DateTime? ReAmountDate { get; set; }

        [DataMember]
        public string ReAmountMemo { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public System.DateTime? CancelCheckTime { get; set; }

        [DataMember]
        public int? DocLocId { get; set; }

        [DataMember]
        public int? CancelHospital { get; set; }
    }
}
