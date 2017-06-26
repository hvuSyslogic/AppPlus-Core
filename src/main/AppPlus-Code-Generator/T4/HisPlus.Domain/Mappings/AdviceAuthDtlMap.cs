using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class AdviceAuthDtlMap : EntityTypeConfiguration<AdviceAuthDtl>
    {
        public AdviceAuthDtlMap()
            : this("dbo")
        {
        }

        public AdviceAuthDtlMap(string schema)
        {
            ToTable("AdviceAuthDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsOptional().HasColumnType("int");
            Property(x => x.AdviceTime).HasColumnName(@"AdviceTime").IsOptional().HasColumnType("datetime");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.FormId).HasColumnName(@"FormId").IsOptional().HasColumnType("int");
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitTakeId).HasColumnName(@"UnitTakeId").IsOptional().HasColumnType("int");
            Property(x => x.FrequencyId).HasColumnName(@"FrequencyId").IsOptional().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsOptional().HasColumnType("int");
            Property(x => x.Totality).HasColumnName(@"Totality").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.ToTalityAll).HasColumnName(@"ToTalityAll").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.Amount).HasColumnName(@"Amount").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.UnitInId).HasColumnName(@"UnitInId").IsOptional().HasColumnType("int");
            Property(x => x.IsAttach).HasColumnName(@"IsAttach").IsOptional().HasColumnType("bit");
            Property(x => x.IsSelf).HasColumnName(@"IsSelf").IsOptional().HasColumnType("bit");
            Property(x => x.LsSpecialUsage).HasColumnName(@"LsSpecialUsage").IsOptional().HasColumnType("int");
            Property(x => x.LsExecLoc).HasColumnName(@"LsExecLoc").IsOptional().HasColumnType("int");
            Property(x => x.SkinTime).HasColumnName(@"SkinTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsSkin).HasColumnName(@"IsSkin").IsOptional().HasColumnType("bit");
            Property(x => x.SkinTest).HasColumnName(@"SkinTest").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.IsPrinted).HasColumnName(@"IsPrinted").IsOptional().HasColumnType("bit");
            Property(x => x.IsChk).HasColumnName(@"IsChk").IsOptional().HasColumnType("bit");
            Property(x => x.ChkOperTime).HasColumnName(@"ChkOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.ChkOperId).HasColumnName(@"ChkOperID").IsOptional().HasColumnType("int");
            Property(x => x.IsEnd).HasColumnName(@"IsEnd").IsOptional().HasColumnType("bit");
            Property(x => x.EndOperTime).HasColumnName(@"EndOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.EndOperId).HasColumnName(@"EndOperID").IsOptional().HasColumnType("int");
            Property(x => x.EndDoctorId).HasColumnName(@"EndDoctorID").IsOptional().HasColumnType("int");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsOptional().HasColumnType("bit");
            Property(x => x.AuthOperTime).HasColumnName(@"AuthOperTime").IsOptional().HasColumnType("datetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.IsOtherFee).HasColumnName(@"IsOtherFee").IsOptional().HasColumnType("bit");
            Property(x => x.IsBeforeops).HasColumnName(@"IsBeforeops").IsOptional().HasColumnType("bit");
            Property(x => x.LsRpType).HasColumnName(@"LsRpType").IsOptional().HasColumnType("int");
            Property(x => x.IsInject).HasColumnName(@"IsInject").IsOptional().HasColumnType("bit");
            Property(x => x.Sn).HasColumnName(@"SN").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FirstDay).HasColumnName(@"FirstDay").IsOptional().HasColumnType("int");
            Property(x => x.LastDay).HasColumnName(@"LastDay").IsOptional().HasColumnType("int");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
            Property(x => x.OriAdviceId).HasColumnName(@"OriAdviceId").IsOptional().HasColumnType("int");
            Property(x => x.InfeeCheck).HasColumnName(@"InfeeCheck").IsOptional().HasColumnType("int");
            Property(x => x.Adcolor).HasColumnName(@"Adcolor").IsOptional().HasColumnType("int");
            Property(x => x.IsManual).HasColumnName(@"IsManual").IsRequired().HasColumnType("bit");
            Property(x => x.IsArrearage).HasColumnName(@"IsArrearage").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F5).HasColumnName(@"F5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F6).HasColumnName(@"F6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F7).HasColumnName(@"F7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F8).HasColumnName(@"F8").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IsTodayIn).HasColumnName(@"IsTodayIn").IsOptional().HasColumnType("bit");
            Property(x => x.DrugReqId1).HasColumnName(@"DrugReqId1").IsOptional().HasColumnType("int");
            Property(x => x.DrugReqId2).HasColumnName(@"DrugReqId2").IsOptional().HasColumnType("int");
            Property(x => x.DetailId1).HasColumnName(@"DetailId1").IsOptional().HasColumnType("int");
            Property(x => x.DetailId2).HasColumnName(@"DetailId2").IsOptional().HasColumnType("int");
            Property(x => x.AdviceName).HasColumnName(@"AdviceName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Spec).HasColumnName(@"Spec").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ExecuteId).HasColumnName(@"ExecuteId").IsOptional().HasColumnType("int");
            Property(x => x.ExecuteId2).HasColumnName(@"ExecuteId2").IsOptional().HasColumnType("int");
            Property(x => x.Dosage).HasColumnName(@"Dosage").IsOptional().HasColumnType("decimal").HasPrecision(10,4);
            Property(x => x.ExecDoctorId).HasColumnName(@"ExecDoctorId").IsOptional().HasColumnType("int");
        }
    }
}
