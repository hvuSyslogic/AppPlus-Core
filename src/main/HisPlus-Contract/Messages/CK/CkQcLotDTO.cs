using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkQcLotDTO : DtoBase<int>
    {
        public CkQcLotDTO()
        {
        }

        public string Code { get; set; }
        public string SampleNum { get; set; }
        public int MachineId { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public int CtrlId { get; set; }
    }
}
