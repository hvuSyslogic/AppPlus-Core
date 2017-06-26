using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OuDocRegTypeMap : EntityTypeConfiguration<OuDocRegType>
    {
        public OuDocRegTypeMap()
            : this("dbo")
        {
        }

        public OuDocRegTypeMap(string schema)
        {
            ToTable("OuDocRegType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RegDate).HasColumnName(@"RegDate").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.WeekPlanId).HasColumnName(@"WeekPlanId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeId").IsRequired().HasColumnType("int");
            Property(x => x.TimeSpanId).HasColumnName(@"TimeSpanId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.DiagRoomId).HasColumnName(@"DiagRoomId").IsOptional().HasColumnType("int");
            Property(x => x.LimitNum).HasColumnName(@"LimitNum").IsOptional().HasColumnType("smallint");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Iscancel).HasColumnName(@"iscancel").IsOptional().HasColumnType("int");
            Property(x => x.Lastlimitnum).HasColumnName(@"lastlimitnum").IsOptional().HasColumnType("int");
        }
    }
}
