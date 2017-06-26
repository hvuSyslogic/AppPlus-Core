using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OutTJczxxxMap : EntityTypeConfiguration<OutTJczxxx>
    {
        public OutTJczxxxMap()
            : this("dbo")
        {
        }

        public OutTJczxxxMap(string schema)
        {
            ToTable("out_t_jczxxx", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Eventid).HasColumnName(@"EVENTID").IsRequired().HasColumnType("numeric");
            Property(x => x.Jyjcdh).HasColumnName(@"JYJCDH").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Zxzt).HasColumnName(@"ZXZT").IsOptional().HasColumnType("numeric");
            Property(x => x.Suid).HasColumnName(@"SUID").IsOptional().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.Bw).HasColumnName(@"BW").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.Zdjg).HasColumnName(@"ZDJG").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.Reportid).HasColumnName(@"REPORTID").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
            Property(x => x.Bgsj).HasColumnName(@"BGSJ").IsOptional().HasColumnType("datetime");
            Property(x => x.Bgr).HasColumnName(@"BGR").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.Hzly).HasColumnName(@"HZLY").IsOptional().HasColumnType("nvarchar").HasMaxLength(4);
            Property(x => x.Yysj).HasColumnName(@"YYSJ").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.Jgbg).HasColumnName(@"JGBG").IsOptional().HasColumnType("nvarchar").HasMaxLength(4000);
            Property(x => x.RowTime).HasColumnName(@"RowTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.HostName).HasColumnName(@"HostName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}
