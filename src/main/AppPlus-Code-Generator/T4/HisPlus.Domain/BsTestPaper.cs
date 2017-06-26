using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsTestPaper : EntityBase<int>
    {
        public BsTestPaper()
        {    
        }

        public string Name { get; set; }
        public int UserId { get; set; }
        public System.DateTime GenerateTime { get; set; }
        public string QuestionId { get; set; }
        public string UsersId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
