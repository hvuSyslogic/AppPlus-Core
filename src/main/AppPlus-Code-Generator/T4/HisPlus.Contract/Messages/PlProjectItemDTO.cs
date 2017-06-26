using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PlProjectItemDTO : DtoBase<int>
    {
        public PlProjectItemDTO()
        {
        }

        [DataMember]
        public int ProjId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short Hours { get; set; }

        [DataMember]
        public System.DateTime? BeginPlan { get; set; }

        [DataMember]
        public System.DateTime? EndPlan { get; set; }

        [DataMember]
        public bool? IsClose { get; set; }

        [DataMember]
        public short? HoursFact { get; set; }

        [DataMember]
        public System.DateTime? EndFact { get; set; }

        [DataMember]
        public int? ChargeOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
