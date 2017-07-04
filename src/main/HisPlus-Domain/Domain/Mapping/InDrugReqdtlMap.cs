using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InDrugReqdtlMap : EntityTypeConfiguration<InDrugReqdtl>
    {
        public InDrugReqdtlMap()
            : this("dbo")
        {
        }

        public InDrugReqdtlMap(string schema)
        {
            ToTable("InDrugReqdtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RequestId).HasColumnName(@"RequestId").IsRequired().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsRequired().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.ForDate).HasColumnName(@"ForDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsRequired().HasColumnType("smallint");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitReq).HasColumnName(@"UnitReq").IsRequired().HasColumnType("int");
            Property(x => x.UnitTake).HasColumnName(@"UnitTake").IsOptional().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsRequired().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.IsPrint).HasColumnName(@"IsPrint").IsRequired().HasColumnType("bit");
            Property(x => x.IsIssued).HasColumnName(@"IsIssued").IsRequired().HasColumnType("bit");
            Property(x => x.IsConfirm).HasColumnName(@"IsConfirm").IsRequired().HasColumnType("bit");
            Property(x => x.ConfirmOperId).HasColumnName(@"ConfirmOperId").IsOptional().HasColumnType("int");
            Property(x => x.ConfirmOperTime).HasColumnName(@"ConfirmOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsOptional().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.LsSecMarkType).HasColumnName(@"LsSecMarkType").IsOptional().HasColumnType("int");
            Property(x => x.BedName).HasColumnName(@"BedName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Refusal).HasColumnName(@"Refusal").IsOptional().HasColumnType("bit");
            Property(x => x.IsArrearage).HasColumnName(@"IsArrearage").IsOptional().HasColumnType("bit");
            Property(x => x.DoctorId).HasColumnName(@"DoctorID").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.LsArrearage).HasColumnName(@"LsArrearage").IsOptional().HasColumnType("bit");
            Property(x => x.DoctorName).HasColumnName(@"DoctorName").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IsOutDrug).HasColumnName(@"IsOutDrug").IsOptional().HasColumnType("bit");
            Property(x => x.UsageMemo).HasColumnName(@"UsageMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.UseTime).HasColumnName(@"UseTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
