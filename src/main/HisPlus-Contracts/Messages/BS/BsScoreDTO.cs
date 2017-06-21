using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsScoreDTO : DtoBase<int>
    {
        public BsScoreDTO()
        {
        }

        public int UserId { get; set; }
        public int TestPaperId { get; set; }
        public int Score { get; set; }
        public string Answer { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
