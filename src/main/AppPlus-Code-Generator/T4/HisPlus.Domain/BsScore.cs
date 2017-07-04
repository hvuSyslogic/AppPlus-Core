using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

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
    }
}
