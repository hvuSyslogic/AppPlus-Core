using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdCancerDTO : DtoBase<int>
    {
        public RdCancerDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public int? LsCardType { get; set; }

        [DataMember]
        public int? LsCensus { get; set; }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public int? LsIllBase { get; set; }

        [DataMember]
        public System.DateTime? DiagDate { get; set; }

        [DataMember]
        public string PathologyType { get; set; }

        [DataMember]
        public int? FormerlyIllness { get; set; }

        [DataMember]
        public System.DateTime? YDiagDate { get; set; }

        [DataMember]
        public System.DateTime? DeadDate { get; set; }

        [DataMember]
        public string DeadCause { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public int? LocId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? ReciOperId { get; set; }

        [DataMember]
        public string ReportUnit { get; set; }

        [DataMember]
        public System.DateTime? ReportDate { get; set; }
    }
}
