using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsitemcustomgroupMap : EntityTypeConfiguration<Bsitemcustomgroup>
    {
        public BsitemcustomgroupMap()
            : this("dbo")
        {
        }

        public BsitemcustomgroupMap(string schema)
        {
            ToTable("BSITEMCUSTOMGROUP", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName(@"NAME").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Orderby).HasColumnName(@"ORDERBY").IsRequired().HasColumnType("int");
            Property(x => x.Isactive).HasColumnName(@"ISACTIVE").IsRequired().HasColumnType("int");
            Property(x => x.Lsoutorin).HasColumnName(@"LSOUTORIN").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Iconindex).HasColumnName(@"ICONINDEX").IsRequired().HasColumnType("int");
        }
    }
}
