using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgRoadIllMap : EntityTypeConfiguration<DgRoadIll>
    {
        public DgRoadIllMap()
            : this("dbo")
        {
        }

        public DgRoadIllMap(string schema)
        {
            ToTable("DgRoadIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.RoadId).HasColumnName(@"RoadId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
