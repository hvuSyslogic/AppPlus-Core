using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBedDTO : DtoBase<int>
    {
        public BsBedDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string RoomNo { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public short LsBall { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public bool IsAdd { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public short LsClass { get; set; }

        [DataMember]
        public bool? IsAddBed { get; set; }

        [DataMember]
        public string BedGroup { get; set; }

        [DataMember]
        public int? ItemId1 { get; set; }

        [DataMember]
        public int? ItemId2 { get; set; }

        [DataMember]
        public int? AddItemId { get; set; }
    }
}
