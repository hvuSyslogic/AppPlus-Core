using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsLogisticServeMap : EntityTypeConfiguration<CsLogisticServe>
    {
        public CsLogisticServeMap()
            : this("dbo")
        {
        }

        public CsLogisticServeMap(string schema)
        {
            ToTable("CsLogisticServe", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.UnitPrice).HasColumnName(@"UnitPrice").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
