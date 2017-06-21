using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsTestPaperMap : EntityTypeConfiguration<BsTestPaper>
    {
        public BsTestPaperMap()
            : this("dbo")
        {
        }

        public BsTestPaperMap(string schema)
        {
            ToTable("BsTestPaper", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.UserId).HasColumnName(@"UserId").IsRequired().HasColumnType("int");
            Property(x => x.GenerateTime).HasColumnName(@"GenerateTime").IsRequired().HasColumnType("datetime");
            Property(x => x.QuestionId).HasColumnName(@"QuestionId").IsRequired().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.UsersId).HasColumnName(@"UsersId").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
