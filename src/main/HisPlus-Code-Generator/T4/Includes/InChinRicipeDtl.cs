using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InChinRicipeDtl : EntityBase<int>
    {
        public InChinRicipeDtl()
        {    
        }

        public int RecipeId { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int UnitTakeId { get; set; }
        public short LsDecoctWay { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int? DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
