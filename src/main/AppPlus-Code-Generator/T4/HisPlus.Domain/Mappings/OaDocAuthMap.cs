using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OaDocAuthMap : EntityTypeConfiguration<OaDocAuth>
    {
        public OaDocAuthMap()
            : this("dbo")
        {
        }

        public OaDocAuthMap(string schema)
        {
            ToTable("OaDocAuth", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DocId).HasColumnName(@"DocId").IsOptional().HasColumnType("int");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("smallint");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsRequired().HasColumnType("bit");
            Property(x => x.AuthOperTime).HasColumnName(@"AuthOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsReject).HasColumnName(@"IsReject").IsOptional().HasColumnType("bit");
            Property(x => x.RejectReason).HasColumnName(@"RejectReason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsReadClass).HasColumnName(@"LsReadClass").IsOptional().HasColumnType("smallint");
        }
    }
}
