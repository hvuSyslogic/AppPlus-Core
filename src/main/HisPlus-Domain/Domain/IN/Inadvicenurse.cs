using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class Inadvicenurse : EntityBase<int>
    {
        public Inadvicenurse()
        {    
        }

        public System.DateTime Advicetime { get; set; }
        public int LocationId { get; set; }
        public int Hospid { get; set; }
        public int Groupnum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int? Unittakeid { get; set; }
        public int? Frequencyid { get; set; }
        public int? Usageid { get; set; }
        public decimal Pricein { get; set; }
        public decimal Totality { get; set; }
        public int Unitinid { get; set; }
        public bool Isurgent { get; set; }
        public int Lsexecloc { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool Isauth { get; set; }
        public System.DateTime? Authopertime { get; set; }
        public int? AuthOperId { get; set; }
        public bool Islong { get; set; }
        public bool IsCancel { get; set; }
        public System.DateTime? Cancelopertime { get; set; }
        public int? CancelOperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
