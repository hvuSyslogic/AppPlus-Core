using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PlProjectMap : EntityTypeConfiguration<PlProject>
    {
        public PlProjectMap()
            : this("dbo")
        {
        }

        public PlProjectMap(string schema)
        {
            ToTable("PlProject", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ChargeOperId).HasColumnName(@"ChargeOperId").IsRequired().HasColumnType("int");
            Property(x => x.RecTime).HasColumnName(@"RecTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.IsClose).HasColumnName(@"IsClose").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
