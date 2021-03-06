using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsExecLocationMap : EntityTypeConfiguration<BsExecLocation>
    {
        public BsExecLocationMap()
            : this("dbo")
        {
        }

        public BsExecLocationMap(string schema)
        {
            ToTable("BsExecLocation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.TimeBegin).HasColumnName(@"TimeBegin").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TimeEnd).HasColumnName(@"TimeEnd").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ExecPoint).HasColumnName(@"ExecPoint").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
