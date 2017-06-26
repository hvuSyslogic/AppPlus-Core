using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RmCheckSumMap : EntityTypeConfiguration<RmCheckSum>
    {
        public RmCheckSumMap()
            : this("dbo")
        {
        }

        public RmCheckSumMap(string schema)
        {
            ToTable("RmCheckSum", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CheckId).HasColumnName(@"CheckId").IsRequired().HasColumnType("int");
            Property(x => x.SumFor).HasColumnName(@"SumFor").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ApplyIn).HasColumnName(@"ApplyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MzBackIn).HasColumnName(@"MzBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyBackIn).HasColumnName(@"ZyBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PyIn).HasColumnName(@"PyIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoveIn).HasColumnName(@"MoveIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherIn).HasColumnName(@"OtherIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MoveOut).HasColumnName(@"MoveOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.MzOut).HasColumnName(@"MzOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyOut).HasColumnName(@"ZyOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PkOut).HasColumnName(@"PkOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.LoseOut).HasColumnName(@"LoseOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BackOut).HasColumnName(@"BackOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherOut).HasColumnName(@"OtherOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouUp).HasColumnName(@"AdjustAmouUp").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AdjustAmouDn).HasColumnName(@"AdjustAmouDn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.CheckAmou).HasColumnName(@"CheckAmou").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.BalanceAmou).HasColumnName(@"BalanceAmou").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RecipeOut).HasColumnName(@"RecipeOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KsBackIn).HasColumnName(@"KsBackIn").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.KsOut).HasColumnName(@"KsOut").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
