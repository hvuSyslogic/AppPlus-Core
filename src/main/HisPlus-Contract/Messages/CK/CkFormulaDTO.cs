using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkFormulaDTO : DtoBase<int>
    {
        public CkFormulaDTO()
        {
        }

        public int TestId { get; set; }
        public string Formula { get; set; }
        public string Memo { get; set; }
    }
}
