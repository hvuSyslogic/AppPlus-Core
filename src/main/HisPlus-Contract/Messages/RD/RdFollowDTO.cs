using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class RdFollowDTO : DtoBase<int>
    {
        public RdFollowDTO()
        {
        }

        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int DoctorId { get; set; }
        public int OperId { get; set; }
        public string Code { get; set; }
        public System.DateTime PlanTime { get; set; }
        public string VisitMan { get; set; }
        public string Purpose { get; set; }
        public short LsVisitType { get; set; }
        public bool IsVisited { get; set; }
        public string Process { get; set; }
        public string Result { get; set; }
        public string Other { get; set; }
        public string SumUp { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
