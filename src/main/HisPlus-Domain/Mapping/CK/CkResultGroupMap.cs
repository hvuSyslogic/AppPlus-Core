using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkResultGroupMap : EntityTypeConfiguration<CkResultGroup>
    {
        public CkResultGroupMap()
            : this("dbo")
        {
        }

        public CkResultGroupMap(string schema)
        {
            ToTable("CkResultGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.TestGroupId).HasColumnName(@"TestGroupId").IsRequired().HasColumnType("int");
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.CheckDesc).HasColumnName(@"CheckDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.DoctorAdvice).HasColumnName(@"DoctorAdvice").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.LsStatus).HasColumnName(@"LsStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ResultTime).HasColumnName(@"ResultTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ResultOperId).HasColumnName(@"ResultOperId").IsOptional().HasColumnType("int");
            Property(x => x.AuthTime).HasColumnName(@"AuthTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
        }
    }
}
