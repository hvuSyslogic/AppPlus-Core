using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdInfectStdDTO : DtoBase<int>
    {
        public RdInfectStdDTO()
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
        public short? LsCardType { get; set; }

        [DataMember]
        public int? Gestation { get; set; }

        [DataMember]
        public short? LsZone { get; set; }

        [DataMember]
        public short? LsCancelType { get; set; }

        [DataMember]
        public System.DateTime? IllDate { get; set; }

        [DataMember]
        public System.DateTime? DiagDate { get; set; }

        [DataMember]
        public System.DateTime? DeadDate { get; set; }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public string LsClincSymptom { get; set; }

        [DataMember]
        public string ReportUnit { get; set; }

        [DataMember]
        public int? IllIdCor { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short? LsCTrust { get; set; }

        [DataMember]
        public short? LsCTiter { get; set; }

        [DataMember]
        public short? LsCtppa { get; set; }

        [DataMember]
        public short? LsCOther { get; set; }

        [DataMember]
        public short? LsETrust { get; set; }

        [DataMember]
        public short? LsETiter { get; set; }

        [DataMember]
        public short? LsEtppa { get; set; }

        [DataMember]
        public short? LsEIgM { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string JName { get; set; }

        [DataMember]
        public int? LocId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? ReciOperId { get; set; }

        [DataMember]
        public System.DateTime? ReportDate { get; set; }
    }
}
