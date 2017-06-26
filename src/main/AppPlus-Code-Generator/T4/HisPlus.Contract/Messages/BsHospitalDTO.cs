using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsHospitalDTO : DtoBase<int>
    {
        public BsHospitalDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int AreaId { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public decimal? Area { get; set; }

        [DataMember]
        public decimal? Farthest { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int? ResidentPopulation { get; set; }

        [DataMember]
        public int? TentPopulation { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public short IconIndex { get; set; }
    }
}
