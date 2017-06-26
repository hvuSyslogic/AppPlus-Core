using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDrugReqdtlADTO : DtoBase<System.DateTime>
    {
        public InDrugReqdtlADTO()
        {
        }

        [DataMember]
        public int? UnitTake { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public int? ConfirmOperId { get; set; }

        [DataMember]
        public System.DateTime? ConfirmOperTime { get; set; }

        [DataMember]
        public int? DetailId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? ExecuteId { get; set; }

        [DataMember]
        public string RegDate { get; set; }
    }
}
