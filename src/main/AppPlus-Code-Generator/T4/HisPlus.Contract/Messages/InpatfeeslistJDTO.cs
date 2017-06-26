using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InpatfeeslistJDTO : DtoBase<int>
    {
        public InpatfeeslistJDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? BedId { get; set; }

        [DataMember]
        public System.DateTime? OutTime { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? LocIn { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public decimal? Deposit { get; set; }

        [DataMember]
        public decimal? NotPay { get; set; }

        [DataMember]
        public decimal? HasPay { get; set; }

        [DataMember]
        public decimal? Remain { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string InPatNo { get; set; }

        [DataMember]
        public decimal? AmountNoPay { get; set; }

        [DataMember]
        public decimal? AmountPayNoPay { get; set; }

        [DataMember]
        public decimal? DepositNoPay { get; set; }

        [DataMember]
        public decimal? DepositMz { get; set; }

        [DataMember]
        public decimal? FactGet { get; set; }

        [DataMember]
        public decimal? AllFactGet { get; set; }
    }
}
