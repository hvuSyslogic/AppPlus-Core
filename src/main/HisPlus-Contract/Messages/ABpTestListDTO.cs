using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ABpTestListDTO : DtoBase<int>
    {
        public ABpTestListDTO()
        {
        }

        [DataMember]
        public string ItemName { get; set; }

        [DataMember]
        public string Py { get; set; }

        [DataMember]
        public string Wb { get; set; }
    }
}
