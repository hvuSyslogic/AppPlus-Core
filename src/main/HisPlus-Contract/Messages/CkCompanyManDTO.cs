using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkCompanyManDTO : DtoBase<int>
    {
        public CkCompanyManDTO()
        {
        }

        [DataMember]
        public int CompanyGroupId { get; set; }

        [DataMember]
        public int PatId { get; set; }
    }
}
