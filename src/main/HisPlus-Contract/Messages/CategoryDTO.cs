using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CategoryDTO : DtoBase<int>
    {
        public CategoryDTO()
        {
        }

        [DataMember]
        public string CategoryName { get; set; }
    }
}
