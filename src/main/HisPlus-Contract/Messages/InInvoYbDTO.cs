using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InInvoYbDTO : DtoBase<int>
    {
        public InInvoYbDTO()
        {
        }

        [DataMember]
        public int? InvoId { get; set; }

        [DataMember]
        public decimal? FactYp { get; set; }

        [DataMember]
        public decimal? FactJz { get; set; }

        [DataMember]
        public decimal? AllFactYp { get; set; }

        [DataMember]
        public decimal? AllFactJz { get; set; }

        [DataMember]
        public decimal? OtherFact { get; set; }

        [DataMember]
        public decimal? YbDisc { get; set; }

        [DataMember]
        public decimal? Insurance { get; set; }

        [DataMember]
        public decimal? UnderLine { get; set; }

        [DataMember]
        public decimal? InsuranceB1 { get; set; }

        [DataMember]
        public decimal? InsuranceB2 { get; set; }

        [DataMember]
        public decimal? InsuranceB3 { get; set; }

        [DataMember]
        public decimal? PaySelf { get; set; }

        [DataMember]
        public decimal? SelfPayDisc { get; set; }

        [DataMember]
        public decimal? SelfPayB1 { get; set; }

        [DataMember]
        public decimal? SelfPayB2 { get; set; }

        [DataMember]
        public decimal? SelfPayB3 { get; set; }

        [DataMember]
        public decimal? OutTopSelfFee { get; set; }

        [DataMember]
        public decimal? SelfFee { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public decimal? BchzylbxAmount { get; set; }

        [DataMember]
        public string AccountAttribute { get; set; }

        [DataMember]
        public decimal? BcProportion { get; set; }

        [DataMember]
        public decimal? FdAmount { get; set; }

        [DataMember]
        public string MedicalNo { get; set; }

        [DataMember]
        public decimal? NdybcAmount { get; set; }

        [DataMember]
        public decimal? TgProportion { get; set; }

        [DataMember]
        public decimal? WbhProportion { get; set; }

        [DataMember]
        public decimal? ZyyProportion { get; set; }

        [DataMember]
        public decimal? ZzProportion { get; set; }

        [DataMember]
        public decimal? KbcAmount { get; set; }

        [DataMember]
        public decimal? KbcA1 { get; set; }

        [DataMember]
        public decimal? KbcA2 { get; set; }

        [DataMember]
        public decimal? KbcA3 { get; set; }

        [DataMember]
        public decimal? KbcA4 { get; set; }

        [DataMember]
        public decimal? KbcA5 { get; set; }

        [DataMember]
        public decimal? KbcA6 { get; set; }

        [DataMember]
        public decimal? KbcA12 { get; set; }

        [DataMember]
        public decimal? KbcA13 { get; set; }

        [DataMember]
        public decimal? KbcA16 { get; set; }

        [DataMember]
        public decimal? KbcA17 { get; set; }

        [DataMember]
        public decimal? KbcA18 { get; set; }

        [DataMember]
        public decimal? KbcA19 { get; set; }

        [DataMember]
        public decimal? KbcA20 { get; set; }

        [DataMember]
        public decimal? SjbcA1 { get; set; }

        [DataMember]
        public decimal? SjbcA2 { get; set; }

        [DataMember]
        public decimal? SjbcA3 { get; set; }

        [DataMember]
        public decimal? SjbcA4 { get; set; }

        [DataMember]
        public decimal? SjbcA5 { get; set; }

        [DataMember]
        public decimal? SjbcA6 { get; set; }

        [DataMember]
        public decimal? SjbcA12 { get; set; }

        [DataMember]
        public decimal? SjbcA13 { get; set; }

        [DataMember]
        public decimal? SjbcA16 { get; set; }

        [DataMember]
        public decimal? SjbcA17 { get; set; }

        [DataMember]
        public decimal? SjbcA18 { get; set; }

        [DataMember]
        public decimal? SjbcA19 { get; set; }

        [DataMember]
        public decimal? SjbcA20 { get; set; }

        [DataMember]
        public decimal? OriginalAmount { get; set; }

        [DataMember]
        public decimal? OriginalA1 { get; set; }

        [DataMember]
        public decimal? OriginalA2 { get; set; }

        [DataMember]
        public decimal? OriginalA3 { get; set; }

        [DataMember]
        public decimal? OriginalA4 { get; set; }

        [DataMember]
        public decimal? OriginalA5 { get; set; }

        [DataMember]
        public decimal? OriginalA6 { get; set; }

        [DataMember]
        public decimal? OriginalA12 { get; set; }

        [DataMember]
        public decimal? OriginalA13 { get; set; }

        [DataMember]
        public decimal? OriginalA16 { get; set; }

        [DataMember]
        public decimal? OriginalA17 { get; set; }

        [DataMember]
        public decimal? OriginalA18 { get; set; }

        [DataMember]
        public decimal? OriginalA19 { get; set; }

        [DataMember]
        public decimal? OriginalA20 { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public string F8 { get; set; }

        [DataMember]
        public System.DateTime? InvoYbTime { get; set; }
    }
}
