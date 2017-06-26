using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InAdviceLongADTO : DtoBase<System.DateTime>
    {
        public InAdviceLongADTO()
        {
        }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public System.DateTime? SkinTime { get; set; }

        [DataMember]
        public string SkinTest { get; set; }

        [DataMember]
        public System.DateTime? ChkOperTime { get; set; }

        [DataMember]
        public int? ChkOperId { get; set; }

        [DataMember]
        public System.DateTime? EndOperTime { get; set; }

        [DataMember]
        public int? EndOperId { get; set; }

        [DataMember]
        public int? EndDoctorId { get; set; }

        [DataMember]
        public System.DateTime? AuthOperTime { get; set; }

        [DataMember]
        public int? AuthOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsOtherFee { get; set; }

        [DataMember]
        public short? Sn { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public short? FirstDay { get; set; }

        [DataMember]
        public short? LastDay { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }
    }
}
