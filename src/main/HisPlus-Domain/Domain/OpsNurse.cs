using System.Data.Entity.ModelConfiguration;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Domain
{
    public class OpsNurse : EntityBase<int>
    {
        public OpsNurse()
        {    
        }

        public int ApplyId { get; set; }
        public string HandWashingNurse { get; set; }
        public string ReplaceHandNurse { get; set; }
        public System.DateTime TakeTime { get; set; }
        public string VisitingNurse { get; set; }
        public string ReplaceVisitingNurse { get; set; }
        public System.DateTime TakeTime2 { get; set; }
        public string SurgeryPosition { get; set; }
        public string LocalAnesthesiaIsDrugUse { get; set; }
        public string Constrained { get; set; }
        public string AHand { get; set; }
        public System.DateTime AirTime { get; set; }
        public System.DateTime PhoebeTime { get; set; }
        public string NegativePlate { get; set; }
        public System.DateTime AirTime2 { get; set; }
        public System.DateTime PhoebeTime2 { get; set; }
        public string InfusionParts { get; set; }
        public System.DateTime AirTime3 { get; set; }
        public string PhoebeTime3 { get; set; }
        public string PicassoSkinCond { get; set; }
        public bool CatheterizationOperatingRoom { get; set; }
        public string TheCatheter { get; set; }
        public bool Electrotome { get; set; }
        public bool ArgonKnife { get; set; }
        public bool BipolarOfElectricity { get; set; }
        public bool UltrasoundScalpel { get; set; }
        public bool IsSendFrozenSection { get; set; }
        public bool IsForPathologicSpecimens { get; set; }
        public bool IsSendBacteriaCultivation { get; set; }
        public bool IsAsepticPackagePassedExamination { get; set; }
        public bool IsSurgicalItemsInventory { get; set; }
        public string TotalIntake { get; set; }
        public string AlwaysGgivesQuantity { get; set; }
        public bool Implant { get; set; }
        public string Parts { get; set; }
    }
}
