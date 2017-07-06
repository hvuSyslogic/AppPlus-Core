using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkCompanyGroupDTO : DtoBase<int>
    {
        public CkCompanyGroupDTO()
        {
        }

        [DataMember]
        public int CompanyId { get; set; }

        [DataMember]
        public int GroupId { get; set; }
    }
}
