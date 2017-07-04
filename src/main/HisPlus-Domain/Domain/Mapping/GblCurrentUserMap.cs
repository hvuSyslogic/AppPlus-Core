using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblCurrentUserMap : EntityTypeConfiguration<GblCurrentUser>
    {
        public GblCurrentUserMap()
            : this("dbo")
        {
        }

        public GblCurrentUserMap(string schema)
        {
            ToTable("GblCurrentUser", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsOptional().HasColumnType("int");
            Property(x => x.HouseId).HasColumnName(@"HouseId").IsOptional().HasColumnType("int");
            Property(x => x.RoomId).HasColumnName(@"RoomId").IsOptional().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.Hostname).HasColumnName(@"Hostname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.SpecialityId).HasColumnName(@"SpecialityId").IsOptional().HasColumnType("int");
            Property(x => x.BeginTime).HasColumnName(@"BeginTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.EndTime).HasColumnName(@"EndTime").IsOptional().HasColumnType("smalldatetime");
        }
    }
}
