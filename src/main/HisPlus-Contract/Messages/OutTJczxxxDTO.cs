using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OutTJczxxxDTO : DtoBase<int>
    {
        public OutTJczxxxDTO()
        {
        }

        [DataMember]
        public decimal Eventid { get; set; }

        [DataMember]
        public string Jyjcdh { get; set; }

        [DataMember]
        public decimal? Zxzt { get; set; }

        [DataMember]
        public string Suid { get; set; }

        [DataMember]
        public string Bw { get; set; }

        [DataMember]
        public string Zdjg { get; set; }

        [DataMember]
        public string Reportid { get; set; }

        [DataMember]
        public System.DateTime? Bgsj { get; set; }

        [DataMember]
        public string Bgr { get; set; }

        [DataMember]
        public string Hzly { get; set; }

        [DataMember]
        public string Yysj { get; set; }

        [DataMember]
        public string Jgbg { get; set; }

        [DataMember]
        public System.DateTime? RowTime { get; set; }

        [DataMember]
        public string HostName { get; set; }
    }
}
