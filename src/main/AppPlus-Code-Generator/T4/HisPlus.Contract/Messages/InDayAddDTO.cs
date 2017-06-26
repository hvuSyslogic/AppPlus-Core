using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InDayAddDTO : DtoBase<int>
    {
        public InDayAddDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public string BeginTime { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public int UnitId { get; set; }

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
