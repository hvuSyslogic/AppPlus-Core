using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CsInWorkLogMap : EntityTypeConfiguration<CsInWorkLog>
    {
        public CsInWorkLogMap()
            : this("dbo")
        {
        }

        public CsInWorkLogMap(string schema)
        {
            ToTable("CsInWorkLog", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.YearMonth).HasColumnName(@"YearMonth").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(6);
            Property(x => x.LocId).HasColumnName(@"LocId").IsRequired().HasColumnType("int");
            Property(x => x.OriginalNum).HasColumnName(@"OriginalNum").IsOptional().HasColumnType("int");
            Property(x => x.AdmittedOutps).HasColumnName(@"AdmittedOutps").IsOptional().HasColumnType("int");
            Property(x => x.FromOtherDept).HasColumnName(@"FromOtherDept").IsOptional().HasColumnType("int");
            Property(x => x.TotalInHospitalDays).HasColumnName(@"TotalInHospitalDays").IsOptional().HasColumnType("int");
            Property(x => x.TotalInDeptDays).HasColumnName(@"TotalInDeptDays").IsOptional().HasColumnType("int");
            Property(x => x.TransDeptNum).HasColumnName(@"TransDeptNum").IsOptional().HasColumnType("int");
            Property(x => x.TotalBedUsedDays).HasColumnName(@"TotalBedUsedDays").IsOptional().HasColumnType("int");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.InputTime).HasColumnName(@"InputTime").IsOptional().HasColumnType("datetime");
            Property(x => x.BedUsedRates).HasColumnName(@"BedUsedRates").IsOptional().HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
