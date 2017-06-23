using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RdHurtDTO : DtoBase<int>
    {
        public RdHurtDTO()
        {
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public int MzRegId { get; set; }
        public string HospitalCode { get; set; }
        public System.DateTime? HurtTime { get; set; }
        public System.DateTime? DiagDate { get; set; }
        public int? LsHurtReason { get; set; }
        public int? LsHurtCensus { get; set; }
        public string ElHurtReason { get; set; }
        public int? LsHurtPlace { get; set; }
        public string ElHurtPlace { get; set; }
        public int? LsHurtActivity { get; set; }
        public string ElHurtActivity { get; set; }
        public int? LsIsDeliberately { get; set; }
        public int? LsHurtNature { get; set; }
        public string ElHurtNature { get; set; }
        public int? LsHurtPosition { get; set; }
        public string ElHurtPosition { get; set; }
        public int? LsHurtDegree { get; set; }
        public string HurtClinical { get; set; }
        public int? LsHurtEnding { get; set; }
        public string ElHurtEnding { get; set; }
        public int? LsHurtProduct { get; set; }
        public int? LsHurtProducts { get; set; }
        public string ProductName { get; set; }
        public string ProductNames { get; set; }
        public string ProductType { get; set; }
        public string ProductTypes { get; set; }
        public string Typical { get; set; }
        public int? LocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
