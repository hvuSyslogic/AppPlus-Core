using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class ElPatFormIllMap : EntityTypeConfiguration<ElPatFormIll>
    {
        public ElPatFormIllMap()
            : this("dbo")
        {
        }

        public ElPatFormIllMap(string schema)
        {
            ToTable("ElPatFormIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatFormId).HasColumnName(@"PatFormId").IsOptional().HasColumnType("int");
            Property(x => x.ListNum).HasColumnName(@"ListNum").IsOptional().HasColumnType("int");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsInOut).HasColumnName(@"LsInOut").IsOptional().HasColumnType("smallint");
            Property(x => x.LsWestChin).HasColumnName(@"LsWestChin").IsOptional().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
