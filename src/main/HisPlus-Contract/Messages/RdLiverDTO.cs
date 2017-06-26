using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdLiverDTO : DtoBase<int>
    {
        public RdLiverDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public short? LsCardType { get; set; }

        [DataMember]
        public short? LsCensus { get; set; }

        [DataMember]
        public string JName { get; set; }

        [DataMember]
        public short? LsZone { get; set; }

        [DataMember]
        public short? LsCancelType { get; set; }

        [DataMember]
        public System.DateTime? IllDate { get; set; }

        [DataMember]
        public System.DateTime? InTime { get; set; }

        [DataMember]
        public System.DateTime? DeadDate { get; set; }

        [DataMember]
        public System.DateTime? DiagDate { get; set; }

        [DataMember]
        public short? LsDiagType { get; set; }

        [DataMember]
        public short? LsPreventive { get; set; }

        [DataMember]
        public short? LsClinicType { get; set; }

        [DataMember]
        public short? LsIllSource { get; set; }

        [DataMember]
        public string Alt { get; set; }

        [DataMember]
        public string Tbil { get; set; }

        [DataMember]
        public short? LsKHavIgM { get; set; }

        [DataMember]
        public string HavRna { get; set; }

        [DataMember]
        public short? LsHbsAg { get; set; }

        [DataMember]
        public short? LsKHBs { get; set; }

        [DataMember]
        public short? LsHBeAg { get; set; }

        [DataMember]
        public short? LsKHBe { get; set; }

        [DataMember]
        public short? LsKHBc { get; set; }

        [DataMember]
        public short? LsKHBcIgM { get; set; }

        [DataMember]
        public string HbvDna { get; set; }

        [DataMember]
        public short? LsKHcv { get; set; }

        [DataMember]
        public string HcvRna { get; set; }

        [DataMember]
        public short? LsKHdvIgM { get; set; }

        [DataMember]
        public string KHdv { get; set; }

        [DataMember]
        public string HdvRna { get; set; }

        [DataMember]
        public short? LsKHevIgM { get; set; }

        [DataMember]
        public short? LsKHev { get; set; }

        [DataMember]
        public string HevRna { get; set; }

        [DataMember]
        public int? IllIdCor { get; set; }

        [DataMember]
        public string CancelMemo { get; set; }

        [DataMember]
        public string ReportUnit { get; set; }

        [DataMember]
        public int? LocId { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime? ReportDate { get; set; }

        [DataMember]
        public string ReportPerson { get; set; }

        [DataMember]
        public System.DateTime? JReportDate { get; set; }

        [DataMember]
        public string JReportPerson { get; set; }

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
    }
}
