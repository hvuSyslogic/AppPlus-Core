using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipCardMap : EntityTypeConfiguration<VipCard>
    {
        public VipCardMap()
            : this("dbo")
        {
        }

        public VipCardMap(string schema)
        {
            ToTable("VipCard", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsOptional().HasColumnType("int");
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.VipLevelId).HasColumnName(@"VipLevelId").IsOptional().HasColumnType("int");
            Property(x => x.Discount).HasColumnName(@"Discount").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Password).HasColumnName(@"Password").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CreateTime).HasColumnName(@"CreateTime").IsOptional().HasColumnType("datetime");
            Property(x => x.InvalidDate).HasColumnName(@"InvalidDate").IsOptional().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.CardStatus).HasColumnName(@"CardStatus").IsOptional().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.IntroducerId).HasColumnName(@"IntroducerId").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IntroducerOperId).HasColumnName(@"IntroducerOperId").IsOptional().HasColumnType("int");
            Property(x => x.ModiTime).HasColumnName(@"ModiTime").IsOptional().HasColumnType("datetime");
            Property(x => x.ModiOperId).HasColumnName(@"ModiOperId").IsOptional().HasColumnType("int");
            Property(x => x.SalesDate).HasColumnName(@"SalesDate").IsOptional().HasColumnType("date");
        }
    }
}
