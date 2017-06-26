using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdInfectiouDTO : DtoBase<int>
    {
        public RdInfectiouDTO()
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
        public short? LsCensus { get; set; }

        [DataMember]
        public short? LsZone { get; set; }

        [DataMember]
        public string Midwife { get; set; }

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
        public short? LsPreventive { get; set; }

        [DataMember]
        public string IllIdCor { get; set; }

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
        public int? JIllId { get; set; }

        [DataMember]
        public int? YIllId { get; set; }

        [DataMember]
        public int? BIllId { get; set; }

        [DataMember]
        public int? QIllId { get; set; }

        [DataMember]
        public string JName { get; set; }

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
        public int? IsWrite { get; set; }

        [DataMember]
        public int? Canceloperid { get; set; }

        [DataMember]
        public int? Chkoperid { get; set; }

        [DataMember]
        public bool? Printstart { get; set; }

        [DataMember]
        public System.DateTime? ChkOperTime { get; set; }

        [DataMember]
        public System.DateTime? CancelOperTime { get; set; }

        [DataMember]
        public short? Lscanceltype2 { get; set; }

        [DataMember]
        public int? Hospid { get; set; }

        [DataMember]
        public int? WorkType { get; set; }

        [DataMember]
        public string QilLness { get; set; }

        [DataMember]
        public int? AfpId { get; set; }
    }
}
