using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

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
    }
}
