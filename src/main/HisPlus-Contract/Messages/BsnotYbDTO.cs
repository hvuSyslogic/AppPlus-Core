using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsnotYbDTO : DtoBase<int>
    {
        public BsnotYbDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal? PriceIn { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
