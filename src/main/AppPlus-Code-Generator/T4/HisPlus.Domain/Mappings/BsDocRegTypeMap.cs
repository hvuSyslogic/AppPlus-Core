using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsDocRegTypeMap : EntityTypeConfiguration<BsDocRegType>
    {
        public BsDocRegTypeMap()
            : this("dbo")
        {
        }

        public BsDocRegTypeMap(string schema)
        {
            ToTable("BsDocRegType", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsRequired().HasColumnType("int");
            Property(x => x.RegTypeId).HasColumnName(@"RegTypeId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.LimitNum).HasColumnName(@"LimitNum").IsOptional().HasColumnType("smallint");
            Property(x => x.LastLimitDate).HasColumnName(@"LastLimitDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LastLimitNum).HasColumnName(@"LastLimitNum").IsOptional().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsOptional().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.WeekDay).HasColumnName(@"WeekDay").IsRequired().HasColumnType("smallint");
            Property(x => x.TimeSpanId).HasColumnName(@"TimeSpanId").IsRequired().HasColumnType("int");
            Property(x => x.RoomNo).HasColumnName(@"RoomNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Diagroomid).HasColumnName(@"Diagroomid").IsOptional().HasColumnType("int");
        }
    }
}
