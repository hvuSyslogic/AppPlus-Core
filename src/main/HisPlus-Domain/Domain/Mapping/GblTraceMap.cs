using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class GblTraceMap : EntityTypeConfiguration<GblTrace>
    {
        public GblTraceMap()
            : this("dbo")
        {
        }

        public GblTraceMap(string schema)
        {
            ToTable("GblTrace", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SqlString).HasColumnName(@"SqlString").IsRequired().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.WhereCondition).HasColumnName(@"WhereCondition").IsRequired().HasColumnType("nvarchar").HasMaxLength(600);
            Property(x => x.OrderByExpression).HasColumnName(@"OrderByExpression").IsRequired().HasColumnType("nvarchar").HasMaxLength(600);
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
        }
    }
}
