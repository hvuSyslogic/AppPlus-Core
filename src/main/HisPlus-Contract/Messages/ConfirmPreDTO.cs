using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ConfirmPreDTO : DtoBase<int>
    {
        public ConfirmPreDTO()
        {
        }

        [DataMember]
        public string Presno { get; set; }

        [DataMember]
        public System.DateTime PresDate { get; set; }

        [DataMember]
        public int WindowNo { get; set; }

        [DataMember]
        public string PatientId { get; set; }

        [DataMember]
        public string Flag { get; set; }

        [DataMember]
        public string Fpno { get; set; }
    }
}
