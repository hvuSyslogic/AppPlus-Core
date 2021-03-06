using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUsage : EntityBase<int>
    {
        public BsUsage()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short LsUseArea { get; set; }
        public short LsPrnFormType { get; set; }
        public bool IsPrintLabel { get; set; }
        public bool IsPrintReject { get; set; }
        public bool IsPrintDrug { get; set; }
        public bool IsPrintAst { get; set; }
        public bool IsPrintCure { get; set; }
        public bool IsPrintNurse { get; set; }
        public bool IsPrintExternal { get; set; }
        public bool IsPrintPush { get; set; }
        public bool IsPrintRejSkin { get; set; }
        public bool IsPrintDietetic { get; set; }
        public bool IsPrintBlood { get; set; }
        public bool IsMzDrop { get; set; }
        public bool IsMzReject { get; set; }
        public bool IsMzCure { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public bool? IsPrintAtomization { get; set; }
        public int? LsInOutType { get; set; }
        public bool? IsDrugTwoDay { get; set; }
    }
}
