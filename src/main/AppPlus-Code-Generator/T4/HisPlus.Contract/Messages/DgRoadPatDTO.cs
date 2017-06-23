using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DgRoadPatDTO : DtoBase<int>
    {
        public DgRoadPatDTO()
        {
        }

        public int? HospId { get; set; }
        public int RoadId { get; set; }
        public int? OperId { get; set; }
        public System.DateTime? OperTime { get; set; }
        public bool? IsChk { get; set; }
        public System.DateTime? ChkOperTime { get; set; }
        public int? ChkOperId { get; set; }
    }
}
