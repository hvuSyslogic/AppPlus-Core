using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuExecuteDTO : DtoBase<int>
    {
        public OuExecuteDTO()
        {
        }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public short LsRepType { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public short GroupNum { get; set; }

        [DataMember]
        public short NDay { get; set; }

        [DataMember]
        public short NTime { get; set; }

        [DataMember]
        public int UsageId { get; set; }

        [DataMember]
        public bool? IsExecuted { get; set; }
    }
}
