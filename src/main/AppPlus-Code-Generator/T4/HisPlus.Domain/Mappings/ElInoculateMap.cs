using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElInoculateMap : EntityTypeConfiguration<ElInoculate>
    {
        public ElInoculateMap()
            : this("dbo")
        {
        }

        public ElInoculateMap(string schema)
        {
            ToTable("ElInoculate", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("int");
            Property(x => x.HospitalId).HasColumnName(@"HospitalId").IsOptional().HasColumnType("int");
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.NTime).HasColumnName(@"NTime").IsRequired().HasColumnType("smallint");
            Property(x => x.PlanTime).HasColumnName(@"PlanTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.PlanOperId).HasColumnName(@"PlanOperId").IsRequired().HasColumnType("int");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.IsInoculate).HasColumnName(@"IsInoculate").IsRequired().HasColumnType("bit");
            Property(x => x.InoTime).HasColumnName(@"InoTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InoOperId).HasColumnName(@"InoOperId").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
