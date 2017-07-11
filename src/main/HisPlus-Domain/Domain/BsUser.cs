using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsUser : EntityBase<int>
    {
        public BsUser()
        {    
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Reason { get; set; }
        public short LsInputWay { get; set; }
        public short IconIndex { get; set; }
        public bool? IsUserInputWb { get; set; }
        public bool? IsUserInputPy { get; set; }
        public bool? IsUserInputCode { get; set; }
        public bool? IsUserInputName { get; set; }
        public bool? IsUserInputStrokeCode { get; set; }
        public bool? IsUserInputEngDesc { get; set; }
        public string Introduce { get; set; }
        public string PicturePath { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int? LevelId { get; set; }
        public int? DocLevId { get; set; }
        public int? HospitalId { get; set; }
        public int? CareGroupId { get; set; }
        public int? CareGroupId1 { get; set; }
        public string CertIdNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public bool? IsUserInputF1 { get; set; }
    }
}
