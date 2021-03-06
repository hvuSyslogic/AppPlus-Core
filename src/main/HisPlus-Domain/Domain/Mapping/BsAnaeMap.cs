using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsAnaeMap : EntityTypeConfiguration<BsAnae>
    {
        public BsAnaeMap()
            : this("dbo")
        {
        }

        public BsAnaeMap(string schema)
        {
            ToTable("BsAnaes", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.FunctionM).HasColumnName(@"FunctionM").IsRequired().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Effect).HasColumnName(@"Effect").IsRequired().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Tabu).HasColumnName(@"Tabu").IsRequired().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Memo).HasColumnName(@"MEMO").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
