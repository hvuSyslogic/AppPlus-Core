using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class DgRoadIllDTO : DtoBase<int>
    {
        public DgRoadIllDTO()
        {
        }

        public int? IllId { get; set; }
        public int RoadId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
