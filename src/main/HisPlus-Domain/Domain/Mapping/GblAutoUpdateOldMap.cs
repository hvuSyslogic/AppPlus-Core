using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblAutoUpdateOldMap : EntityTypeConfiguration<GblAutoUpdateOld>
    {
        public GblAutoUpdateOldMap()
            : this("dbo")
        {
        }

        public GblAutoUpdateOldMap(string schema)
        {
            ToTable("GblAutoUpdateOld", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PathName).HasColumnName(@"PathName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.FileContent).HasColumnName(@"FileContent").IsRequired().HasColumnType("image").HasMaxLength(2147483647);
            Property(x => x.OldVersion).HasColumnName(@"OldVersion").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.NewVersion).HasColumnName(@"NewVersion").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.UpLoadHostName).HasColumnName(@"UpLoadHostName").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.UpLoadIp).HasColumnName(@"UpLoadIp").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.DownLoadHostNames).HasColumnName(@"DownLoadHostNames").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.HospitalIds).HasColumnName(@"HospitalIds").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.IsChoose).HasColumnName(@"IsChoose").IsOptional().HasColumnType("bit");
        }
    }
}
