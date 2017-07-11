using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InChinRicipExecDTO : DtoBase<int>
    {
        public InChinRicipExecDTO()
        {
        }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public string ExecTime { get; set; }
    }
}
