using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpIllListMap : EntityTypeConfiguration<BsBpIllList>
    {
        public BsBpIllListMap()
            : this("dbo")
        {
        }

        public BsBpIllListMap(string schema)
        {
            ToTable("BsBPIllList", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BpIllId).HasColumnName(@"BPIllId").IsOptional().HasColumnType("int");
            Property(x => x.BpIllName).HasColumnName(@"BPIllName").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}