using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDepositMap : EntityTypeConfiguration<InDeposit>
    {
        public InDepositMap()
            : this("dbo")
        {
        }

        public InDepositMap(string schema)
        {
            ToTable("InDeposit", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.Amount).HasColumnName(@"Amount").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.Remain).HasColumnName(@"Remain").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.IsFirst).HasColumnName(@"IsFirst").IsRequired().HasColumnType("bit");
            Property(x => x.Remark).HasColumnName(@"Remark").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.LsCancelType).HasColumnName(@"LsCancelType").IsOptional().HasColumnType("smallint");
            Property(x => x.CancelOperTime).HasColumnName(@"CancelOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.InvoId).HasColumnName(@"InvoId").IsOptional().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.CheckTime).HasColumnName(@"CheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelCheckTime).HasColumnName(@"CancelCheckTime").IsOptional().HasColumnType("datetime");
            Property(x => x.PayWayName).HasColumnName(@"PayWayName").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
        }
    }
}
