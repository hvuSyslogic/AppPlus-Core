using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsUsageDTO : DtoBase<int>
    {
        public BsUsageDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string PrintName { get; set; }

        [DataMember]
        public string WbCode { get; set; }

        [DataMember]
        public string PyCode { get; set; }

        [DataMember]
        public short LsUseArea { get; set; }

        [DataMember]
        public short LsPrnFormType { get; set; }

        [DataMember]
        public bool IsPrintLabel { get; set; }

        [DataMember]
        public bool IsPrintReject { get; set; }

        [DataMember]
        public bool IsPrintDrug { get; set; }

        [DataMember]
        public bool IsPrintAst { get; set; }

        [DataMember]
        public bool IsPrintCure { get; set; }

        [DataMember]
        public bool IsPrintNurse { get; set; }

        [DataMember]
        public bool IsPrintExternal { get; set; }

        [DataMember]
        public bool IsPrintPush { get; set; }

        [DataMember]
        public bool IsPrintRejSkin { get; set; }

        [DataMember]
        public bool IsPrintDietetic { get; set; }

        [DataMember]
        public bool IsPrintBlood { get; set; }

        [DataMember]
        public bool IsMzDrop { get; set; }

        [DataMember]
        public bool IsMzReject { get; set; }

        [DataMember]
        public bool IsMzCure { get; set; }

        [DataMember]
        public short OrderBy { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short IconIndex { get; set; }

        [DataMember]
        public bool? IsPrintAtomization { get; set; }

        [DataMember]
        public string F5 { get; set; }

        [DataMember]
        public string F6 { get; set; }

        [DataMember]
        public string F7 { get; set; }

        [DataMember]
        public int? LsInOutType { get; set; }

        [DataMember]
        public bool? IsDrugTwoDay { get; set; }
    }
}
