using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InadvicenurseDTO : DtoBase<int>
    {
        public InadvicenurseDTO()
        {
        }

        [DataMember]
        public System.DateTime Advicetime { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int Hospid { get; set; }

        [DataMember]
        public int Groupnum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? Unittakeid { get; set; }

        [DataMember]
        public int? Frequencyid { get; set; }

        [DataMember]
        public int? Usageid { get; set; }

        [DataMember]
        public decimal Pricein { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int Unitinid { get; set; }

        [DataMember]
        public bool Isurgent { get; set; }

        [DataMember]
        public int Lsexecloc { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool Isauth { get; set; }

        [DataMember]
        public System.DateTime? Authopertime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public bool Islong { get; set; }

        [DataMember]
        public bool IsCancel { get; set; }

        [DataMember]
        public System.DateTime? Cancelopertime { get; set; }

        [DataMember]
        public int? CancelOperId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string YbType { get; set; }
    }
}
