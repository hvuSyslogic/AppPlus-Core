using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InHosMzIllDTO : DtoBase<int>
    {
        public InHosMzIllDTO()
        {
        }

        public int HospId { get; set; }
        public int ListNum { get; set; }
        public int? IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? LsInOut { get; set; }
        public short? LsWestChin { get; set; }
        public bool? IsInfect { get; set; }
        public bool? IsCoincidence { get; set; }
        public int? CheckOperId { get; set; }
        public System.DateTime? CheckTime { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public int? BpGroupId { get; set; }
        public bool? IsDg { get; set; }
        public bool? IsBp { get; set; }
    }
}
