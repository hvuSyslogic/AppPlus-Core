using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdBrainDeadDTO : DtoBase<int>
    {
        public RdBrainDeadDTO()
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
        public int? IcdId { get; set; }

        [DataMember]
        public short? LsCardType { get; set; }

        [DataMember]
        public short? LsCensus { get; set; }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public System.DateTime? DiagDate { get; set; }

        [DataMember]
        public short? LsIllBase { get; set; }

        [DataMember]
        public string LsIllType { get; set; }

        [DataMember]
        public System.DateTime? IllDate { get; set; }

        [DataMember]
        public short? LsLastTime { get; set; }

        [DataMember]
        public int? IllTimes { get; set; }

        [DataMember]
        public System.DateTime? DeadDate { get; set; }

        [DataMember]
        public string ImmediacyDead { get; set; }

        [DataMember]
        public string ElseIllness { get; set; }

        [DataMember]
        public string FormerlyIllness { get; set; }

        [DataMember]
        public System.DateTime? YDiagDate { get; set; }

        [DataMember]
        public string DeadCause { get; set; }

        [DataMember]
        public int? LocId { get; set; }

        [DataMember]
        public int? DeadIcd { get; set; }

        [DataMember]
        public int? ElseIllnessIcd { get; set; }

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
