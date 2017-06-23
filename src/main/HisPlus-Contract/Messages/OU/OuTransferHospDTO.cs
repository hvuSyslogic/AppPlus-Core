using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuTransferHospDTO : DtoBase<int>
    {
        public OuTransferHospDTO()
        {
        }

        public string InPatNo { get; set; }
        public int? MzRegId { get; set; }
        public int? HospId { get; set; }
        public int HospitalId { get; set; }
        public System.DateTime OutTime { get; set; }
        public string Reason { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime? ReturnTime { get; set; }
        public string ReturnMemo { get; set; }
        public System.DateTime? ReturnOperTime { get; set; }
        public int? ReturnOperId { get; set; }
    }
}
