using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBphisIllRelationMap : EntityTypeConfiguration<BsBphisIllRelation>
    {
        public BsBphisIllRelationMap()
            : this("dbo")
        {
        }

        public BsBphisIllRelationMap(string schema)
        {
            ToTable("BsBPHISIllRelation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BpIllId).HasColumnName(@"BPIllId").IsOptional().HasColumnType("int");
            Property(x => x.HisIllId).HasColumnName(@"HISIllId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
