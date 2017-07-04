using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBacteriaMap : EntityTypeConfiguration<BsBacteria>
    {
        public BsBacteriaMap()
            : this("dbo")
        {
        }

        public BsBacteriaMap(string schema)
        {
            ToTable("BsBacteria", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TypeId).HasColumnName(@"TypeId").IsRequired().HasColumnType("int");
            Property(x => x.GramsId).HasColumnName(@"GramsId").IsOptional().HasColumnType("int");
            Property(x => x.ShuId).HasColumnName(@"ShuId").IsRequired().HasColumnType("int");
            Property(x => x.StandTypeId).HasColumnName(@"StandTypeId").IsRequired().HasColumnType("int");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
