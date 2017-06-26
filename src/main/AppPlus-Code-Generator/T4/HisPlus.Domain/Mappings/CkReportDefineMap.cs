using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkReportDefineMap : EntityTypeConfiguration<CkReportDefine>
    {
        public CkReportDefineMap()
            : this("dbo")
        {
        }

        public CkReportDefineMap(string schema)
        {
            ToTable("CKReportDefine", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeID").IsOptional().HasColumnType("int");
            Property(x => x.ReportContent).HasColumnName(@"ReportContent").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
        }
    }
}
