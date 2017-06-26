using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsItemOps' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsItemOpDTO
    {
        public BsItemOpDTO()
        {
        }

        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public int? ItemId { get; set; }
    }
}
