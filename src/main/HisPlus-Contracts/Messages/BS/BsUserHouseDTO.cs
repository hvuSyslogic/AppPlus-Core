using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsUserHouseDTO : DtoBase<int>
    {
        public BsUserHouseDTO()
        {
        }

        public int OperId { get; set; }
        public int HouseId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
