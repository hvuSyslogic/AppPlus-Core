using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsBpPatientGroupDTO : DtoBase<int>
    {
        public BsBpPatientGroupDTO()
        {
        }

        public string PatientGroup { get; set; }
        public int? BpIllId { get; set; }
        public int? OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
