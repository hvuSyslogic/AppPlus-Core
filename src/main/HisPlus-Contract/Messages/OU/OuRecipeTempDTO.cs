using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class OuRecipeTempDTO : DtoBase<int>
    {
        public OuRecipeTempDTO()
        {
        }

        public int RecipeId { get; set; }
        public int MzRegId { get; set; }
        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public string Sex { get; set; }
        public short? Age { get; set; }
        public short? BabyMonth { get; set; }
        public string AddressHome { get; set; }
        public string IllDesc { get; set; }
        public string Name { get; set; }
        public short LsRepType { get; set; }
        public string RecipeNum { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public int LocationId { get; set; }
        public int DoctorId { get; set; }
        public short? HowMany { get; set; }
        public bool IsPriority { get; set; }
        public string Memo { get; set; }
        public bool IsPend { get; set; }
        public bool IsExecuted { get; set; }
        public string CardNo { get; set; }
        public string ContactPhone { get; set; }
        public string PyCode1 { get; set; }
        public string WbCode1 { get; set; }
        public string PyCode2 { get; set; }
        public string WbCode2 { get; set; }
        public string PyCode3 { get; set; }
        public string WbCode3 { get; set; }
        public decimal Amount { get; set; }
        public string DoctorName { get; set; }
        public string LocationName { get; set; }
        public int HospitalId { get; set; }
        public int RoomId { get; set; }
        public bool IsIssue { get; set; }
        public bool IsBack { get; set; }
        public string RoomWindowName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public System.DateTime? OperTime { get; set; }
        public int? LsReportType { get; set; }
        public int? DosageOperId { get; set; }
        public System.DateTime? DosageTime { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
    }
}
