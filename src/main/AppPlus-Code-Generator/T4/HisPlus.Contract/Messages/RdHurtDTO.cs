using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdHurtDTO : DtoBase<int>
    {
        public RdHurtDTO()
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
        public int MzRegId { get; set; }

        [DataMember]
        public string HospitalCode { get; set; }

        [DataMember]
        public System.DateTime? HurtTime { get; set; }

        [DataMember]
        public System.DateTime? DiagDate { get; set; }

        [DataMember]
        public int? LsHurtReason { get; set; }

        [DataMember]
        public int? LsHurtCensus { get; set; }

        [DataMember]
        public string ElHurtReason { get; set; }

        [DataMember]
        public int? LsHurtPlace { get; set; }

        [DataMember]
        public string ElHurtPlace { get; set; }

        [DataMember]
        public int? LsHurtActivity { get; set; }

        [DataMember]
        public string ElHurtActivity { get; set; }

        [DataMember]
        public int? LsIsDeliberately { get; set; }

        [DataMember]
        public int? LsHurtNature { get; set; }

        [DataMember]
        public string ElHurtNature { get; set; }

        [DataMember]
        public int? LsHurtPosition { get; set; }

        [DataMember]
        public string ElHurtPosition { get; set; }

        [DataMember]
        public int? LsHurtDegree { get; set; }

        [DataMember]
        public string HurtClinical { get; set; }

        [DataMember]
        public int? LsHurtEnding { get; set; }

        [DataMember]
        public string ElHurtEnding { get; set; }

        [DataMember]
        public int? LsHurtProduct { get; set; }

        [DataMember]
        public int? LsHurtProducts { get; set; }

        [DataMember]
        public string ProductName { get; set; }

        [DataMember]
        public string ProductNames { get; set; }

        [DataMember]
        public string ProductType { get; set; }

        [DataMember]
        public string ProductTypes { get; set; }

        [DataMember]
        public string Typical { get; set; }

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
    }
}
