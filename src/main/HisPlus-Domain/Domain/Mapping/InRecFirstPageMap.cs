using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InRecFirstPageMap : EntityTypeConfiguration<InRecFirstPage>
    {
        public InRecFirstPageMap()
            : this("dbo")
        {
        }

        public InRecFirstPageMap(string schema)
        {
            ToTable("InRecFirstPage", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RecNo).HasColumnName(@"RecNo").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.ModifyOperTime).HasColumnName(@"ModifyOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ModifyOperId).HasColumnName(@"ModifyOperID").IsOptional().HasColumnType("int");
            Property(x => x.IsAuth).HasColumnName(@"IsAuth").IsRequired().HasColumnType("bit");
            Property(x => x.AuthOperTime).HasColumnName(@"AuthOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.AuthOperId).HasColumnName(@"AuthOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ConfirmIllDate).HasColumnName(@"ConfirmIllDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsOps).HasColumnName(@"IsOPS").IsRequired().HasColumnType("bit");
            Property(x => x.IsBabyCard).HasColumnName(@"IsBabyCard").IsRequired().HasColumnType("bit");
            Property(x => x.IsMutiIll).HasColumnName(@"IsMutiIll").IsRequired().HasColumnType("bit");
            Property(x => x.InfectTimes).HasColumnName(@"InfectTimes").IsRequired().HasColumnType("int");
            Property(x => x.IsSalvage).HasColumnName(@"IsSalvage").IsRequired().HasColumnType("bit");
            Property(x => x.SalvageTimes).HasColumnName(@"SalvageTimes").IsRequired().HasColumnType("int");
            Property(x => x.IsSalvSucess).HasColumnName(@"IsSalvSucess").IsRequired().HasColumnType("bit");
            Property(x => x.SalvSucessTimes).HasColumnName(@"SalvSucessTimes").IsRequired().HasColumnType("int");
            Property(x => x.IsFollow).HasColumnName(@"IsFollow").IsRequired().HasColumnType("bit");
            Property(x => x.FollowEndDate).HasColumnName(@"FollowEndDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsDeadBodyCheck).HasColumnName(@"IsDeadBodyCheck").IsRequired().HasColumnType("bit");
            Property(x => x.IsStudyCase).HasColumnName(@"IsStudyCase").IsRequired().HasColumnType("bit");
            Property(x => x.LsQuality).HasColumnName(@"LsQuality").IsRequired().HasColumnType("smallint");
            Property(x => x.ZrDoctorId).HasColumnName(@"ZrDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.ZzDoctorId).HasColumnName(@"ZzDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.ZyDoctorId).HasColumnName(@"ZyDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.SxDoctorId).HasColumnName(@"SxDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.JxDoctorId).HasColumnName(@"JxDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.YjsDoctorId).HasColumnName(@"YjsDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.ZkDoctorId).HasColumnName(@"ZkDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.LsAccMzIll).HasColumnName(@"LsAccMzIll").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAccZyIll).HasColumnName(@"LsAccZyIll").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAccOpsIll1).HasColumnName(@"LsAccOPSIll1").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAccOpsIll2).HasColumnName(@"LsAccOPSIll2").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAccOpsIll3).HasColumnName(@"LsAccOPSIll3").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAccOpsIll4).HasColumnName(@"LsAccOPSIll4").IsRequired().HasColumnType("smallint");
            Property(x => x.IsTjIll).HasColumnName(@"IsTjIll").IsRequired().HasColumnType("bit");
            Property(x => x.IsConfirm3D).HasColumnName(@"IsConfirm3D").IsRequired().HasColumnType("bit");
            Property(x => x.BabyNum).HasColumnName(@"BabyNum").IsRequired().HasColumnType("int");
            Property(x => x.IsTranNeact).HasColumnName(@"IsTranNeact").IsRequired().HasColumnType("bit");
            Property(x => x.IsOxygenNeact).HasColumnName(@"IsOxygenNeact").IsRequired().HasColumnType("bit");
            Property(x => x.IsMidFireBurn).HasColumnName(@"IsMidFireBurn").IsRequired().HasColumnType("bit");
            Property(x => x.IsSingleIll).HasColumnName(@"IsSingleIll").IsRequired().HasColumnType("bit");
            Property(x => x.IsHbsAg).HasColumnName(@"IsHbsAg").IsRequired().HasColumnType("bit");
            Property(x => x.IsHcvAb).HasColumnName(@"IsHCVAb").IsRequired().HasColumnType("bit");
            Property(x => x.IsHivAb).HasColumnName(@"IsHIVAb").IsRequired().HasColumnType("bit");
            Property(x => x.IsHbsAg3).HasColumnName(@"IsHbsAg3").IsRequired().HasColumnType("bit");
            Property(x => x.HeadOperId).HasColumnName(@"HeadOperId").IsOptional().HasColumnType("int");
            Property(x => x.ZkOperId).HasColumnName(@"ZkOperId").IsOptional().HasColumnType("int");
            Property(x => x.ZkDate).HasColumnName(@"ZkDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.IsRh).HasColumnName(@"IsRH").IsRequired().HasColumnType("bit");
            Property(x => x.IsOpsFirst).HasColumnName(@"IsOpsFirst").IsRequired().HasColumnType("bit");
            Property(x => x.IsCureFirst).HasColumnName(@"IsCureFirst").IsRequired().HasColumnType("bit");
            Property(x => x.IsCheckFirst).HasColumnName(@"IsCheckFirst").IsRequired().HasColumnType("bit");
            Property(x => x.IsDiagFirst).HasColumnName(@"IsDiagFirst").IsRequired().HasColumnType("bit");
            Property(x => x.RedCellNum).HasColumnName(@"RedCellNum").IsOptional().HasColumnType("int");
            Property(x => x.PlaqueNum).HasColumnName(@"PlaqueNum").IsOptional().HasColumnType("int");
            Property(x => x.SerousNum).HasColumnName(@"SerousNum").IsOptional().HasColumnType("int");
            Property(x => x.AllBloodNum).HasColumnName(@"AllBloodNum").IsOptional().HasColumnType("int");
            Property(x => x.OtherBloodNum).HasColumnName(@"OtherBloodNum").IsOptional().HasColumnType("int");
            Property(x => x.ConsultHosputal).HasColumnName(@"ConsultHosputal").IsOptional().HasColumnType("int");
            Property(x => x.ConsultRemote).HasColumnName(@"ConsultRemote").IsOptional().HasColumnType("int");
        }
    }
}
