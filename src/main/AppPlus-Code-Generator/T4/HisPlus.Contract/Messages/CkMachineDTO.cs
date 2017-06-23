using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineDTO : DtoBase<int>
    {
        public CkMachineDTO()
        {
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public int TestTypeId { get; set; }
        public int? TypeNum { get; set; }
        public string MachineNum { get; set; }
        public string FirstSampleNum { get; set; }
        public string LastSampleNum { get; set; }
        public System.DateTime? SampleBeginDate { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short? IconIndex { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
