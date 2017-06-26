using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class YbChargeLogMap : EntityTypeConfiguration<YbChargeLog>
    {
        public YbChargeLogMap()
            : this("dbo")
        {
        }

        public YbChargeLogMap(string schema)
        {
            ToTable("YBChargeLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YbReqNo).HasColumnName(@"YbReqNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.InvoNo).HasColumnName(@"InvoNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsOptional().HasColumnType("bit");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("datetime");
        }
    }
}
