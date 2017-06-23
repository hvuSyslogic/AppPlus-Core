using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DgRoadMap : EntityTypeConfiguration<DgRoad>
    {
        public DgRoadMap()
            : this("dbo")
        {
        }

        public DgRoadMap(string schema)
        {
            ToTable("DgRoad", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.LsOpenType).HasColumnName(@"LsOpenType").IsRequired().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsOptional().HasColumnType("bit");
            Property(x => x.IsWomen).HasColumnName(@"IsWomen").IsOptional().HasColumnType("bit");
            Property(x => x.IsMen).HasColumnName(@"IsMen").IsOptional().HasColumnType("bit");
            Property(x => x.IsOlder).HasColumnName(@"IsOlder").IsOptional().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
