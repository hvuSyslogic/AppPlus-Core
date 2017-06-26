using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsitemcustomMap : EntityTypeConfiguration<Bsitemcustom>
    {
        public BsitemcustomMap()
            : this("dbo")
        {
        }

        public BsitemcustomMap(string schema)
        {
            ToTable("BSITEMCUSTOM", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Itemid).HasColumnName(@"ITEMID").IsRequired().HasColumnType("int");
            Property(x => x.Reportid).HasColumnName(@"REPORTID").IsOptional().HasColumnType("int");
            Property(x => x.Customtype).HasColumnName(@"CUSTOMTYPE").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Orderby).HasColumnName(@"ORDERBY").IsOptional().HasColumnType("int");
            Property(x => x.Iconindex).HasColumnName(@"ICONINDEX").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"MEMO").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
