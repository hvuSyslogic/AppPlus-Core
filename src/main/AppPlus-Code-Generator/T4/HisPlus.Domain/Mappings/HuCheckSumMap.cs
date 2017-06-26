using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuCheckSumMap : EntityTypeConfiguration<HuCheckSum>
    {
        public HuCheckSumMap()
            : this("dbo")
        {
        }

        public HuCheckSumMap(string schema)
        {
            ToTable("HuCheckSum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
            Property(x => x.SumFor).HasColumnName(@"SumFor").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.BuyIn).HasColumnName(@"BuyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackIn).HasColumnName(@"BackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PyIn).HasColumnName(@"PyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherIn).HasColumnName(@"OtherIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DeptOut).HasColumnName(@"DeptOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.SaleOut).HasColumnName(@"SaleOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackOut).HasColumnName(@"BackOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PkOut).HasColumnName(@"PkOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LoseOut).HasColumnName(@"LoseOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouUp).HasColumnName(@"AdjustAmouUp").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouDn).HasColumnName(@"AdjustAmouDn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CheckAmou).HasColumnName(@"CheckAmou").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BalanceAmou).HasColumnName(@"BalanceAmou").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.TotalPrice).HasColumnName(@"TotalPrice").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
