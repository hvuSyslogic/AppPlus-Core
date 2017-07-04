using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class InOutLocationMap : EntityTypeConfiguration<InOutLocation>
    {
        public InOutLocationMap()
            : this("dbo")
        {
        }

        public InOutLocationMap(string schema)
        {
            ToTable("InOutLocation", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.HospId).HasColumnName(@"HospId").IsRequired().HasColumnType("int");
            Property(x => x.BedId).HasColumnName(@"BedId").IsRequired().HasColumnType("int");
            Property(x => x.OutLocId).HasColumnName(@"OutLocId").IsRequired().HasColumnType("int");
            Property(x => x.OutOperTime).HasColumnName(@"OutOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OutOperId).HasColumnName(@"OutOperId").IsOptional().HasColumnType("int");
            Property(x => x.IsReceived).HasColumnName(@"isReceived").IsOptional().HasColumnType("bit");
            Property(x => x.InLocId).HasColumnName(@"InLocId").IsOptional().HasColumnType("int");
            Property(x => x.InOperTime).HasColumnName(@"InOperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InOperId).HasColumnName(@"InOperId").IsOptional().HasColumnType("int");
        }
    }
}
