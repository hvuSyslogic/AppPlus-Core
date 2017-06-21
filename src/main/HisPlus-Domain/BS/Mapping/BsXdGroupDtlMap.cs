using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsXdGroupDtlMap : EntityTypeConfiguration<BsXdGroupDtl>
    {
        public BsXdGroupDtlMap()
            : this("dbo")
        {
        }

        public BsXdGroupDtlMap(string schema)
        {
            ToTable("BsXdGroupDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.GroupId).HasColumnName(@"GroupId").IsRequired().HasColumnType("int");
            Property(x => x.XdRpId).HasColumnName(@"XdRpId").IsRequired().HasColumnType("int");
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.LsOpenType).HasColumnName(@"LsOpenType").IsRequired().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
        }
    }
}
