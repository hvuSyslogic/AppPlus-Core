using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsBpCureDtlDTO : DtoBase<int>
    {
        public BsBpCureDtlDTO()
        {
        }

        public int? CureId { get; set; }
        public int? BpItemId { get; set; }
        public int? TypeCode { get; set; }
        public int? RelationCode { get; set; }
        public string WayCode { get; set; }
        public string Remark { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
    }
}