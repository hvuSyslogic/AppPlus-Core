using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuNotAttachMap : EntityTypeConfiguration<OuNotAttach>
    {
        public OuNotAttachMap()
            : this("dbo")
        {
        }

        public OuNotAttachMap(string schema)
        {
            ToTable("OuNotAttach", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsRequired().HasColumnType("int");
            Property(x => x.ItemId1).HasColumnName(@"ItemId1").IsRequired().HasColumnType("int");
            Property(x => x.ItemId2).HasColumnName(@"ItemId2").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
