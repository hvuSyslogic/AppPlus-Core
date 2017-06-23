using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CategoryLogDTO : DtoBase<int>
    {
        public CategoryLogDTO()
        {
        }

        public int CategoryId { get; set; }
        public int LogId { get; set; }
    }
}
