using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblLastIdDTO : DtoBase<int>
    {
        public GblLastIdDTO()
        {
        }

        public string TableName { get; set; }
        public int? LastId { get; set; }
        public System.DateTime? LastTime { get; set; }
    }
}
