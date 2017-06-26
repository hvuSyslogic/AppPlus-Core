using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsdocregtypeTemp36DTO : DtoBase<int>
    {
        public BsdocregtypeTemp36DTO()
        {
        }

        [DataMember]
        public string Mdinfo { get; set; }

        [DataMember]
        public string Tdinfo { get; set; }

        [DataMember]
        public string Wdinfo { get; set; }

        [DataMember]
        public string Tudinfo { get; set; }

        [DataMember]
        public string Fdinfo { get; set; }

        [DataMember]
        public string Stdinfo { get; set; }

        [DataMember]
        public string Sudinfo { get; set; }
    }
}
