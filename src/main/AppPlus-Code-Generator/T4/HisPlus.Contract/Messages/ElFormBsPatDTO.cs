using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElFormBsPatDTO : DtoBase<int>
    {
        public ElFormBsPatDTO()
        {
        }

        [DataMember]
        public int PatMenuId { get; set; }

        [DataMember]
        public string BsPatFiled { get; set; }

        [DataMember]
        public short? NColumn { get; set; }

        [DataMember]
        public short? NRow { get; set; }

        [DataMember]
        public short? ColumnSpan { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public short? OrderBy { get; set; }

        [DataMember]
        public bool? IsActive { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public short? ColWidth { get; set; }

        [DataMember]
        public decimal? FontSize { get; set; }

        [DataMember]
        public string FontColor { get; set; }
    }
}
