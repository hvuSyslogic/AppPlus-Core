using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsCostDetailMap : EntityTypeConfiguration<CsCostDetail>
    {
        public CsCostDetailMap()
            : this("dbo")
        {
        }

        public CsCostDetailMap(string schema)
        {
            ToTable("CsCostDetail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PayDate).HasColumnName(@"PayDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.CostSubjId).HasColumnName(@"CostSubjId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.VoucherType).HasColumnName(@"VoucherType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.VoucherNo).HasColumnName(@"VoucherNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(40);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.IsAcct).HasColumnName(@"IsAcct").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
