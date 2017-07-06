using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipIntegralMap : EntityTypeConfiguration<VipIntegral>
    {
        public VipIntegralMap()
            : this("dbo")
        {
        }

        public VipIntegralMap(string schema)
        {
            ToTable("VipIntegral", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.VipcardId).HasColumnName(@"VipcardId").IsOptional().HasColumnType("int");
            Property(x => x.Integral).HasColumnName(@"Integral").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("date");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperStatus).HasColumnName(@"OperStatus").IsOptional().HasColumnType("bit");
            Property(x => x.Comments).HasColumnName(@"Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
        }
    }
}
