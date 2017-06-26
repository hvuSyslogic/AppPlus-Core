using AppPlus.Infrastructure.Contract.Messages;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain
{
    public class BsIllList : EntityBase<int>
    {
        public BsIllList()
        {    
        }

        public int? IllId { get; set; }
        public string IllName { get; set; }
        public int? GroupId { get; set; }
        public string PatientGroup { get; set; }
        public int? UnDrugId { get; set; }
        public string UnDrugName { get; set; }
        public int? GroupOrder { get; set; }
        public int? UndrugOrder { get; set; }
    }
}
