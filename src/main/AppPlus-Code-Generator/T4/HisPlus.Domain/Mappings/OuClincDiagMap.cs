using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuClincDiagMap : EntityTypeConfiguration<OuClincDiag>
    {
        public OuClincDiagMap()
            : this("dbo")
        {
        }

        public OuClincDiagMap(string schema)
        {
            ToTable("OuClincDiag", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsDiagType).HasColumnName(@"LsDiagType").IsOptional().HasColumnType("smallint");
            Property(x => x.SequenceNum).HasColumnName(@"SequenceNum").IsOptional().HasColumnType("int");
            Property(x => x.IcdCodeZy).HasColumnName(@"IcdCode_Zy").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IllDescZy).HasColumnName(@"IllDesc_Zy").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
