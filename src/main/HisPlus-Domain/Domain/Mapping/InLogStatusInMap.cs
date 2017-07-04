using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InLogStatusInMap : EntityTypeConfiguration<InLogStatusIn>
    {
        public InLogStatusInMap()
            : this("dbo")
        {
        }

        public InLogStatusInMap(string schema)
        {
            ToTable("InLogStatusIn", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationID").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.LsInIllness).HasColumnName(@"LsInIllness").IsOptional().HasColumnType("int");
        }
    }
}
