using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class TrInHosInfo : EntityBase<int>
    {
        public TrInHosInfo()
        {    
        }

        public int HospId { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public System.DateTime? InTime { get; set; }
        public System.DateTime? OutTime { get; set; }
        public int? LocationId { get; set; }
        public int? BedId { get; set; }
        public short? LsInStatus { get; set; }
        public int? LocIn { get; set; }
        public string Residence { get; set; }
        public int? PatTypeId { get; set; }
        public int? DoctorId { get; set; }
        public string IdCardNo { get; set; }
        public short? LsMarriage { get; set; }
    }
}
