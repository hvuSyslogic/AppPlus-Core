using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsScore : EntityBase<int>
    {
        public BsScore()
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
