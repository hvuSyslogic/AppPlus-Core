using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InAdviceWeekDayDTO : DtoBase<int>
    {
        public InAdviceWeekDayDTO()
        {
        }

        [DataMember]
        public int AdviceId { get; set; }

        [DataMember]
        public short WeekDay { get; set; }

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
