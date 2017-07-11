using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class ElFormDtl : EntityBase<int>
    {
        public ElFormDtl()
        {    
        }

        public int PatMenuId { get; set; }
        public int? ElId { get; set; }
        public short? NColumn { get; set; }
        public short? NRow { get; set; }
        public short? ColumnSpan { get; set; }
        public string Title { get; set; }
        public bool? IsReadOnly { get; set; }
        public bool? IsRequire { get; set; }
        public string DefultValue { get; set; }
        public short? LsAlignment { get; set; }
        public short? OrderBy { get; set; }
        public bool? IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool? IsInherit { get; set; }
        public short? ColWidth { get; set; }
        public decimal? FontSize { get; set; }
        public string FontColor { get; set; }
    }
}
