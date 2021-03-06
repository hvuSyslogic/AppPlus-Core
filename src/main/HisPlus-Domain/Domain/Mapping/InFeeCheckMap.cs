using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InFeeCheckMap : EntityTypeConfiguration<InFeeCheck>
    {
        public InFeeCheckMap()
            : this("dbo")
        {
        }

        public InFeeCheckMap(string schema)
        {
            ToTable("InFeeCheck", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsOptional().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsOptional().HasColumnType("smallint");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsOptional().HasColumnType("bit");
        }
    }
}
