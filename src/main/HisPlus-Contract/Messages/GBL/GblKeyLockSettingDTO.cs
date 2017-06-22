using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblKeyLockSettingDTO : DtoBase<int>
    {
        public GblKeyLockSettingDTO()
        {
        }

        public short KeyTypeId { get; set; }
        public string KeyValue { get; set; }
        public string WorkStationName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string LockIp { get; set; }
        public System.DateTime LockTime { get; set; }
        public int Spid { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
