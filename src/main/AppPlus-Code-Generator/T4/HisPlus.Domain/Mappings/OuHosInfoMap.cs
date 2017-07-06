using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuHosInfoMap : EntityTypeConfiguration<OuHosInfo>
    {
        public OuHosInfoMap()
            : this("dbo")
        {
        }

        public OuHosInfoMap(string schema)
        {
            ToTable("OuHosInfo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.MzRegNo).HasColumnName(@"MzRegNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(12);
            Property(x => x.RegTime).HasColumnName(@"RegTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(19);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().HasColumnType("nvarchar").HasMaxLength(1);
            Property(x => x.IsBaby).HasColumnName(@"IsBaby").IsRequired().HasColumnType("bit");
            Property(x => x.AgeDay).HasColumnName(@"AgeDay").IsOptional().HasColumnType("smallint");
            Property(x => x.Height).HasColumnName(@"Height").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.Weight).HasColumnName(@"Weight").IsOptional().HasColumnType("numeric").HasPrecision(5,2);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsRequired().HasColumnType("int");
            Property(x => x.MedicareNo).HasColumnName(@"MedicareNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(18);
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeId").IsRequired().HasColumnType("int");
            Property(x => x.IsPriority).HasColumnName(@"IsPriority").IsRequired().HasColumnType("bit");
            Property(x => x.IsElder).HasColumnName(@"IsElder").IsRequired().HasColumnType("bit");
            Property(x => x.LineOrder).HasColumnName(@"LineOrder").IsRequired().HasColumnType("int");
            Property(x => x.RegFee).HasColumnName(@"RegFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.ZyFee).HasColumnName(@"ZyFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.DiagnoFee).HasColumnName(@"DiagnoFee").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee1).HasColumnName(@"OtherFee1").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.OtherFee2).HasColumnName(@"OtherFee2").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.PaySel).HasColumnName(@"PaySel").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.TallyDiag).HasColumnName(@"TallyDiag").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.FactGet).HasColumnName(@"FactGet").IsRequired().HasColumnType("decimal").HasPrecision(18,2);
            Property(x => x.RegDept).HasColumnName(@"RegDept").IsRequired().HasColumnType("int");
            Property(x => x.DiagnDept).HasColumnName(@"DiagnDept").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.RoomNo).HasColumnName(@"RoomNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsFreeDiag).HasColumnName(@"IsFreeDiag").IsRequired().HasColumnType("bit");
            Property(x => x.IsFreeReg).HasColumnName(@"IsFreeReg").IsRequired().HasColumnType("bit");
            Property(x => x.IsInPatient).HasColumnName(@"IsInPatient").IsRequired().HasColumnType("bit");
            Property(x => x.IsPreReg).HasColumnName(@"IsPreReg").IsRequired().HasColumnType("bit");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsCancel).HasColumnName(@"IsCancel").IsOptional().HasColumnType("bit");
            Property(x => x.CancelTime).HasColumnName(@"CancelTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.CancelOperId).HasColumnName(@"CancelOperId").IsOptional().HasColumnType("int");
            Property(x => x.CancelMemo).HasColumnName(@"CancelMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.TimeSpanId).HasColumnName(@"TimeSpanId").IsOptional().HasColumnType("int");
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.Age).HasColumnName(@"Age").IsOptional().HasColumnType("tinyint");
            Property(x => x.AgeString).HasColumnName(@"AgeString").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ContactPhone).HasColumnName(@"ContactPhone").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.LinkmanName).HasColumnName(@"LinkmanName").IsOptional().HasColumnType("nvarchar").HasMaxLength(150);
            Property(x => x.TallyTime).HasColumnName(@"TallyTime").IsOptional().HasColumnType("datetime");
            Property(x => x.CancelTallyTime).HasColumnName(@"CancelTallyTime").IsOptional().HasColumnType("datetime");
            Property(x => x.TimeSpanSubId).HasColumnName(@"TimeSpanSubId").IsOptional().HasColumnType("int");
            Property(x => x.DiagRoomId).HasColumnName(@"DiagRoomId").IsOptional().HasColumnType("int");
            Property(x => x.CallDoctorId).HasColumnName(@"CallDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.CallOrder).HasColumnName(@"CallOrder").IsOptional().HasColumnType("int");
            Property(x => x.IsFirstCheck).HasColumnName(@"IsFirstCheck").IsOptional().HasColumnType("bit");
            Property(x => x.IsGoodRecipe).HasColumnName(@"IsGoodRecipe").IsOptional().HasColumnType("bit");
            Property(x => x.GoodRecipe).HasColumnName(@"GoodRecipe").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(100);
            Property(x => x.IsRegist).HasColumnName(@"IsRegist").IsOptional().HasColumnType("bit");
            Property(x => x.Diagnose).HasColumnName(@"Diagnose").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.PreRegRegWay).HasColumnName(@"PreRegRegWay").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.IsRegister).HasColumnName(@"IsRegister").IsOptional().HasColumnType("bit");
        }
    }
}
