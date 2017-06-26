using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatTypeYbIllMap : EntityTypeConfiguration<BsPatTypeYbIll>
    {
        public BsPatTypeYbIllMap()
            : this("dbo")
        {
        }

        public BsPatTypeYbIllMap(string schema)
        {
            ToTable("BsPatTypeYbIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.TallyTypeId).HasColumnName(@"TallyTypeId").IsOptional().HasColumnType("int");
            Property(x => x.PatTypeId).HasColumnName(@"PatTypeId").IsOptional().HasColumnType("int");
            Property(x => x.YbCode).HasColumnName(@"YbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.YbDesc).HasColumnName(@"YbDesc").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.IllIds).HasColumnName(@"IllIds").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(10);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
