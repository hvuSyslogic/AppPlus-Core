using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsStLogisticServeMap : EntityTypeConfiguration<CsStLogisticServe>
    {
        public CsStLogisticServeMap()
            : this("dbo")
        {
        }

        public CsStLogisticServeMap(string schema)
        {
            ToTable("CsStLogisticServe", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YearMonth).HasColumnName(@"YearMonth").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.LogisticServeId).HasColumnName(@"LogisticServeId").IsRequired().HasColumnType("int");
            Property(x => x.BenefitLocId).HasColumnName(@"BenefitLocId").IsRequired().HasColumnType("int");
            Property(x => x.ServeLocId).HasColumnName(@"ServeLocId").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Money).HasColumnName(@"Money").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.InputTime).HasColumnName(@"InputTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
