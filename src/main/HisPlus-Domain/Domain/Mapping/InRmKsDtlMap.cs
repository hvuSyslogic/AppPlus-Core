using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InRmKsDtlMap : EntityTypeConfiguration<InRmKsDtl>
    {
        public InRmKsDtlMap()
            : this("dbo")
        {
        }

        public InRmKsDtlMap(string schema)
        {
            ToTable("InRmKsDtl", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.DetailId).HasColumnName(@"DetailId").IsOptional().HasColumnType("int");
            Property(x => x.BillId).HasColumnName(@"BillId").IsRequired().HasColumnType("int");
        }
    }
}
