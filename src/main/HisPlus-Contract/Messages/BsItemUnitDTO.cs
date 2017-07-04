using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemUnitDTO : DtoBase<int>
    {
        public BsItemUnitDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int UnitId { get; set; }

        [DataMember]
        public bool IsForYk { get; set; }

        [DataMember]
        public bool IsForYf { get; set; }

        [DataMember]
        public bool IsForRecipe { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
