using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class GblAutoUpdateOld : EntityBase<int>
    {
        public GblAutoUpdateOld()
        {    
        }

        public string PathName { get; set; }
        public byte[] FileContent { get; set; }
        public System.DateTime? OldVersion { get; set; }
        public System.DateTime NewVersion { get; set; }
        public string UpLoadHostName { get; set; }
        public string UpLoadIp { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string DownLoadHostNames { get; set; }
        public string HospitalIds { get; set; }
        public bool? IsChoose { get; set; }
        public string FileSize { get; set; }
    }
}
