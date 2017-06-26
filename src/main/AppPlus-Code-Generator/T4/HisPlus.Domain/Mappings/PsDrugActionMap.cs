using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class PsDrugActionMap : EntityTypeConfiguration<PsDrugAction>
    {
        public PsDrugActionMap()
            : this("dbo")
        {
        }

        public PsDrugActionMap(string schema)
        {
            ToTable("PsDrugAction", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyNo).HasColumnName(@"ApplyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsRequired().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ReactTime).HasColumnName(@"ReactTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsTransType).HasColumnName(@"LsTransType").IsOptional().HasColumnType("smallint");
            Property(x => x.ClincHandle).HasColumnName(@"ClincHandle").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
