using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipChargeConfigMap : EntityTypeConfiguration<VipChargeConfig>
    {
        public VipChargeConfigMap()
            : this("dbo")
        {
        }

        public VipChargeConfigMap(string schema)
        {
            ToTable("VipChargeConfig", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Viplevelid).HasColumnName(@"Viplevelid").IsOptional().HasColumnType("int");
            Property(x => x.Balance).HasColumnName(@"Balance").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Givingintegral1).HasColumnName(@"Givingintegral1").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Givingintegral2).HasColumnName(@"Givingintegral2").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
        }
    }
}
