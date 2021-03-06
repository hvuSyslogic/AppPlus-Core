using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsBaseNurse : EntityBase<int>
    {
        public BsBaseNurse()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public string Memo { get; set; }
        public int? GroupMainId { get; set; }
        public int? GroupSubId { get; set; }
        public int? GroupSubId2 { get; set; }
        public string EngDesc { get; set; }
        public short? LsYbType { get; set; }
        public string YbMemo { get; set; }
    }
}
