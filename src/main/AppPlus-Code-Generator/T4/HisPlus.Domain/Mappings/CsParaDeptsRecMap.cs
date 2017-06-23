using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsParaDeptsRecMap : EntityTypeConfiguration<CsParaDeptsRec>
    {
        public CsParaDeptsRecMap()
            : this("dbo")
        {
        }

        public CsParaDeptsRecMap(string schema)
        {
            ToTable("CsParaDeptsRec", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YearMonth).HasColumnName(@"YearMonth").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.LsAppPara).HasColumnName(@"LsAppPara").IsOptional().HasColumnType("smallint");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(16,4);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
