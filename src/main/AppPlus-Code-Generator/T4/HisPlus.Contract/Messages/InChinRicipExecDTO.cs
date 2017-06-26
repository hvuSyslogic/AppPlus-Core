using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

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

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
