using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblBaseTableItemDTO : DtoBase<int>
    {
        public GblBaseTableItemDTO()
        {
        }

        [DataMember]
        public int ParentId { get; set; }

        [DataMember]
        public string BaseTable { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string BllClassName { get; set; }

        [DataMember]
        public string ModelClassName { get; set; }

        [DataMember]
        public string ConfigType { get; set; }

        [DataMember]
        public bool IsTable { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public int? RoleId { get; set; }

        [DataMember]
        public string OrderField { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsToWmr { get; set; }
    }
}
