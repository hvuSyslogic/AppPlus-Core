using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ABpDrugItemListDTO : DtoBase<int>
    {
        public ABpDrugItemListDTO()
        {
        }

        [DataMember]
        public string Py { get; set; }

        [DataMember]
        public string Wb { get; set; }
    }
}
