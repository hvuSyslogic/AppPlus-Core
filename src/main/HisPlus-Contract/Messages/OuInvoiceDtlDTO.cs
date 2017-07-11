using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoiceDtlDTO : DtoBase<int>
    {
        public OuInvoiceDtlDTO()
        {
        }

        [DataMember]
        public int InvoId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public decimal DiscDiag { get; set; }

        [DataMember]
        public bool IsModiDisc { get; set; }

        [DataMember]
        public decimal DiscSelf { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public decimal AmountFact { get; set; }

        [DataMember]
        public decimal AmountSelf { get; set; }

        [DataMember]
        public decimal AmountTally { get; set; }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public short LsPerform { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public decimal LimitFee { get; set; }

        [DataMember]
        public int ExecLocId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int InvItemId { get; set; }

        [DataMember]
        public int FeeId { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public short? LsReportType { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int? RecipeItemId { get; set; }

        [DataMember]
        public int? RecipeGroupId { get; set; }

        [DataMember]
        public int? DocLocId { get; set; }

        [DataMember]
        public string Usagememo { get; set; }

        [DataMember]
        public int? Usageid { get; set; }

        [DataMember]
        public int? Formid { get; set; }

        [DataMember]
        public int? Frequencyid { get; set; }
    }
}
