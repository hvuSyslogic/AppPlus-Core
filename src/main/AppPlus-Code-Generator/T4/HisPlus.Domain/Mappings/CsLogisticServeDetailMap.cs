using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsLogisticServeDetailMap : EntityTypeConfiguration<CsLogisticServeDetail>
    {
        public CsLogisticServeDetailMap()
            : this("dbo")
        {
        }

        public CsLogisticServeDetailMap(string schema)
        {
            ToTable("CsLogisticServeDetail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ServeDate).HasColumnName(@"ServeDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Abstract).HasColumnName(@"Abstract").IsRequired().HasColumnType("nvarchar").HasMaxLength(64);
            Property(x => x.LogisticServeId).HasColumnName(@"LogisticServeId").IsRequired().HasColumnType("int");
            Property(x => x.BenefitLocId).HasColumnName(@"BenefitLocId").IsRequired().HasColumnType("int");
            Property(x => x.ServeLocId).HasColumnName(@"ServeLocId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Equivalent).HasColumnName(@"Equivalent").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ServeNo).HasColumnName(@"ServeNo").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.IsAcctMark).HasColumnName(@"IsAcctMark").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
