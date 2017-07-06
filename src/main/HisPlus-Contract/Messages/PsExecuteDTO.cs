using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class PsExecuteDTO : DtoBase<int>
    {
        public PsExecuteDTO()
        {
        }

        [DataMember]
        public string ApplyId { get; set; }

        [DataMember]
        public int? RecipeId { get; set; }

        [DataMember]
        public bool? IsExecuted { get; set; }

        [DataMember]
        public System.DateTime? ExecutedTime { get; set; }

        [DataMember]
        public int? ExecutedOperId { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }
    }
}
