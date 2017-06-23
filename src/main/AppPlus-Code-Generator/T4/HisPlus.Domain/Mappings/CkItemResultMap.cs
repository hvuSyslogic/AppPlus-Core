using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkItemResultMap : EntityTypeConfiguration<CkItemResult>
    {
        public CkItemResultMap()
            : this("dbo")
        {
        }

        public CkItemResultMap(string schema)
        {
            ToTable("CkItemResult", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestId).HasColumnName(@"TestId").IsRequired().HasColumnType("int");
            Property(x => x.Result).HasColumnName(@"Result").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsBold).HasColumnName(@"IsBold").IsRequired().HasColumnType("bit");
            Property(x => x.IsPass).HasColumnName(@"IsPass").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.DoctorAdvice).HasColumnName(@"DoctorAdvice").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
        }
    }
}
