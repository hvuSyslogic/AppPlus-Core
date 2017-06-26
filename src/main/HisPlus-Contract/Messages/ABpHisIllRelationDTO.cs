using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'A_BP_HIS_IllRelation' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class ABpHisIllRelationDTO
    {
        public ABpHisIllRelationDTO()
        {
        }

        [DataMember]
        public double? Xmlid { get; set; }

        [DataMember]
        public string Xmlname { get; set; }

        [DataMember]
        public string Engtitle { get; set; }

        [DataMember]
        public string Illname { get; set; }

        [DataMember]
        public string Illcode { get; set; }
    }
}
