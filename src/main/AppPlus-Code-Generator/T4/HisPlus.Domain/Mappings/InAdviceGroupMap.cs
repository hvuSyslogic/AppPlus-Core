using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InAdviceGroupMap : EntityTypeConfiguration<InAdviceGroup>
    {
        public InAdviceGroupMap()
            : this("dbo")
        {
        }

        public InAdviceGroupMap(string schema)
        {
            ToTable("InAdviceGroup", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.UsageId).HasColumnName(@"UsageId").IsRequired().HasColumnType("int");
            Property(x => x.GroupNum).HasColumnName(@"GroupNum").IsOptional().HasColumnType("smallint");
            Property(x => x.LsMarkType).HasColumnName(@"LsMarkType").IsOptional().HasColumnType("smallint");
            Property(x => x.MaxFrequency).HasColumnName(@"MaxFrequency").IsOptional().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsOptional().HasColumnType("int");
        }
    }
}
