using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsCheckTestListMap : EntityTypeConfiguration<BsCheckTestList>
    {
        public BsCheckTestListMap()
            : this("dbo")
        {
        }

        public BsCheckTestListMap(string schema)
        {
            ToTable("BsCheckTestList", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IllId).HasColumnName(@"IllId").IsOptional().HasColumnType("int");
            Property(x => x.IllName).HasColumnName(@"IllName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
            Property(x => x.GroupType).HasColumnName(@"GroupType").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.CheckTestType).HasColumnName(@"CheckTestType").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.ItemId).HasColumnName(@"ItemId").IsOptional().HasColumnType("int");
            Property(x => x.ItemName).HasColumnName(@"ItemName").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ItemDesc).HasColumnName(@"ItemDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
            Property(x => x.ItemResult).HasColumnName(@"ItemResult").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
