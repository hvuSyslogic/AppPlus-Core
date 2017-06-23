using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class RdLessonMap : EntityTypeConfiguration<RdLesson>
    {
        public RdLessonMap()
            : this("dbo")
        {
        }

        public RdLessonMap(string schema)
        {
            ToTable("RdLesson", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.LessonTypeId).HasColumnName(@"LessonTypeId").IsRequired().HasColumnType("int");
            Property(x => x.LessonTime).HasColumnName(@"LessonTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.Location).HasColumnName(@"Location").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Numbers).HasColumnName(@"Numbers").IsOptional().HasColumnType("smallint");
            Property(x => x.Company).HasColumnName(@"Company").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Occupation).HasColumnName(@"Occupation").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Teacher).HasColumnName(@"Teacher").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Title).HasColumnName(@"Title").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.Content).HasColumnName(@"Content").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsOptional().HasColumnType("int");
            Property(x => x.F1).HasColumnName(@"F1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F2).HasColumnName(@"F2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F3).HasColumnName(@"F3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.F4).HasColumnName(@"F4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
