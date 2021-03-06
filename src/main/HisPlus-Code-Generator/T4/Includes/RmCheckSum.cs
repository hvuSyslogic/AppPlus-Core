using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class RmCheckSum : EntityBase<int>
    {
        public RmCheckSum()
        {    
        }

        public int CheckId { get; set; }
        public string SumFor { get; set; }
        public decimal ApplyIn { get; set; }
        public decimal MzBackIn { get; set; }
        public decimal ZyBackIn { get; set; }
        public decimal PyIn { get; set; }
        public decimal MoveIn { get; set; }
        public decimal OtherIn { get; set; }
        public decimal MoveOut { get; set; }
        public decimal MzOut { get; set; }
        public decimal ZyOut { get; set; }
        public decimal PkOut { get; set; }
        public decimal LoseOut { get; set; }
        public decimal BackOut { get; set; }
        public decimal OtherOut { get; set; }
        public decimal AdjustAmouUp { get; set; }
        public decimal AdjustAmouDn { get; set; }
        public decimal CheckAmou { get; set; }
        public decimal BalanceAmou { get; set; }
        public decimal RecipeOut { get; set; }
        public decimal KsBackIn { get; set; }
        public decimal KsOut { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
