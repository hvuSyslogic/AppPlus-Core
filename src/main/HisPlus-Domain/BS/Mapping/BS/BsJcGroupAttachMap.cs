using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsJcGroupAttachMap : EntityTypeConfiguration<BsJcGroupAttach>
    {
        public BsJcGroupAttachMap()
            : this("dbo")
        {
        }

        public BsJcGroupAttachMap(string schema)
        {
            ToTable("BsJCGroupAttach", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.LsUseArea).HasColumnName(@"LsUseArea").IsRequired().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
