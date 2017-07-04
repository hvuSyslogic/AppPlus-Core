using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class HuAdjustPlanMap : EntityTypeConfiguration<HuAdjustPlan>
    {
        public HuAdjustPlanMap()
            : this("dbo")
        {
        }

        public HuAdjustPlanMap(string schema)
        {
            ToTable("HuAdjustPlan", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BillNo).HasColumnName(@"BillNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsRequired().HasColumnType("int");
            Property(x => x.NotifyDate).HasColumnName(@"NotifyDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.DispUnit).HasColumnName(@"DispUnit").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
        }
    }
}
