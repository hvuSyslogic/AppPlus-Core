using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OulInvoiceRegDTO : DtoBase<int>
    {
        public OulInvoiceRegDTO()
        {
        }

        [DataMember]
        public string InvoNo { get; set; }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public System.DateTime InvoTime { get; set; }

        [DataMember]
        public decimal RegFee { get; set; }

        [DataMember]
        public decimal DiagnoFee { get; set; }

        [DataMember]
        public decimal ZyFee { get; set; }

        [DataMember]
        public decimal OtherFee1 { get; set; }

        [DataMember]
        public decimal OtherFee2 { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? CancelTime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public int? InvoLastId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int? RegTypeId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public System.DateTime? CheckTime { get; set; }

        [DataMember]
        public System.DateTime? CancelCheckTime { get; set; }

        [DataMember]
        public int? DocLocId { get; set; }

        [DataMember]
        public string OrderWxid { get; set; }

        [DataMember]
        public bool? IsRegDoctorTemp { get; set; }
    }
}
