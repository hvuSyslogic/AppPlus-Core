using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuInvoiceDtlADTO : DtoBase<System.DateTime>
    {
        public OuInvoiceDtlADTO()
        {
        }

        [DataMember]
        public decimal? AmountPay { get; set; }

        [DataMember]
        public int? LimitGroupId { get; set; }

        [DataMember]
        public int? FeeHsId { get; set; }

        [DataMember]
        public int? XdRpId { get; set; }

        [DataMember]
        public short? LsReportType { get; set; }

        [DataMember]
        public int? RecipeItemId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? RecipeGroupId { get; set; }

        [DataMember]
        public int? DocLocId { get; set; }
    }
}
