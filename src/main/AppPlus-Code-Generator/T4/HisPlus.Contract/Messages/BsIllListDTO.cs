using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsIllListDTO : DtoBase<int>
    {
        public BsIllListDTO()
        {
        }

        [DataMember]
        public int? IllId { get; set; }

        [DataMember]
        public string IllName { get; set; }

        [DataMember]
        public int? GroupId { get; set; }

        [DataMember]
        public string PatientGroup { get; set; }

        [DataMember]
        public int? UnDrugId { get; set; }

        [DataMember]
        public string UnDrugName { get; set; }

        [DataMember]
        public int? GroupOrder { get; set; }

        [DataMember]
        public int? UndrugOrder { get; set; }
    }
}
