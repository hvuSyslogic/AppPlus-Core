using System.Data.Entity.ModelConfiguration;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class BsBed : EntityBase<int>
    {
        public BsBed()
        {    
        }

        public string Name { get; set; }
        public string RoomNo { get; set; }
        public int LocationId { get; set; }
        public short LsBall { get; set; }
        public int? ItemId { get; set; }
        public bool IsAdd { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short IconIndex { get; set; }
        public short LsClass { get; set; }
        public bool? IsAddBed { get; set; }
        public string BedGroup { get; set; }
        public int? ItemId1 { get; set; }
        public int? ItemId2 { get; set; }
        public int? AddItemId { get; set; }
    }
}
