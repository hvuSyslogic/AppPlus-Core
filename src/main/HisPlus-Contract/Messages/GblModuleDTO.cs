using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblModuleDTO : DtoBase<int>
    {
        public GblModuleDTO()
        {
        }

        [DataMember]
        public int? FunctionId { get; set; }

        [DataMember]
        public int? MenuId { get; set; }

        [DataMember]
        public int OrderBy { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
