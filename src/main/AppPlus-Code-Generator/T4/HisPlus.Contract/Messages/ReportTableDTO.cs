using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class ReportTableDTO : DtoBase<decimal>
    {
        public ReportTableDTO()
        {
        }

        public string TabelName { get; set; }
        public string FiledName { get; set; }
        public string FiledZw { get; set; }
        public string FiledType { get; set; }
    }
}
