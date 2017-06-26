using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsnotYbMap : EntityTypeConfiguration<BsnotYb>
    {
        public BsnotYbMap()
            : this("dbo")
        {
        }

        public BsnotYbMap(string schema)
        {
            ToTable("BsnotYb", schema);
            HasKey(x => x.Itemid);

            Property(x => x.Code).HasColumnName(@"Code").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.PriceIn).HasColumnName(@"PriceIn").IsOptional().HasColumnType("decimal").HasPrecision(12,4);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(255);
            Property(x => x.Itemid).HasColumnName(@"itemid").IsRequired().HasColumnType("int");
        }
    }
}
