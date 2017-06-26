using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OutTJczxxx : EntityBase<int>
    {
        public OutTJczxxx()
        {    
        }

        public decimal Eventid { get; set; }
        public string Jyjcdh { get; set; }
        public decimal? Zxzt { get; set; }
        public string Suid { get; set; }
        public string Bw { get; set; }
        public string Zdjg { get; set; }
        public string Reportid { get; set; }
        public System.DateTime? Bgsj { get; set; }
        public string Bgr { get; set; }
        public string Hzly { get; set; }
        public string Yysj { get; set; }
        public string Jgbg { get; set; }
        public System.DateTime? RowTime { get; set; }
        public string HostName { get; set; }
    }
}
