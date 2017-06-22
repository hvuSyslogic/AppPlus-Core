using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblFieldDescDTO : DtoBase<int>
    {
        public GblFieldDescDTO()
        {
        }

        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
