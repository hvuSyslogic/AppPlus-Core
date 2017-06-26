using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElTipsPatMap : EntityTypeConfiguration<ElTipsPat>
    {
        public ElTipsPatMap()
            : this("dbo")
        {
        }

        public ElTipsPatMap(string schema)
        {
            ToTable("ElTipsPat", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.TipId).HasColumnName(@"TipId").IsOptional().HasColumnType("int");
            Property(x => x.Tips).HasColumnName(@"Tips").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ActiveDays).HasColumnName(@"ActiveDays").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
