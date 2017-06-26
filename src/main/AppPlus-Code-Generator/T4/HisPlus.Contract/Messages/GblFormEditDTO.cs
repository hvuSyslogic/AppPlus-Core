using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblFormEditDTO : DtoBase<int>
    {
        public GblFormEditDTO()
        {
        }

        [DataMember]
        public string FormName { get; set; }

        [DataMember]
        public string FiledName { get; set; }

        [DataMember]
        public bool? IsAdd { get; set; }

        [DataMember]
        public string ToolTip { get; set; }

        [DataMember]
        public bool? IsExcept { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
