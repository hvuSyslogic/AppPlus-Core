using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDrugReqdtlAMap : EntityTypeConfiguration<InDrugReqdtlA>
    {
        public InDrugReqdtlAMap()
            : this("dbo")
        {
        }

        public InDrugReqdtlAMap(string schema)
        {
            ToTable("InDrugReqdtl_A", schema);
            HasKey(x => new { x.OperDate, x.Id, x.RequestId, x.ListNum, x.HospId, x.ForDate, x.ItemId, x.AdviceId, x.GroupNum, x.LsMarkType, x.Dosage, x.UnitReq, x.Totality, x.IsPrint, x.IsIssued, x.IsConfirm });

            Property(x => x.OperDate).HasColumnName(@"OperDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int");
            Property(x => x.RequestId).HasColumnName(@"RequestId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.ForDate).HasColumnName(@"ForDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.UnitReq).HasColumnName(@"UnitReq").IsRequired().HasColumnType("int");
            Property(x => x.UnitTake).HasColumnName(@"UnitTake").IsOptional().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.IsIssued).HasColumnName(@"IsIssued").IsRequired().HasColumnType("bit");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsRequired().HasColumnType("bit");
            Property(x => x.ConfirmOperId).HasColumnName(@"ConfirmOperId").IsOptional().HasColumnType("int");
            Property(x => x.ConfirmOperTime).HasColumnName(@"ConfirmOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsOptional().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
        }
    }
}
