using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InChinRicipeDTO : DtoBase<int>
    {
        public InChinRicipeDTO()
        {
        }

        [DataMember]
        public string RecipeNo { get; set; }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public short DrugNum { get; set; }

        [DataMember]
        public short DecoctNum { get; set; }

        [DataMember]
        public bool IsConfirm { get; set; }

        [DataMember]
        public short LsCookSelf { get; set; }

        [DataMember]
        public int? ConfirmOperId { get; set; }

        [DataMember]
        public System.DateTime? ConfirmOperTime { get; set; }

        [DataMember]
        public bool IsBack { get; set; }

        [DataMember]
        public bool IsPrint { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public bool? IsPriority { get; set; }

        [DataMember]
        public bool? IsAuth { get; set; }

        [DataMember]
        public System.DateTime? BackTime { get; set; }

        [DataMember]
        public short? CookMinute { get; set; }

        [DataMember]
        public short? LsFire { get; set; }

        [DataMember]
        public int? AdviceLocationId { get; set; }
    }
}
