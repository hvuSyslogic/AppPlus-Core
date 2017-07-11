using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblSettingDTO : DtoBase<int>
    {
        public GblSettingDTO()
        {
        }

        [DataMember]
        public string KeyNum { get; set; }

        [DataMember]
        public string SetValue { get; set; }

        [DataMember]
        public string Explain { get; set; }

        [DataMember]
        public short? Piority { get; set; }

        [DataMember]
        public string Basetable { get; set; }

        [DataMember]
        public bool? IsMutiselect { get; set; }

        [DataMember]
        public int? SystemId { get; set; }

        [DataMember]
        public System.DateTime? ModiTime { get; set; }

        [DataMember]
        public int? ModiOperId { get; set; }
    }
}
