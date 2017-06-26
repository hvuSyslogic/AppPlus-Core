using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class YbQueryDTO : DtoBase<int>
    {
        public YbQueryDTO()
        {
        }

        [DataMember]
        public string DesigCode { get; set; }

        [DataMember]
        public string PersonNum { get; set; }

        [DataMember]
        public string YbSeq { get; set; }

        [DataMember]
        public string DocumentNo { get; set; }

        [DataMember]
        public string TransType { get; set; }

        [DataMember]
        public string SerialNum { get; set; }

        [DataMember]
        public string ReceiveNum { get; set; }

        [DataMember]
        public string TotalAmount { get; set; }

        [DataMember]
        public string InsuranceAmount { get; set; }

        [DataMember]
        public string SuppleAmount { get; set; }

        [DataMember]
        public string CashPayment { get; set; }

        [DataMember]
        public string SelfAmount { get; set; }

        [DataMember]
        public string SomeSelfAmount { get; set; }

        [DataMember]
        public string EnterCosts { get; set; }

        [DataMember]
        public string ToPayStandard { get; set; }

        [DataMember]
        public string IntoCosts { get; set; }

        [DataMember]
        public string SelfPaid { get; set; }

        [DataMember]
        public string EnterInsuranceCosts { get; set; }

        [DataMember]
        public string SuppInsurancePays { get; set; }

        [DataMember]
        public string LimitSelfPaid { get; set; }

        [DataMember]
        public string Ntime { get; set; }

        [DataMember]
        public string DevelopersLogo { get; set; }

        [DataMember]
        public string SettlementDate { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? MzregId { get; set; }

        [DataMember]
        public int? HospId { get; set; }
    }
}
