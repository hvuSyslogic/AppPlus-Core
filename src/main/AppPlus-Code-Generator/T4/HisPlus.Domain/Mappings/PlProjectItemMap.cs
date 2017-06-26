using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PlProjectItemMap : EntityTypeConfiguration<PlProjectItem>
    {
        public PlProjectItemMap()
            : this("dbo")
        {
        }

        public PlProjectItemMap(string schema)
        {
            ToTable("PlProjectItem", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ProjId).HasColumnName(@"ProjId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
            Property(x => x.Hours).HasColumnName(@"Hours").IsRequired().HasColumnType("smallint");
            Property(x => x.BeginPlan).HasColumnName(@"BeginPlan").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.EndPlan).HasColumnName(@"EndPlan").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsClose).HasColumnName(@"IsClose").IsOptional().HasColumnType("bit");
            Property(x => x.HoursFact).HasColumnName(@"HoursFact").IsOptional().HasColumnType("smallint");
            Property(x => x.EndFact).HasColumnName(@"EndFact").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ChargeOperId).HasColumnName(@"ChargeOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
