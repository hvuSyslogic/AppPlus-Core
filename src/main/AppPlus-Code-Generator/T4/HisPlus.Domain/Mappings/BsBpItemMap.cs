using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBpItemMap : EntityTypeConfiguration<BsBpItem>
    {
        public BsBpItemMap()
            : this("dbo")
        {
        }

        public BsBpItemMap(string schema)
        {
            ToTable("BsBPItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.LsRpType).HasColumnName(@"LsRpType").IsOptional().HasColumnType("int");
            Property(x => x.YbCode).HasColumnName(@"YbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
