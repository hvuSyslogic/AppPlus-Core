using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsReportNurseItemMap : EntityTypeConfiguration<BsReportNurseItem>
    {
        public BsReportNurseItemMap()
            : this("dbo")
        {
        }

        public BsReportNurseItemMap(string schema)
        {
            ToTable("BsReportNurseItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FeeName).HasColumnName(@"FeeName").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Code).HasColumnName(@"code").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Name).HasColumnName(@"name").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Spec).HasColumnName(@"spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Price).HasColumnName(@"Price").IsOptional().HasColumnType("float");
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.IsOuInAll).HasColumnName(@"IsOuInAll").IsOptional().HasColumnType("int");
            Property(x => x.Type).HasColumnName(@"Type").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
