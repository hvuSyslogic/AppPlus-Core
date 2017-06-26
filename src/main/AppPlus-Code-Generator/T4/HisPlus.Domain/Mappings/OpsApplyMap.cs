using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OpsApplyMap : EntityTypeConfiguration<OpsApply>
    {
        public OpsApplyMap()
            : this("dbo")
        {
        }

        public OpsApplyMap(string schema)
        {
            ToTable("OpsApply", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ApplyNo).HasColumnName(@"ApplyNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ApplyTime).HasColumnName(@"ApplyTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.MzRegId).HasColumnName(@"MzRegId").IsOptional().HasColumnType("int");
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.OpsId).HasColumnName(@"OpsId").IsOptional().HasColumnType("int");
            Property(x => x.OpsOtherId).HasColumnName(@"OpsOtherId").IsOptional().HasColumnType("int");
            Property(x => x.AnaeId).HasColumnName(@"AnaeId").IsOptional().HasColumnType("int");
            Property(x => x.Assistant).HasColumnName(@"Assistant").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.BedNo).HasColumnName(@"BedNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsHbsAg).HasColumnName(@"LsHbsAg").IsOptional().HasColumnType("smallint");
            Property(x => x.LsAsepsis).HasColumnName(@"LsAsepsis").IsOptional().HasColumnType("smallint");
            Property(x => x.BloodGroup).HasColumnName(@"BloodGroup").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Blood).HasColumnName(@"Blood").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OpsBody).HasColumnName(@"OpsBody").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OpsPos).HasColumnName(@"OpsPos").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OtherTools).HasColumnName(@"OtherTools").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsUrgent).HasColumnName(@"IsUrgent").IsRequired().HasColumnType("bit");
            Property(x => x.IsCalled).HasColumnName(@"IsCalled").IsRequired().HasColumnType("bit");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.PlanOperId).HasColumnName(@"PlanOperId").IsOptional().HasColumnType("int");
            Property(x => x.PlanTime).HasColumnName(@"PlanTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PlanMemo).HasColumnName(@"PlanMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsFinish).HasColumnName(@"IsFinish").IsOptional().HasColumnType("bit");
            Property(x => x.FinishTime).HasColumnName(@"FinishTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.FinishOperId).HasColumnName(@"FinishOperId").IsOptional().HasColumnType("int");
            Property(x => x.FinishMemo).HasColumnName(@"FinishMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.BloodSum).HasColumnName(@"BloodSum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsCutClass).HasColumnName(@"LsCutClass").IsOptional().HasColumnType("smallint");
            Property(x => x.LsCure).HasColumnName(@"LsCure").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.BloodRpt).HasColumnName(@"BloodRpt").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Sensitive).HasColumnName(@"Sensitive").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.OpsRoomId).HasColumnName(@"OpsRoomId").IsOptional().HasColumnType("int");
            Property(x => x.SeqNum).HasColumnName(@"SeqNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
