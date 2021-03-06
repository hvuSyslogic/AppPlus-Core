using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

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
        public string Partscore { get; set; }
    }
}
