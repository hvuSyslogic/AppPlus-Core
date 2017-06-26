using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkIllAdviceMap : EntityTypeConfiguration<CkIllAdvice>
    {
        public CkIllAdviceMap()
            : this("dbo")
        {
        }

        public CkIllAdviceMap(string schema)
        {
            ToTable("CkIllAdvice", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeId").IsOptional().HasColumnType("int");
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Advice).HasColumnName(@"Advice").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
