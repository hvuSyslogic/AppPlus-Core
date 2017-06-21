using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsXdRpMap : EntityTypeConfiguration<BsXdRp>
    {
        public BsXdRpMap()
            : this("dbo")
        {
        }

        public BsXdRpMap(string schema)
        {
            ToTable("BsXdRp", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(20);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupMain).HasColumnName(@"GroupMain").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupSub).HasColumnName(@"GroupSub").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsOptional().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsOpenType).HasColumnName(@"LsOpenType").IsRequired().HasColumnType("smallint");
            Property(x => x.OperId).HasColumnName(@"OperId").IsRequired().HasColumnType("int");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.LocationId).HasColumnName(@"LocationId").IsRequired().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.TestId).HasColumnName(@"TestId").IsOptional().HasColumnType("int");
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsOptional().HasColumnType("smallint");
            Property(x => x.ExecLocId).HasColumnName(@"ExecLocId").IsOptional().HasColumnType("int");
        }
    }
}
