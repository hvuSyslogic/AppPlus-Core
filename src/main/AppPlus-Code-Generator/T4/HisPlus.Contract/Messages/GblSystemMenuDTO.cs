using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class GblSystemMenuDTO : DtoBase<int>
    {
        public GblSystemMenuDTO()
        {
        }

        public int SystemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? IconIndex { get; set; }
        public string Hint { get; set; }
        public string Shortcut { get; set; }
        public int? ParentId { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsMostUsed { get; set; }
        public bool? IsBeginGroup { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
