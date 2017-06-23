using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class InEmrScore : EntityBase<int>
    {
        public InEmrScore()
        {    
        }

        public int? Emrqcitemid { get; set; }
        public int? Hospid { get; set; }
        public string Emritemscore { get; set; }
        public string Emrscore { get; set; }
        public bool? Isscore { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Partscore { get; set; }
    }
}
