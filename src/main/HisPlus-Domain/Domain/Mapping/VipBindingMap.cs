using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipBindingMap : EntityTypeConfiguration<VipBinding>
    {
        public VipBindingMap()
            : this("dbo")
        {
        }

        public VipBindingMap(string schema)
        {
            ToTable("VipBinding", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.VipCardId).HasColumnName(@"VipCardId").IsOptional().HasColumnType("int");
            Property(x => x.IsCardHolder).HasColumnName(@"IsCardHolder").IsOptional().HasColumnType("bit");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.ModifiedOperId).HasColumnName(@"ModifiedOperId").IsOptional().HasColumnType("int");
            Property(x => x.ModifiedOperTime).HasColumnName(@"ModifiedOperTime").IsOptional().HasColumnType("datetime");
        }
    }
}
