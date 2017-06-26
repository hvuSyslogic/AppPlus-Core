using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class YbQueryMap : EntityTypeConfiguration<YbQuery>
    {
        public YbQueryMap()
            : this("dbo")
        {
        }

        public YbQueryMap(string schema)
        {
            ToTable("YbQuery", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DesigCode).HasColumnName(@"DesigCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PersonNum).HasColumnName(@"PersonNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.YbSeq).HasColumnName(@"YbSeq").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DocumentNo).HasColumnName(@"DocumentNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TransType).HasColumnName(@"TransType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SerialNum).HasColumnName(@"SerialNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReceiveNum).HasColumnName(@"ReceiveNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TotalAmount).HasColumnName(@"TotalAmount").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InsuranceAmount).HasColumnName(@"InsuranceAmount").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SuppleAmount).HasColumnName(@"SuppleAmount").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CashPayment).HasColumnName(@"CashPayment").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SelfAmount).HasColumnName(@"SelfAmount").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SomeSelfAmount).HasColumnName(@"SomeSelfAmount").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EnterCosts).HasColumnName(@"EnterCosts").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ToPayStandard).HasColumnName(@"ToPayStandard").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IntoCosts).HasColumnName(@"IntoCosts").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SelfPaid).HasColumnName(@"SelfPaid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.EnterInsuranceCosts).HasColumnName(@"EnterInsuranceCosts").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SuppInsurancePays).HasColumnName(@"SuppInsurancePays").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LimitSelfPaid).HasColumnName(@"LimitSelfPaid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Ntime).HasColumnName(@"Ntime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.DevelopersLogo).HasColumnName(@"DevelopersLogo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.SettlementDate).HasColumnName(@"SettlementDate").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MzregId).HasColumnName(@"MzregId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
        }
    }
}
