using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuInCarDTO : DtoBase<int>
    {
        public OuInCarDTO()
        {
        }

        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public int DoctorId { get; set; }
        public int NurseOperId { get; set; }
        public int DriverOperId { get; set; }
        public string CarNumber { get; set; }
        public System.DateTime CarTime { get; set; }
        public decimal Distance { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
