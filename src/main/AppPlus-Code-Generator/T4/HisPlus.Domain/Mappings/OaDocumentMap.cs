using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaDocumentMap : EntityTypeConfiguration<OaDocument>
    {
        public OaDocumentMap()
            : this("dbo")
        {
        }

        public OaDocumentMap(string schema)
        {
            ToTable("OaDocument", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupMainId).HasColumnName(@"GroupMainId").IsOptional().HasColumnType("int");
            Property(x => x.GroupSubId).HasColumnName(@"GroupSubId").IsOptional().HasColumnType("int");
            Property(x => x.LsOpenType).HasColumnName(@"LsOpenType").IsOptional().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
            Property(x => x.Security).HasColumnName(@"Security").IsOptional().HasColumnType("smallint");
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
        }
    }
}
