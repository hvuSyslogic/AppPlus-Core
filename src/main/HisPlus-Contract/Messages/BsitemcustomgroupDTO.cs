using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsitemcustomgroupDTO : DtoBase<int>
    {
        public BsitemcustomgroupDTO()
        {
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Orderby { get; set; }

        [DataMember]
        public int Isactive { get; set; }

        [DataMember]
        public int Lsoutorin { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int Iconindex { get; set; }
    }
}
