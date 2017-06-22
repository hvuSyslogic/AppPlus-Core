using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BkStoreLogMap : EntityTypeConfiguration<BkStoreLog>
    {
        public BkStoreLogMap()
            : this("dbo")
        {
        }

        public BkStoreLogMap(string schema)
        {
            ToTable("BKStoreLog", schema);
            HasKey(x => new { x.Id, x.HappenTime, x.UserId, x.PatCardid, x.LsActType, x.BeforeMoney, x.HappenMoney, x.AfterMoney });

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HappenTime).HasColumnName(@"HappenTime").IsRequired().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.PatCardid).HasColumnName(@"PatCardid").IsRequired().HasColumnType("int");
            Property(x => x.BkRegNo).HasColumnName(@"BKRegNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsActType).HasColumnName(@"LsActType").IsRequired().HasColumnType("smallint");
            Property(x => x.BeforeMoney).HasColumnName(@"BeforeMoney").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.HappenMoney).HasColumnName(@"HappenMoney").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.AfterMoney).HasColumnName(@"AfterMoney").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
