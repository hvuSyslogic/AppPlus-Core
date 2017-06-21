using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsUserWindowMap : EntityTypeConfiguration<BsUserWindow>
    {
        public BsUserWindowMap()
            : this("dbo")
        {
        }

        public BsUserWindowMap(string schema)
        {
            ToTable("BsUserWindows", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.MenuId).HasColumnName(@"MenuId").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Caption).HasColumnName(@"Caption").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
