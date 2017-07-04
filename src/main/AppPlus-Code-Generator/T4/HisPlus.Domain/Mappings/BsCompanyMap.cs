using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsCompanyMap : EntityTypeConfiguration<BsCompany>
    {
        public BsCompanyMap()
            : this("dbo")
        {
        }

        public BsCompanyMap(string schema)
        {
            ToTable("BsCompany", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"CODE").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CompAddre).HasColumnName(@"CompAddre").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.CompCorpo).HasColumnName(@"CompCorpo").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.CompPhone).HasColumnName(@"CompPhone").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Bank).HasColumnName(@"Bank").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.BankAccount).HasColumnName(@"BankAccount").IsRequired().HasColumnType("nvarchar").HasMaxLength(16);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsType).HasColumnName(@"LsType").IsOptional().HasColumnType("smallint");
        }
    }
}
