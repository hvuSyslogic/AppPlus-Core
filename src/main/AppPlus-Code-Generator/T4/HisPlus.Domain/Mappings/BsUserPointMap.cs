using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsUserPointMap : EntityTypeConfiguration<BsUserPoint>
    {
        public BsUserPointMap()
            : this("dbo")
        {
        }

        public BsUserPointMap(string schema)
        {
            ToTable("BsUserPoint", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Type).HasColumnName(@"Type").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
