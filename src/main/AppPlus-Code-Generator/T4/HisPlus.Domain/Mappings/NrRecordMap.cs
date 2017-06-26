using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NrRecordMap : EntityTypeConfiguration<NrRecord>
    {
        public NrRecordMap()
            : this("dbo")
        {
        }

        public NrRecordMap(string schema)
        {
            ToTable("NrRecord", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Type).HasColumnName(@"Type").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.ExamT).HasColumnName(@"ExamT").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.ExamP).HasColumnName(@"ExamP").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.ExamR).HasColumnName(@"ExamR").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.ExamBp).HasColumnName(@"ExamBp").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp2).HasColumnName(@"ExamBp2").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.Hight).HasColumnName(@"Hight").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.Mentality).HasColumnName(@"Mentality").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InItem1).HasColumnName(@"InItem1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InVolumn1).HasColumnName(@"InVolumn1").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.InItem2).HasColumnName(@"InItem2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InVolumn2).HasColumnName(@"InVolumn2").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.InVolumnAll).HasColumnName(@"InVolumnAll").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.OutItem1).HasColumnName(@"OutItem1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OutVolumn1).HasColumnName(@"OutVolumn1").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.OutItem2).HasColumnName(@"OutItem2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OutVolumn2).HasColumnName(@"OutVolumn2").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.OutVolumnAll).HasColumnName(@"OutVolumnAll").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.UrineFree).HasColumnName(@"UrineFree").IsOptional().HasColumnType("bit");
            Property(x => x.UrineProper).HasColumnName(@"UrineProper").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UrineColor).HasColumnName(@"UrineColor").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OutOther).HasColumnName(@"OutOther").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.SpecialMemo).HasColumnName(@"SpecialMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Breast).HasColumnName(@"Breast").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Milk).HasColumnName(@"Milk").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UterusHigh).HasColumnName(@"UterusHigh").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UterusShrink).HasColumnName(@"UterusShrink").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Wound).HasColumnName(@"Wound").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Hand).HasColumnName(@"Hand").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Foot).HasColumnName(@"Foot").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Buttocks).HasColumnName(@"Buttocks").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Mouth).HasColumnName(@"Mouth").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Face).HasColumnName(@"Face").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Breath).HasColumnName(@"Breath").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Blood).HasColumnName(@"Blood").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BoxTemp).HasColumnName(@"BoxTemp").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Spo2).HasColumnName(@"SPO2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PupilL).HasColumnName(@"PupilL").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PupilR).HasColumnName(@"PupilR").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PupilBright).HasColumnName(@"PupilBright").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenBr).HasColumnName(@"OxygenBr").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenF).HasColumnName(@"OxygenF").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenFiO2).HasColumnName(@"OxygenFiO2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenPipeDeep).HasColumnName(@"OxygenPipeDeep").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenCpap).HasColumnName(@"OxygenCpap").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenPipeNose).HasColumnName(@"OxygenPipeNose").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OxygenVein).HasColumnName(@"OxygenVein").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LiePose).HasColumnName(@"LiePose").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Skin).HasColumnName(@"Skin").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Others).HasColumnName(@"Others").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Disposal).HasColumnName(@"Disposal").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PupilLReflex).HasColumnName(@"PupilLReflex").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PupilRReflex).HasColumnName(@"PupilRReflex").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ResultMmo).HasColumnName(@"ResultMMO").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ChannelName).HasColumnName(@"ChannelName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ChannelSituation).HasColumnName(@"ChannelSituation").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Condition).HasColumnName(@"Condition").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Puncture).HasColumnName(@"Puncture").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Joint).HasColumnName(@"Joint").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DropIn).HasColumnName(@"DropIn").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Vein).HasColumnName(@"Vein").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DrugExudation).HasColumnName(@"DrugExudation").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TumorExudation).HasColumnName(@"TumorExudation").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Plaster).HasColumnName(@"Plaster").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HDilution).HasColumnName(@"HDilution").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PSaline).HasColumnName(@"PSaline").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperName).HasColumnName(@"OperName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
