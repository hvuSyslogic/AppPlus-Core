using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
