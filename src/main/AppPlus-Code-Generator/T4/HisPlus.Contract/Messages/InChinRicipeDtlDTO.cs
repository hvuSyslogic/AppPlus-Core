using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class InChinRicipeDtlDTO : DtoBase<int>
    {
        public InChinRicipeDtlDTO()
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
