using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class BsIllListDTO : DtoBase<int>
    {
        public BsIllListDTO()
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
