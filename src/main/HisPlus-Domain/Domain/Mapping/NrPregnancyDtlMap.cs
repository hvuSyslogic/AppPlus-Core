using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class NrPregnancyDtlMap : EntityTypeConfiguration<NrPregnancyDtl>
    {
        public NrPregnancyDtlMap()
            : this("dbo")
        {
        }

        public NrPregnancyDtlMap(string schema)
        {
            ToTable("NrPregnancyDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PregnancyId).HasColumnName(@"PregnancyId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ExamBp).HasColumnName(@"ExamBp").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ExamBp2).HasColumnName(@"ExamBp2").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.Strength).HasColumnName(@"Strength").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LongTimes).HasColumnName(@"LongTimes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Sometimes).HasColumnName(@"Sometimes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UterusHigh).HasColumnName(@"UterusHigh").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Post).HasColumnName(@"Post").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Speed).HasColumnName(@"Speed").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Place).HasColumnName(@"Place").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FirstHigh).HasColumnName(@"FirstHigh").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Lengh).HasColumnName(@"Lengh").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Expand).HasColumnName(@"Expand").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Membrane).HasColumnName(@"Membrane").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Anus).HasColumnName(@"Anus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Vagina).HasColumnName(@"Vagina").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Others).HasColumnName(@"Others").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CheckMan).HasColumnName(@"CheckMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CenterTimes).HasColumnName(@"CenterTimes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LinkUp).HasColumnName(@"LinkUp").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Score).HasColumnName(@"Score").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AmniFluid).HasColumnName(@"AmniFluid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.VaginaBleed).HasColumnName(@"VaginaBleed").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MoveTimes).HasColumnName(@"MoveTimes").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
