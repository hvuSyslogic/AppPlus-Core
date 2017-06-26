using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class RdFollowDTO : DtoBase<int>
    {
        public RdFollowDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public System.DateTime PlanTime { get; set; }

        [DataMember]
        public string VisitMan { get; set; }

        [DataMember]
        public string Purpose { get; set; }

        [DataMember]
        public short LsVisitType { get; set; }

        [DataMember]
        public bool IsVisited { get; set; }

        [DataMember]
        public string Process { get; set; }

        [DataMember]
        public string Result { get; set; }

        [DataMember]
        public string Other { get; set; }

        [DataMember]
        public string SumUp { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
