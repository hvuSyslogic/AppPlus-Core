using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class LogDTO : DtoBase<int>
    {
        public LogDTO()
        {
        }

        [DataMember]
        public int? EventId { get; set; }

        [DataMember]
        public int Priority { get; set; }

        [DataMember]
        public string Severity { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public System.DateTime Timestamp { get; set; }

        [DataMember]
        public string MachineName { get; set; }

        [DataMember]
        public string AppDomainName { get; set; }

        [DataMember]
        public string ProcessId { get; set; }

        [DataMember]
        public string ProcessName { get; set; }

        [DataMember]
        public string ThreadName { get; set; }

        [DataMember]
        public string Win32ThreadId { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string FormattedMessage { get; set; }
    }
}
