using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InLogInHospitalDTO : DtoBase<int>
    {
        public InLogInHospitalDTO()
        {
        }

        public int HospId { get; set; }
        public int LocationId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int? LsInIllness { get; set; }
    }
}
