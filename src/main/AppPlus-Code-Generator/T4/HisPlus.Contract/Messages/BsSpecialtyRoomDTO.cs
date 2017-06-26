using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsSpecialtyRoomDTO : DtoBase<int>
    {
        public BsSpecialtyRoomDTO()
        {
        }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int? Hospitalid { get; set; }

        [DataMember]
        public int? Locationid { get; set; }

        [DataMember]
        public string Wbcode { get; set; }

        [DataMember]
        public string Pycode { get; set; }

        [DataMember]
        public int Orderby { get; set; }

        [DataMember]
        public int Isactive { get; set; }

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
