using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class ElFormBsPat : EntityBase<int>
    {
        public ElFormBsPat()
        {    
        }

        public int PatMenuId { get; set; }
        public string BsPatFiled { get; set; }
        public short? NColumn { get; set; }
        public short? NRow { get; set; }
        public short? ColumnSpan { get; set; }
        public string Title { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short? ColWidth { get; set; }
        public decimal? FontSize { get; set; }
        public string FontColor { get; set; }
    }
}
