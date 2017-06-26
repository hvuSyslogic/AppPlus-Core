using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormVDtlMap : EntityTypeConfiguration<ElPatFormVDtl>
    {
        public ElPatFormVDtlMap()
            : this("dbo")
        {
        }

        public ElPatFormVDtlMap(string schema)
        {
            ToTable("ElPatFormVDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsOptional().HasColumnType("int");
            Property(x => x.PatFormValueId).HasColumnName(@"PatFormValueId").IsOptional().HasColumnType("int");
            Property(x => x.ElId).HasColumnName(@"ElId").IsOptional().HasColumnType("int");
            Property(x => x.BsDtlId).HasColumnName(@"BsDtlId").IsOptional().HasColumnType("int");
            Property(x => x.ElValue).HasColumnName(@"ElValue").IsOptional().HasColumnType("nvarchar").HasMaxLength(3500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
