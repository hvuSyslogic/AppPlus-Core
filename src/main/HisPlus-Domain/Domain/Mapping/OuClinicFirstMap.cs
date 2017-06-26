using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuClinicFirstMap : EntityTypeConfiguration<OuClinicFirst>
    {
        public OuClinicFirstMap()
            : this("dbo")
        {
        }

        public OuClinicFirstMap(string schema)
        {
            ToTable("OuClinicFirst", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.MainInform).HasColumnName(@"MainInform").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.SickHist).HasColumnName(@"SickHist").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.ExamT).HasColumnName(@"ExamT").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamP).HasColumnName(@"ExamP").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamR).HasColumnName(@"ExamR").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp).HasColumnName(@"ExamBp").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp2).HasColumnName(@"ExamBp2").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.CheckUp).HasColumnName(@"CheckUp").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.CheckCt).HasColumnName(@"CheckCT").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Disposal).HasColumnName(@"Disposal").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Impression).HasColumnName(@"Impression").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Analys).HasColumnName(@"Analys").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Others).HasColumnName(@"Others").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Tongue).HasColumnName(@"Tongue").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Pulse).HasColumnName(@"Pulse").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Moss).HasColumnName(@"Moss").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Xmlemr).HasColumnName(@"XMLEMR").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlCancer).HasColumnName(@"XMLCancer").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlSex).HasColumnName(@"XMLSex").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlTuberculosis).HasColumnName(@"XMLTuberculosis").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlContagion).HasColumnName(@"XMLContagion").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.ExamSugar).HasColumnName(@"ExamSugar").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.FirstDate).HasColumnName(@"FirstDate").IsOptional().HasColumnType("date");
        }
    }
}
