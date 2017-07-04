using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class TrAdviceMap : EntityTypeConfiguration<TrAdvice>
    {
        public TrAdviceMap()
            : this("dbo")
        {
        }

        public TrAdviceMap(string schema)
        {
            ToTable("TrAdvice", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("datetime");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.AdviceId).HasColumnName(@"AdviceId").IsRequired().HasColumnType("int");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsRequired().HasColumnType("smallint");
            Property(x => x.Type).HasColumnName(@"Type").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Before).HasColumnName(@"Before").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.After).HasColumnName(@"After").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.HospId).HasColumnName(@"HospId").IsOptional().HasColumnType("int");
        }
    }
}
