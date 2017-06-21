using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsItemYbMap : EntityTypeConfiguration<BsItemYb>
    {
        public BsItemYbMap()
            : this("dbo")
        {
        }

        public BsItemYbMap(string schema)
        {
            ToTable("BsItemYb", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsRequired().HasColumnType("int");
            Property(x => x.TallyGroupId).HasColumnName(@"TallyGroupId").IsRequired().HasColumnType("int");
            Property(x => x.YbCode).HasColumnName(@"YbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.YbDesc).HasColumnName(@"YbDesc").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsYbType).HasColumnName(@"LsYbType").IsRequired().HasColumnType("smallint");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.LsAuthstatus).HasColumnName(@"LsAuthstatus").IsOptional().HasColumnType("smallint");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.DrugCode).HasColumnName(@"DrugCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
