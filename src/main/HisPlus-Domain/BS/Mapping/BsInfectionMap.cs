using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsInfectionMap : EntityTypeConfiguration<BsInfection>
    {
        public BsInfectionMap()
            : this("dbo")
        {
        }

        public BsInfectionMap(string schema)
        {
            ToTable("BsInfection", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Type).HasColumnName(@"type").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"f1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"f2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"f3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"f4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Isactive).HasColumnName(@"isactive").IsOptional().HasColumnType("bit");
            Property(x => x.Orderby).HasColumnName(@"orderby").IsOptional().HasColumnType("int");
        }
    }
}
