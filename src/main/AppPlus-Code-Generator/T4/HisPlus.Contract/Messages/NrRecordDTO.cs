using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NrRecordDTO : DtoBase<int>
    {
        public NrRecordDTO()
        {
        }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public decimal? ExamT { get; set; }

        [DataMember]
        public decimal? ExamP { get; set; }

        [DataMember]
        public decimal? ExamR { get; set; }

        [DataMember]
        public decimal? ExamBp { get; set; }

        [DataMember]
        public decimal? ExamBp2 { get; set; }

        [DataMember]
        public decimal? Hight { get; set; }

        [DataMember]
        public string Mentality { get; set; }

        [DataMember]
        public string InItem1 { get; set; }

        [DataMember]
        public decimal? InVolumn1 { get; set; }

        [DataMember]
        public string InItem2 { get; set; }

        [DataMember]
        public decimal? InVolumn2 { get; set; }

        [DataMember]
        public decimal? InVolumnAll { get; set; }

        [DataMember]
        public string OutItem1 { get; set; }

        [DataMember]
        public decimal? OutVolumn1 { get; set; }

        [DataMember]
        public string OutItem2 { get; set; }

        [DataMember]
        public decimal? OutVolumn2 { get; set; }

        [DataMember]
        public decimal? OutVolumnAll { get; set; }

        [DataMember]
        public bool? UrineFree { get; set; }

        [DataMember]
        public string UrineProper { get; set; }

        [DataMember]
        public string UrineColor { get; set; }

        [DataMember]
        public decimal? OutOther { get; set; }

        [DataMember]
        public string SpecialMemo { get; set; }

        [DataMember]
        public string Breast { get; set; }

        [DataMember]
        public string Milk { get; set; }

        [DataMember]
        public string UterusHigh { get; set; }

        [DataMember]
        public string UterusShrink { get; set; }

        [DataMember]
        public string Wound { get; set; }

        [DataMember]
        public string Hand { get; set; }

        [DataMember]
        public string Foot { get; set; }

        [DataMember]
        public string Buttocks { get; set; }

        [DataMember]
        public string Mouth { get; set; }

        [DataMember]
        public string Face { get; set; }

        [DataMember]
        public string Breath { get; set; }

        [DataMember]
        public string Blood { get; set; }

        [DataMember]
        public string BoxTemp { get; set; }

        [DataMember]
        public string Spo2 { get; set; }

        [DataMember]
        public string PupilL { get; set; }

        [DataMember]
        public string PupilR { get; set; }

        [DataMember]
        public string PupilBright { get; set; }

        [DataMember]
        public string OxygenBr { get; set; }

        [DataMember]
        public string OxygenF { get; set; }

        [DataMember]
        public string OxygenFiO2 { get; set; }

        [DataMember]
        public string OxygenPipeDeep { get; set; }

        [DataMember]
        public string OxygenCpap { get; set; }

        [DataMember]
        public string OxygenPipeNose { get; set; }

        [DataMember]
        public string OxygenVein { get; set; }

        [DataMember]
        public string LiePose { get; set; }

        [DataMember]
        public string Skin { get; set; }

        [DataMember]
        public string Others { get; set; }

        [DataMember]
        public string Disposal { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public string PupilLReflex { get; set; }

        [DataMember]
        public string PupilRReflex { get; set; }

        [DataMember]
        public string ResultMmo { get; set; }

        [DataMember]
        public string ChannelName { get; set; }

        [DataMember]
        public string ChannelSituation { get; set; }

        [DataMember]
        public string Condition { get; set; }

        [DataMember]
        public string Puncture { get; set; }

        [DataMember]
        public string Joint { get; set; }

        [DataMember]
        public string DropIn { get; set; }

        [DataMember]
        public string Vein { get; set; }

        [DataMember]
        public string DrugExudation { get; set; }

        [DataMember]
        public string TumorExudation { get; set; }

        [DataMember]
        public string Plaster { get; set; }

        [DataMember]
        public string HDilution { get; set; }

        [DataMember]
        public string PSaline { get; set; }

        [DataMember]
        public string OperName { get; set; }
    }
}
