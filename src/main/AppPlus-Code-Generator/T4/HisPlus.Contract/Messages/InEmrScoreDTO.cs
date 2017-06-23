using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InEmrScoreDTO : DtoBase<int>
    {
        public InEmrScoreDTO()
        {
        }

        public int? Emrqcitemid { get; set; }
        public int? Hospid { get; set; }
        public string Emritemscore { get; set; }
        public string Emrscore { get; set; }
        public bool? Isscore { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Partscore { get; set; }
    }
}
