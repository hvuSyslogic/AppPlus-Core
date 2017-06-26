using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class LogMap : EntityTypeConfiguration<Log>
    {
        public LogMap()
            : this("dbo")
        {
        }

        public LogMap(string schema)
        {
            ToTable("Log", schema);
            HasKey(x => x.LogId);

            Property(x => x.LogId).HasColumnName(@"LogID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EventId).HasColumnName(@"EventID").IsOptional().HasColumnType("int");
            Property(x => x.Priority).HasColumnName(@"Priority").IsRequired().HasColumnType("int");
            Property(x => x.Severity).HasColumnName(@"Severity").IsRequired().HasColumnType("nvarchar").HasMaxLength(32);
            Property(x => x.Title).HasColumnName(@"Title").IsRequired().HasColumnType("nvarchar").HasMaxLength(256);
            Property(x => x.Timestamp).HasColumnName(@"Timestamp").IsRequired().HasColumnType("datetime");
            Property(x => x.MachineName).HasColumnName(@"MachineName").IsRequired().HasColumnType("nvarchar").HasMaxLength(32);
            Property(x => x.AppDomainName).HasColumnName(@"AppDomainName").IsRequired().HasColumnType("nvarchar").HasMaxLength(512);
            Property(x => x.ProcessId).HasColumnName(@"ProcessID").IsRequired().HasColumnType("nvarchar").HasMaxLength(256);
            Property(x => x.ProcessName).HasColumnName(@"ProcessName").IsRequired().HasColumnType("nvarchar").HasMaxLength(512);
            Property(x => x.ThreadName).HasColumnName(@"ThreadName").IsOptional().HasColumnType("nvarchar").HasMaxLength(512);
            Property(x => x.Win32ThreadId).HasColumnName(@"Win32ThreadId").IsOptional().HasColumnType("nvarchar").HasMaxLength(128);
            Property(x => x.Message).HasColumnName(@"Message").IsOptional().HasColumnType("nvarchar").HasMaxLength(1500);
            Property(x => x.FormattedMessage).HasColumnName(@"FormattedMessage").IsOptional().HasColumnType("ntext").IsMaxLength();
        }
    }
}
