using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
