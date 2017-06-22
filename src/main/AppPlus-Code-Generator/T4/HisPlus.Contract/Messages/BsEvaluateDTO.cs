using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsEvaluate' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    public class BsEvaluateDTO
    {
        public BsEvaluateDTO()
        {
        }

        public string EvaluateName { get; set; }
        public string Py { get; set; }
        public string Name { get; set; }
    }
}
