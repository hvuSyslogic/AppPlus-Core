using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsitemcustomDTO : DtoBase<int>
    {
        public BsitemcustomDTO()
        {
        }

        [DataMember]
        public int Itemid { get; set; }

        [DataMember]
        public int? Reportid { get; set; }

        [DataMember]
        public string Customtype { get; set; }

        [DataMember]
        public int? Orderby { get; set; }

        [DataMember]
        public int? Iconindex { get; set; }

        [DataMember]
        public string Memo { get; set; }

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
