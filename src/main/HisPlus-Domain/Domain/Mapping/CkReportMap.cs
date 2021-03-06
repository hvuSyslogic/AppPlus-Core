using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkReportMap : EntityTypeConfiguration<CkReport>
    {
        public CkReportMap()
            : this("dbo")
        {
        }

        public CkReportMap(string schema)
        {
            ToTable("CkReport", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.TestGroupId).HasColumnName(@"TestGroupId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.XmlFile).HasColumnName(@"XMLFile").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
        }
    }
}
