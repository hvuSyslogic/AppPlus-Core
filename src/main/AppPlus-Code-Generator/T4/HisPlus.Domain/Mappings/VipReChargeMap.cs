using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class VipReChargeMap : EntityTypeConfiguration<VipReCharge>
    {
        public VipReChargeMap()
            : this("dbo")
        {
        }

        public VipReChargeMap(string schema)
        {
            ToTable("VipReCharge", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.VipCardId).HasColumnName(@"VipCardID").IsOptional().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatID").IsOptional().HasColumnType("int");
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.InCome).HasColumnName(@"InCome").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PayOut).HasColumnName(@"PayOut").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Balance).HasColumnName(@"Balance").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PayWay).HasColumnName(@"PayWay").IsOptional().HasColumnType("int");
            Property(x => x.OperType).HasColumnName(@"OperType").IsOptional().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.Comments).HasColumnName(@"Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.VipTypeId).HasColumnName(@"VipTypeID").IsOptional().HasColumnType("int");
            Property(x => x.LsVipChaFromType).HasColumnName(@"LsVipChaFromType").IsOptional().HasColumnType("int");
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
        }
    }
}
