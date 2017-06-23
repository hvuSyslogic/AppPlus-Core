using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class DdlExecSqlMap : EntityTypeConfiguration<DdlExecSql>
    {
        public DdlExecSqlMap()
            : this("dbo")
        {
        }

        public DdlExecSqlMap(string schema)
        {
            ToTable("DDLExecSql", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.EventType).HasColumnName(@"EventType").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(90);
            Property(x => x.SchemaName).HasColumnName(@"SchemaName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.ObjType).HasColumnName(@"ObjType").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(30);
            Property(x => x.ObjName).HasColumnName(@"ObjName").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.SqlText).HasColumnName(@"SqlText").IsOptional().IsUnicode(false).HasColumnType("varchar(max)");
            Property(x => x.ExecDate).HasColumnName(@"ExecDate").IsOptional().HasColumnType("datetime2");
            Property(x => x.Terminal).HasColumnName(@"Terminal").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(99);
        }
    }
}
