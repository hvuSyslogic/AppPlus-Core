using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkCompanyMap : EntityTypeConfiguration<CkCompany>
    {
        public CkCompanyMap()
            : this("dbo")
        {
        }

        public CkCompanyMap(string schema)
        {
            ToTable("CkCompany", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Phone).HasColumnName(@"Phone").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Fax).HasColumnName(@"Fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.Address).HasColumnName(@"Address").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PostCode).HasColumnName(@"PostCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.PayWayId).HasColumnName(@"PayWayId").IsOptional().HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(9,2);
            Property(x => x.ResponMan).HasColumnName(@"ResponMan").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
