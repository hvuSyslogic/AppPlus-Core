using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblPrinterDTO : DtoBase<int>
    {
        public GblPrinterDTO()
        {
        }

        [DataMember]
        public string Hostname { get; set; }

        [DataMember]
        public string ReportName { get; set; }

        [DataMember]
        public string PrinterName { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
