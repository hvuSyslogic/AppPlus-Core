using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CsServerRelationDTO : DtoBase<int>
    {
        public CsServerRelationDTO()
        {
        }

        public int SeverLocId { get; set; }
        public int BenefitLocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
