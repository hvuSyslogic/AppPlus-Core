using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsPatIllMap : EntityTypeConfiguration<BsPatIll>
    {
        public BsPatIllMap()
            : this("dbo")
        {
        }

        public BsPatIllMap(string schema)
        {
            ToTable("BsPatIll", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.PatId).HasColumnName(@"PatId").IsRequired().HasColumnType("bigint");
            Property(x => x.IcdId).HasColumnName(@"IcdId").IsOptional().HasColumnType("int");
            Property(x => x.IllDesc).HasColumnName(@"IllDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.LsWestChin).HasColumnName(@"LsWestChin").IsOptional().HasColumnType("smallint");
            Property(x => x.IllTime).HasColumnName(@"IllTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.ConfirmDoctor).HasColumnName(@"ConfirmDoctor").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LsEffect).HasColumnName(@"LsEffect").IsOptional().HasColumnType("smallint");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
