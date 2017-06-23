using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InChinRicipExecDTO : DtoBase<int>
    {
        public InChinRicipExecDTO()
        {
        }

        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
