using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TraceMap : EntityTypeConfiguration<Trace>
    {
        public TraceMap()
            : this("dbo")
        {
        }

        public TraceMap(string schema)
        {
            ToTable("Trace", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CreateDate).HasColumnName(@"CreateDate").IsRequired().HasColumnType("datetime");
            Property(x => x.UserId).HasColumnName(@"UserID").IsRequired().HasColumnType("int");
            Property(x => x.Ip).HasColumnName(@"IP").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Messages).HasColumnName(@"Messages").IsOptional().HasColumnType("nvarchar").HasMaxLength(4000);
            Property(x => x.Type).HasColumnName(@"Type").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OperateType).HasColumnName(@"OperateType").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.RecordId).HasColumnName(@"RecordId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
