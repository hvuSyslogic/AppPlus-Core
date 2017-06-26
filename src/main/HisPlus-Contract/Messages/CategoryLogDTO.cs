using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CategoryLogDTO : DtoBase<int>
    {
        public CategoryLogDTO()
        {
        }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public int LogId { get; set; }
    }
}
