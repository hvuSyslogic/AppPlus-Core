using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemYbDTO : DtoBase<int>
    {
        public BsItemYbDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int TallyGroupId { get; set; }

        [DataMember]
        public string YbCode { get; set; }

        [DataMember]
        public string YbDesc { get; set; }

        [DataMember]
        public short LsYbType { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short? LsAuthstatus { get; set; }

        [DataMember]
        public string DrugCode { get; set; }

        [DataMember]
        public string YblimitCue { get; set; }
    }
}
