using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CategoryDTO : DtoBase<int>
    {
        public CategoryDTO()
        {
        }

        public string CategoryName { get; set; }
    }
}
