using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblOnlinerDTO : DtoBase<int>
    {
        public GblOnlinerDTO()
        {
        }

        public int UserId { get; set; }
        public string WorkStationName { get; set; }
        public string LockIp { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
