using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class CsInWorkLogDTO : DtoBase<int>
    {
        public CsInWorkLogDTO()
        {
        }

        [DataMember]
        public string YearMonth { get; set; }

        [DataMember]
        public int LocId { get; set; }

        [DataMember]
        public int? OriginalNum { get; set; }

        [DataMember]
        public int? AdmittedOutps { get; set; }

        [DataMember]
        public int? FromOtherDept { get; set; }

        [DataMember]
        public int? TotalInHospitalDays { get; set; }

        [DataMember]
        public int? TotalInDeptDays { get; set; }

        [DataMember]
        public int? TransDeptNum { get; set; }

        [DataMember]
        public int? TotalBedUsedDays { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? InputTime { get; set; }

        [DataMember]
        public decimal? BedUsedRates { get; set; }

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
