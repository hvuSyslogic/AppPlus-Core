using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuRecipeTempDTO : DtoBase<int>
    {
        public OuRecipeTempDTO()
        {
        }

        [DataMember]
        public int RecipeId { get; set; }

        [DataMember]
        public int MzRegId { get; set; }

        [DataMember]
        public string MzRegNo { get; set; }

        [DataMember]
        public System.DateTime RegTime { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public short? Age { get; set; }

        [DataMember]
        public short? BabyMonth { get; set; }

        [DataMember]
        public string AddressHome { get; set; }

        [DataMember]
        public string IllDesc { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public short LsRepType { get; set; }

        [DataMember]
        public string RecipeNum { get; set; }

        [DataMember]
        public System.DateTime RecipeTime { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int DoctorId { get; set; }

        [DataMember]
        public short? HowMany { get; set; }

        [DataMember]
        public bool IsPriority { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool IsPend { get; set; }

        [DataMember]
        public bool IsExecuted { get; set; }

        [DataMember]
        public string CardNo { get; set; }

        [DataMember]
        public string ContactPhone { get; set; }

        [DataMember]
        public string PyCode1 { get; set; }

        [DataMember]
        public string WbCode1 { get; set; }

        [DataMember]
        public string PyCode2 { get; set; }

        [DataMember]
        public string WbCode2 { get; set; }

        [DataMember]
        public string PyCode3 { get; set; }

        [DataMember]
        public string WbCode3 { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public string DoctorName { get; set; }

        [DataMember]
        public string LocationName { get; set; }

        [DataMember]
        public int HospitalId { get; set; }

        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public bool IsIssue { get; set; }

        [DataMember]
        public bool IsBack { get; set; }

        [DataMember]
        public string RoomWindowName { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? LsReportType { get; set; }

        [DataMember]
        public int? DosageOperId { get; set; }

        [DataMember]
        public System.DateTime? DosageTime { get; set; }

        [DataMember]
        public int? PatTypeId { get; set; }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public string InvoNo { get; set; }
    }
}
