using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrInHosInfoMap : EntityTypeConfiguration<TrInHosInfo>
    {
        public TrInHosInfoMap()
            : this("dbo")
        {
        }

        public TrInHosInfoMap(string schema)
        {
            ToTable("TrInHosInfo", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.InPatNo).HasColumnName(@"InPatNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.CardNo).HasColumnName(@"CardNo").IsRequired().HasColumnType("nvarchar").HasMaxLength(13);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.Sex).HasColumnName(@"Sex").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
            Property(x => x.InTime).HasColumnName(@"InTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OutTime).HasColumnName(@"OutTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
            Property(x => x.BedId).HasColumnName(@"BedId").IsOptional().HasColumnType("int");
            Property(x => x.LsInStatus).HasColumnName(@"LsInStatus").IsOptional().HasColumnType("smallint");
            Property(x => x.LocIn).HasColumnName(@"LocIn").IsOptional().HasColumnType("int");
            Property(x => x.Residence).HasColumnName(@"Residence").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.DoctorId).HasColumnName(@"DoctorId").IsOptional().HasColumnType("int");
            Property(x => x.IdCardNo).HasColumnName(@"IdCardNo").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsMarriage).HasColumnName(@"LsMarriage").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
