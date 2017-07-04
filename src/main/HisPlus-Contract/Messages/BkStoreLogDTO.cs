using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BkStoreLogDTO : DtoBase<int>
    {
        public BkStoreLogDTO()
        {
        }

        [DataMember]
        public string BkRegNo { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string TransactionNum { get; set; }

        [DataMember]
        public string BHosName { get; set; }

        [DataMember]
        public int? PayWayId { get; set; }

        [DataMember]
        public int? IdType { get; set; }
    }
}
