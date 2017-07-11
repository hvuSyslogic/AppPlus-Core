using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class InInvoYb : EntityBase<int>
    {
        public InInvoYb()
        {    
        }

        public int? InvoId { get; set; }
        public decimal? FactYp { get; set; }
        public decimal? FactJz { get; set; }
        public decimal? AllFactYp { get; set; }
        public decimal? AllFactJz { get; set; }
        public decimal? OtherFact { get; set; }
        public decimal? YbDisc { get; set; }
        public decimal? Insurance { get; set; }
        public decimal? UnderLine { get; set; }
        public decimal? InsuranceB1 { get; set; }
        public decimal? InsuranceB2 { get; set; }
        public decimal? InsuranceB3 { get; set; }
        public decimal? PaySelf { get; set; }
        public decimal? SelfPayDisc { get; set; }
        public decimal? SelfPayB1 { get; set; }
        public decimal? SelfPayB2 { get; set; }
        public decimal? SelfPayB3 { get; set; }
        public decimal? OutTopSelfFee { get; set; }
        public decimal? SelfFee { get; set; }
        public decimal? BchzylbxAmount { get; set; }
        public string AccountAttribute { get; set; }
        public decimal? BcProportion { get; set; }
        public decimal? FdAmount { get; set; }
        public string MedicalNo { get; set; }
        public decimal? NdybcAmount { get; set; }
        public decimal? TgProportion { get; set; }
        public decimal? WbhProportion { get; set; }
        public decimal? ZyyProportion { get; set; }
        public decimal? ZzProportion { get; set; }
        public decimal? KbcAmount { get; set; }
        public decimal? KbcA1 { get; set; }
        public decimal? KbcA2 { get; set; }
        public decimal? KbcA3 { get; set; }
        public decimal? KbcA4 { get; set; }
        public decimal? KbcA5 { get; set; }
        public decimal? KbcA6 { get; set; }
        public decimal? KbcA12 { get; set; }
        public decimal? KbcA13 { get; set; }
        public decimal? KbcA16 { get; set; }
        public decimal? KbcA17 { get; set; }
        public decimal? KbcA18 { get; set; }
        public decimal? KbcA19 { get; set; }
        public decimal? KbcA20 { get; set; }
        public decimal? SjbcA1 { get; set; }
        public decimal? SjbcA2 { get; set; }
        public decimal? SjbcA3 { get; set; }
        public decimal? SjbcA4 { get; set; }
        public decimal? SjbcA5 { get; set; }
        public decimal? SjbcA6 { get; set; }
        public decimal? SjbcA12 { get; set; }
        public decimal? SjbcA13 { get; set; }
        public decimal? SjbcA16 { get; set; }
        public decimal? SjbcA17 { get; set; }
        public decimal? SjbcA18 { get; set; }
        public decimal? SjbcA19 { get; set; }
        public decimal? SjbcA20 { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal? OriginalA1 { get; set; }
        public decimal? OriginalA2 { get; set; }
        public decimal? OriginalA3 { get; set; }
        public decimal? OriginalA4 { get; set; }
        public decimal? OriginalA5 { get; set; }
        public decimal? OriginalA6 { get; set; }
        public decimal? OriginalA12 { get; set; }
        public decimal? OriginalA13 { get; set; }
        public decimal? OriginalA16 { get; set; }
        public decimal? OriginalA17 { get; set; }
        public decimal? OriginalA18 { get; set; }
        public decimal? OriginalA19 { get; set; }
        public decimal? OriginalA20 { get; set; }
        public int? HospId { get; set; }
        public System.DateTime? InvoYbTime { get; set; }
        public string YbPatType { get; set; }
    }
}
