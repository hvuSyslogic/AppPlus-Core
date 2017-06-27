using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblOnlinerMap : EntityTypeConfiguration<GblOnliner>
    {
        public GblOnlinerMap()
            : this("dbo")
        {
        }

        public GblOnlinerMap(string schema)
        {
            ToTable("GblOnliner", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.WorkStationName).HasColumnName(@"WorkStationName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LockIp).HasColumnName(@"LockIp").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.LoginTime).HasColumnName(@"LoginTime").IsRequired().HasColumnType("datetime");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}