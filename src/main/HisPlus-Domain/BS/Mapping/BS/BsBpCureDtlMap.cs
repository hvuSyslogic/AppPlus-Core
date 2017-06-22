using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpCureDtlMap : EntityTypeConfiguration<BsBpCureDtl>
    {
        public BsBpCureDtlMap()
            : this("dbo")
        {
        }

        public BsBpCureDtlMap(string schema)
        {
            ToTable("BsBPCureDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CureId).HasColumnName(@"CureId").IsOptional().HasColumnType("int");
            Property(x => x.BpItemId).HasColumnName(@"BPItemId").IsOptional().HasColumnType("int");
            Property(x => x.TypeCode).HasColumnName(@"TypeCode").IsOptional().HasColumnType("int");
            Property(x => x.RelationCode).HasColumnName(@"RelationCode").IsOptional().HasColumnType("int");
            Property(x => x.WayCode).HasColumnName(@"WayCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Remark).HasColumnName(@"Remark").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
