using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    public class CkMachineImageDTO : DtoBase<int>
    {
        public CkMachineImageDTO()
        {
        }

        public int LabId { get; set; }
        public string SampleNum { get; set; }
        public int MachineId { get; set; }
        public byte[] LabImage { get; set; }
        public string ImageType { get; set; }
        public bool IsDisplay { get; set; }
        public short OrderBy { get; set; }
    }
}
