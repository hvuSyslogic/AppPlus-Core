using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBacteriaDrugDTO : DtoBase<int>
    {
        public BsBacteriaDrugDTO()
        {
        }

        [DataMember]
        public int BactriaId { get; set; }

        [DataMember]
        public int DrugId { get; set; }
    }
}
