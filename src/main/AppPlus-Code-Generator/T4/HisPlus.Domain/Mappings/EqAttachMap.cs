using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class EqAttachMap : EntityTypeConfiguration<EqAttach>
    {
        public EqAttachMap()
            : this("dbo")
        {
        }

        public EqAttachMap(string schema)
        {
            ToTable("EqAttach", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EquipmentId).HasColumnName(@"EquipmentId").IsRequired().HasColumnType("int");
            Property(x => x.FileName).HasColumnName(@"FileName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsFileType).HasColumnName(@"LsFileType").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AttachFile).HasColumnName(@"AttachFile").IsOptional().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.F1).HasColumnName(@"F1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
