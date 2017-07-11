using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUserImageDTO : DtoBase<int>
    {
        public BsUserImageDTO()
        {
        }
    }
}
