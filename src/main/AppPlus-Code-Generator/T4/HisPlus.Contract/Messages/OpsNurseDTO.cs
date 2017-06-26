using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsNurseDTO : DtoBase<int>
    {
        public OpsNurseDTO()
        {
        }

        [DataMember]
        public int ApplyId { get; set; }

        [DataMember]
        public string HandWashingNurse { get; set; }

        [DataMember]
        public string ReplaceHandNurse { get; set; }

        [DataMember]
        public System.DateTime TakeTime { get; set; }

        [DataMember]
        public string VisitingNurse { get; set; }

        [DataMember]
        public string ReplaceVisitingNurse { get; set; }

        [DataMember]
        public System.DateTime TakeTime2 { get; set; }

        [DataMember]
        public string SurgeryPosition { get; set; }

        [DataMember]
        public string LocalAnesthesiaIsDrugUse { get; set; }

        [DataMember]
        public string Constrained { get; set; }

        [DataMember]
        public string AHand { get; set; }

        [DataMember]
        public System.DateTime AirTime { get; set; }

        [DataMember]
        public System.DateTime PhoebeTime { get; set; }

        [DataMember]
        public string NegativePlate { get; set; }

        [DataMember]
        public System.DateTime AirTime2 { get; set; }

        [DataMember]
        public System.DateTime PhoebeTime2 { get; set; }

        [DataMember]
        public string InfusionParts { get; set; }

        [DataMember]
        public System.DateTime AirTime3 { get; set; }

        [DataMember]
        public string PhoebeTime3 { get; set; }

        [DataMember]
        public string PicassoSkinCond { get; set; }

        [DataMember]
        public bool CatheterizationOperatingRoom { get; set; }

        [DataMember]
        public string TheCatheter { get; set; }

        [DataMember]
        public bool Electrotome { get; set; }

        [DataMember]
        public bool ArgonKnife { get; set; }

        [DataMember]
        public bool BipolarOfElectricity { get; set; }

        [DataMember]
        public bool UltrasoundScalpel { get; set; }

        [DataMember]
        public bool IsSendFrozenSection { get; set; }

        [DataMember]
        public bool IsForPathologicSpecimens { get; set; }

        [DataMember]
        public bool IsSendBacteriaCultivation { get; set; }

        [DataMember]
        public bool IsAsepticPackagePassedExamination { get; set; }

        [DataMember]
        public bool IsSurgicalItemsInventory { get; set; }

        [DataMember]
        public string TotalIntake { get; set; }

        [DataMember]
        public string AlwaysGgivesQuantity { get; set; }

        [DataMember]
        public bool Implant { get; set; }

        [DataMember]
        public string Parts { get; set; }
    }
}
