using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CkQcLotDTO : DtoBase<int>
    {
        public CkQcLotDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string SampleNum { get; set; }

        [DataMember]
        public int MachineId { get; set; }

        [DataMember]
        public System.DateTime ExpiryDate { get; set; }

        [DataMember]
        public int CtrlId { get; set; }
    }
}
