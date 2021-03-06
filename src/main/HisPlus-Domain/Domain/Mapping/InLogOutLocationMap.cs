using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InLogOutLocationMap : EntityTypeConfiguration<InLogOutLocation>
    {
        public InLogOutLocationMap()
            : this("dbo")
        {
        }

        public InLogOutLocationMap(string schema)
        {
            ToTable("InLogOutLocation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.LocationId).HasColumnName(@"LocationID").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InLocId).HasColumnName(@"InLocId").IsOptional().HasColumnType("int");
            Property(x => x.LsType).HasColumnName(@"LsType").IsOptional().HasColumnType("smallint");
        }
    }
}
