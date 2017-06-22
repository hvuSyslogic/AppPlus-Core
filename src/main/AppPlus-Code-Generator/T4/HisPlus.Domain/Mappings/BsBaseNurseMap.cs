using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsBaseNurseMap : EntityTypeConfiguration<BsBaseNurse>
    {
        public BsBaseNurseMap()
            : this("dbo")
        {
        }

        public BsBaseNurseMap(string schema)
        {
            ToTable("BsBaseNurse", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(6);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
            Property(x => x.GroupMainId).HasColumnName(@"GroupMainId").IsOptional().HasColumnType("int");
            Property(x => x.GroupSubId).HasColumnName(@"GroupSubId").IsOptional().HasColumnType("int");
            Property(x => x.GroupSubId2).HasColumnName(@"GroupSubId2").IsOptional().HasColumnType("int");
            Property(x => x.EngDesc).HasColumnName(@"EngDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsYbType).HasColumnName(@"LsYbType").IsOptional().HasColumnType("smallint");
            Property(x => x.YbMemo).HasColumnName(@"YbMemo").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
        }
    }
}
