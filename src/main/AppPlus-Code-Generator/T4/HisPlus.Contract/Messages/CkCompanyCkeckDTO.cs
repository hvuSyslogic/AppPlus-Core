using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkCompanyCkeckDTO : DtoBase<int>
    {
        public CkCompanyCkeckDTO()
        {
        }

        [DataMember]
        public int CompanyId { get; set; }

        [DataMember]
        public System.DateTime CkeckDate { get; set; }

        [DataMember]
        public string CkeckNo { get; set; }
    }
}
