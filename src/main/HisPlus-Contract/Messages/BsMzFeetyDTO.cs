using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsMzFeetyDTO : DtoBase<int>
    {
        public BsMzFeetyDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? InvItemId { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public string CheckType { get; set; }

        [DataMember]
        public short? CheckOrderby { get; set; }

        [DataMember]
        public string CheckGroup { get; set; }
    }
}
