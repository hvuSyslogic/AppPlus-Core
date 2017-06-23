using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsIncomeDetailMap : EntityTypeConfiguration<CsIncomeDetail>
    {
        public CsIncomeDetailMap()
            : this("dbo")
        {
        }

        public CsIncomeDetailMap(string schema)
        {
            ToTable("CsIncomeDetail", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PayDate).HasColumnName(@"PayDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Summary).HasColumnName(@"Summary").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.LocId).HasColumnName(@"LocId").IsOptional().HasColumnType("int");
            Property(x => x.ExcLocId).HasColumnName(@"ExcLocId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Unit).HasColumnName(@"Unit").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(10);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FeeHsId).HasColumnName(@"FeeHsId").IsOptional().HasColumnType("int");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.IsAcct).HasColumnName(@"IsAcct").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
